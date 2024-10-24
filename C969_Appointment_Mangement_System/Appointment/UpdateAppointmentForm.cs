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

        string apptId;

        public UpdateAppointmentForm(string appointmentId, string customerId, string userId, string title, string type, string date, string startTime, string endTime)
        {
            InitializeComponent();

            apptId = appointmentId;
            CustomerIdCB.Text = customerId;
            userIdCB.Text = userId;
            titleText.Text = title.Trim();
            typeText.Text = type.Trim();
            
            string tempDate = date; 
            string tempStart = startTime;
            string tempEnd = endTime;

            DateTime apptDate = DateTime.Parse(tempDate);
            DateTime apptStart = DateTime.Parse(tempStart);
            DateTime apptEnd = DateTime.Parse(tempEnd);

            dateDTP.Text = apptDate.ToString("MM-dd-yyyy");
            startDTP.Text = apptStart.ToString("hh:mm:ss tt");
            endDTP.Text = apptEnd.ToString("hh:mm:ss tt");


        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
