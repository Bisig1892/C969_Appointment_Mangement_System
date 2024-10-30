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
    public partial class CustomerAppointmentCountForm : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn = DBConnection.conn;
        MySqlDataAdapter adp;
        public CustomerAppointmentCountForm()
        {
            InitializeComponent();

            string query = "SELECT customer.customerName AS Customer, count(appointment.customerId) AS Count FROM appointment " +
                                               "JOIN Customer ON appointment.customerId = customer.customerId group by Customer;";
            cmd = new MySqlCommand(query, conn);
            
            adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            custApptCountDGV.DataSource = dt;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
