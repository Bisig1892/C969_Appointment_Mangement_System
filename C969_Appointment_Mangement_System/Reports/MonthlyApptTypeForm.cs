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
    public partial class MonthlyApptTypeForm : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn = DBConnection.conn;
        MySqlDataAdapter adp;

        public MonthlyApptTypeForm()
        {
            InitializeComponent();
            reportText.Text = "Report: Number of each type of appointment per month: \r\n\r\n";
            string[] Months = new string[] { "January", "Febuary", "March", "April", "May", "June",
                                             "July", "August", "September", "October", "November", "December" };
            int temp = 1;
            foreach (string start in Months)
            {
                reportText.Text = reportText.Text + start + " Tpye \r\n";
                string query = $"SELECT type, COUNT(*) FROM appointment WHERE month(START) = {temp++} group by type;";
                cmd = new MySqlCommand(query, conn);
                adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    reportText.Text = reportText.Text + "\t" + dr[0].ToString() + "\t\t" + dr[1].ToString() + "\r\n";
                }
                reportText.Select(0, 0);
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
