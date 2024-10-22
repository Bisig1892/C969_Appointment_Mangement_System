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
            DateDTP.Value = DateTime.Now.Date;

            // Gets the ids for users and customers and populates them into the corralating combo boxes
            populateUserCB();
            populateCustomerCB();

        }

        private void addAppointmentBtn_Click(object sender, EventArgs e)
        {

            string userId = userIdCB.Text;
            string customerId = CustomerIdCB.Text;
            string apptTitle = titleText.Text;
            string apptType = typeText.Text;
            string date = DateDTP.Value.ToString("yyyy-MM-dd");
            string startTime = startDTP.Value.ToString("HH:mm");
            string endTime = endDTP.Value.ToString("HH:mm");



            string tempStart = date + " " + startTime + ":00";
            string tempEnd = date + " " + endTime + ":00";

            DateTime tempStartUTC = DateTimeOffset.Parse(tempStart).UtcDateTime;
            DateTime tempEndUTC = DateTimeOffset.Parse(tempEnd).UtcDateTime;

            string startUTC = tempStartUTC.ToString("yyyy-MM-dd HH:mm:ss");
            string endUTC = tempEndUTC.ToString("yyyy-MM-dd HH:mm:ss");



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
            
            // check within business hours
            // make sure text fields are filled out
            
            if (apptOverlap() == false)
            {
                try
                {
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


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form = new MainForm();
            form.Show();
        }
    }
}
