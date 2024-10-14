using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Appointment_Mangement_System.Database
{
    public class DBConnection
    {
        public static MySqlConnection conn { get; set; }

        public static void startConnection()
        {
            try
            {

                // get the connection string
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

                conn = new MySqlConnection(constr);

                //open connection
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void stopConnection()
        {
            try
            {
                // close connection
                if (conn != null)
                {
                    conn.Close();
                }
                conn = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
