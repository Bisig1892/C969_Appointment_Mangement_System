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

namespace C969_Appointment_Mangement_System.Reports
{
    public partial class UserScheduleReportForm : Form
    {

        MySqlCommand cmd;
        MySqlConnection conn = DBConnection.conn;
        MySqlDataReader reader;

        public UserScheduleReportForm()
        {
            InitializeComponent();
            populateUserCB();
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

        private void userIdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userID = userIdCB.Text; 

            cmd = new MySqlCommand($"SELECT appointmentId AS ID, customer.customerId AS 'Customer ID', customer.customerName AS Customer, user.userId AS 'User ID', user.userName AS User, title AS Title, type AS Type, " +
                            $"appointment.start AS Date, appointment.start AS 'Start Time', appointment.end AS 'End Time'" +
                            $"FROM appointment JOIN Customer ON appointment.customerID = customer.customerId " +
                                             $"JOIN User ON appointment.userId = user.userId WHERE user.userId = '{userID}';", conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            userApptDGV.DataSource = dt;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["Date"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[i]["Date"], TimeZoneInfo.Local).ToString();
                dt.Rows[i]["Start Time"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[i]["Start Time"], TimeZoneInfo.Local).ToString();
                dt.Rows[i]["End Time"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[i]["End Time"], TimeZoneInfo.Local).ToString();

                userApptDGV.Columns[7].DefaultCellStyle.Format = "MM'-'dd'-'yyyy";
                userApptDGV.Columns[8].DefaultCellStyle.Format = "hh':'mm tt";
                userApptDGV.Columns[9].DefaultCellStyle.Format = "hh':'mm tt";
            }

            userApptDGV.Columns["Customer ID"].Visible = false;
            userApptDGV.Columns["User ID"].Visible = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
