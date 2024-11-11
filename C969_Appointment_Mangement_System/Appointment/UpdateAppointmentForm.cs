using C969_Appointment_Mangement_System.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Appointment_Mangement_System.Appointment
{
    public partial class UpdateAppointmentForm : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn = DBConnection.conn;
        MySqlDataReader reader;

        string apptId;

        public UpdateAppointmentForm(string appointmentId, string customerId, string userId, string title, string type, string date, string startTime, string endTime)
        {
            InitializeComponent();
            startDTP.CustomFormat = "HH:mm";
            endDTP.CustomFormat = "HH:mm";
            dateDTP.Value = DateTime.Now.Date;

            // prefills the form with the information from the selected appointment
            apptId = appointmentId;
            CustomerIdCB.Text = customerId;
            userIdCB.Text = userId;
            titleText.Text = title.Trim();
            typeText.Text = type.Trim();
            string tempDate = date;
            string tempStart = startTime;
            string tempEnd = endTime;

            // disables customer combobox to be changed
            CustomerIdCB.Enabled = false;

            populateUserCB();
            formatDateTimeFields(tempDate, tempStart, tempEnd);
        }
        // updates appointment if all validation checks are good
        private void updateAppointmentBtn_Click(object sender, EventArgs e)
        {
            string userId, customerId, apptTitle, apptType, startTime, endTime, startUTC, endUTC;
            
            // Gets appointment information from entries on the appointment form
            GetAppointmentInfo(out userId, out customerId, out apptTitle, out apptType, out startTime, out endTime, out startUTC, out endUTC);

            // make sure text fields are filled out && check within business hours && checks to see if appointments will overlap
            if (allFieldsFilledOut(apptTitle, apptType) == true && checkBusinessHours(startTime, endTime) == true && apptOverlap(userId, startUTC, endUTC) == false)
            {
                try
                {
                    string appointmentUpdate = $"UPDATE appointment set userId = {userId}, customerId = {customerId}, type = '{apptType}', title = '{apptTitle}', start = '{startUTC}', end = '{endUTC}' WHERE appointmentId = {apptId}";
                    cmd = new MySqlCommand(appointmentUpdate, conn);
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
        // gets and prefills fields for the form depending on what appointment was selected on main form
        private void GetAppointmentInfo(out string userId, out string customerId, out string apptTitle, out string apptType, out string startTime, out string endTime, out string startUTC, out string endUTC)
        {
            userId = userIdCB.Text;
            customerId = CustomerIdCB.Text;
            apptTitle = titleText.Text;
            apptType = typeText.Text;
            string date = dateDTP.Value.ToString("yyyy-MM-dd");
            startTime = startDTP.Value.ToString("HH:mm");
            endTime = endDTP.Value.ToString("HH:mm");
            string tempStart = date + " " + startTime + ":00";
            string tempEnd = date + " " + endTime + ":00";

            DateTime tempStartUTC = DateTimeOffset.Parse(tempStart).UtcDateTime;
            DateTime tempEndUTC = DateTimeOffset.Parse(tempEnd).UtcDateTime;

            startUTC = tempStartUTC.ToString("yyyy-MM-dd HH:mm:ss");
            endUTC = tempEndUTC.ToString("yyyy-MM-dd HH:mm:ss");
        }
        // makes sure the updated appointment does not overlap with existing appointments
        private bool apptOverlap(string userId, string startUTC, string endUTC)
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
        // checks to make sure updates to appointment are still within business hours and days
        private bool checkBusinessHours(string startTime, string endTime)
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
        // makes sure all fields are filled out and no whitespace
        private static bool allFieldsFilledOut(string apptTitle, string apptType)
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

        // converts date and time fields back into DateTime for match the formatting on the Update Appointment form then converts them back to strings
        private void formatDateTimeFields(string tempDate, string tempStart, string tempEnd)
        {
            DateTime apptDate = DateTime.Parse(tempDate);
            DateTime apptStart = DateTime.Parse(tempStart);
            DateTime apptEnd = DateTime.Parse(tempEnd);

            dateDTP.Text = apptDate.ToString("MM-dd-yyyy");
            startDTP.Text = apptStart.ToString("hh:mm:ss tt");
            endDTP.Text = apptEnd.ToString("hh:mm:ss tt");
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
        // closes and returns user to main form
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
