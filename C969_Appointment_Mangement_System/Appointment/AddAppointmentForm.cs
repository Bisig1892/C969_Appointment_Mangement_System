using C969_Appointment_Mangement_System.Database;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Appointment_Mangement_System
{
    public partial class AddAppointmentForm : Form
    {
        MySqlDataReader reader;
        MySqlCommand cmd;
        MySqlConnection conn = DBConnection.conn;

        public AddAppointmentForm()
        {
            InitializeComponent();
            startDTP.CustomFormat = "HH:mm";
            endDTP.CustomFormat = "HH:mm";
            dateDTP.Value = DateTime.Now.Date;

            // Gets the ids for users and customers and populates them into the corralating combo boxes
            populateUserCB();
            populateCustomerCB();

            // sets default selection of the comboboxes to the first userId and customerId in the database
            CustomerIdCB.SelectedIndex = 0;
            userIdCB.SelectedIndex = 0;

        }

        private void addAppointmentBtn_Click(object sender, EventArgs e)
        {

            string userId = userIdCB.Text;
            string customerId = CustomerIdCB.Text;
            string apptTitle = titleText.Text;
            string apptType = typeText.Text;
            string date = dateDTP.Value.ToString("yyyy-MM-dd");
            string startTime = startDTP.Value.ToString("HH:mm");
            string endTime = endDTP.Value.ToString("HH:mm");



            string tempStart = date + " " + startTime + ":00";
            string tempEnd = date + " " + endTime + ":00";

            DateTime tempStartUTC = DateTimeOffset.Parse(tempStart).UtcDateTime;
            DateTime tempEndUTC = DateTimeOffset.Parse(tempEnd).UtcDateTime;

            string startUTC = tempStartUTC.ToString("yyyy-MM-dd HH:mm:ss");
            string endUTC = tempEndUTC.ToString("yyyy-MM-dd HH:mm:ss");

            // makes sure all fields are filled out with no whitespace
            bool allFieldsFilledOut() 
            {
                
                if (string.IsNullOrWhiteSpace(apptTitle) || string.IsNullOrWhiteSpace(apptType))
                {
                    MessageBox.Show("Please make sure all text fields are filled out.");
                    return false;
                }
                else
                {
                    return true;
                }

            }
            // checks to make sure scheduled appointment falls within business days and hours 
            bool checkBusinessHours()
            {
                if (DateTime.Parse(startTime) >= DateTime.Parse(endTime))
                {
                    MessageBox.Show("Please make sure your appointment start time is prior to the appointment end time.");
                    return false;
                }
                else if (dateDTP.Value.DayOfWeek == DayOfWeek.Saturday || dateDTP.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show("Business days are Monday - Friday. \nPlease pick a different date to schedule your appointment.");
                    return false;
                }
                else if ((DateTime.Parse(startDTP.Value.ToUniversalTime().ToString("HH:mm")) < DateTime.Parse("14:00")) || (DateTime.Parse(endDTP.Value.ToUniversalTime().ToString("HH:mm")) > DateTime.Parse("22:00")))
                {
                    MessageBox.Show("Please pick an start and end time between 9:00a.m. - 5:00p.m. EST");
                    return false;
                }
                else
                {
                    return true;
                }

            }

            // checks to make sure appointment does not overlap with existing.
            bool apptOverlap()
            {
                bool result = true;
                try
                {
                    string overlapAppointments = $"SELECT COUNT(*) FROM appointment WHERE start BETWEEN '{startUTC}' AND '{endUTC}' AND userId = {userId} " +
                                                 $"OR end BETWEEN '{startUTC}' AND '{endUTC}' AND userId = {userId}";
                    cmd = new MySqlCommand(overlapAppointments, conn);
                    int overLapIndex = Convert.ToInt32(cmd.ExecuteScalar());

                    if (overLapIndex != 0)
                    {
                        MessageBox.Show("This appointment would overlap with an existing appointment. \nPlease pick a different time or day.");
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return result;
            }
            // make sure text fields are filled out
            if (allFieldsFilledOut() == true)
            {
                // check within business hours
                if (checkBusinessHours() == true)
                {
                    // checks to see if appointments will overlap
                    if (apptOverlap() == false)
                    {
                        try
                        {
                            // creates the appointment
                            string getAppointmentIndex = "SELECT appointmentId FROM appointment ORDER BY appointmentId DESC LIMIT 1";
                            cmd = new MySqlCommand(getAppointmentIndex, conn);
                            int appointmentIndex = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

                            string appointmentInsert = $"INSERT INTO appointment VALUES({appointmentIndex}, {customerId}, {userId}, '{apptTitle}'," +
                                                       $"'not needed', 'not needed', 'not needed', '{apptType}', 'not needed', '{startUTC}', '{endUTC}', UTC_TIMESTAMP(), 'not needed', UTC_TIMESTAMP(), '')";
                            cmd = new MySqlCommand(appointmentInsert, conn);
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();
                            this.Close();
                            MainForm main = new MainForm();
                            main.Show();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

            }
        }
        // populates customer combobox
        private void populateCustomerCB()
        {
            cmd = new MySqlCommand("SELECT customerId FROM customer ORDER BY customerId", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CustomerIdCB.Items.Add(reader[0]);
            }
            reader.Close();
        }
        // populates user combobox
        private void populateUserCB()
        {
            cmd = new MySqlCommand("SELECT userId FROM user ORDER BY userId", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userIdCB.Items.Add(reader[0]);
            }
            reader.Close();
        }

        // closes and returns to main form
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form = new MainForm();
            form.Show();
        }
    }
}
