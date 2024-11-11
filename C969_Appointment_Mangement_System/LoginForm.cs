using C969_Appointment_Mangement_System.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C969_Appointment_Mangement_System
{
    public partial class LoginForm : Form
    {
        MySqlDataReader reader;
        MySqlCommand cmd;
        MySqlConnection conn = DBConnection.conn;
        MySqlDataAdapter adp;

        private readonly string userCulture = CultureInfo.CurrentCulture.Name;
        public static string username { get; set; }
        public static int userID { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (userCulture == "es-MX")
            {
                this.Text = "Acceso";
                loginLabel.Text = "Acceso";
                usernameLabel.Text = "Nombre de usuario";
                passwordLabel.Text = "Contraseña";
                loginBtn.Text = "Acceso";
                closeBtn.Text = "Cerca";
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            string username = usernameTb.Text;
            string password = passwordTb.Text;

            // log file file location C969_Appointment_Mangement_System\C969_Appointment_Mangement_System\bin\Debug
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs-Login.txt";

            try
            {
                cmd = new MySqlCommand($"SELECT userId, userName, password FROM user", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                bool loginSuccess = false;
                string userId = "";
                

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["userName"].ToString() == username && dr["password"].ToString() == password) 
                    {
                        loginSuccess = true;
                        userId = dr["userId"].ToString();
                        break;
                    }
                    else
                    {
                        loginSuccess = false;
                    }
                }

                if (loginSuccess == true)
                {
                    if (File.Exists(filePath) == false)
                    {
                        File.Create(filePath).Dispose();

                        StringBuilder sb = new StringBuilder();
                        sb.Append($"USER: {username} successfully logged in at {DateTime.UtcNow} UTC. \n");

                        File.AppendAllText(filePath, sb.ToString());
                        sb.Clear();
                    }
                    else if (File.Exists(filePath) == true)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append($"USER: {username} successfully logged in at {DateTime.UtcNow} UTC. \n");

                        File.AppendAllText(filePath, sb.ToString());
                        sb.Clear();
                    }

                    this.Hide();
                    MainForm mainForm = new MainForm(userId);
                    mainForm.Show();
                }
                else
                {
                    if (userCulture == "es-MX")
                    {
                        MessageBox.Show("Contraseña o nombre de usuario incorrectos. Por favor inténtalo de nuevo.");
                    }
                    else
                    {
                        MessageBox.Show("Wrong passsword or username. Please try again.");
                    }
                    passwordTb.Clear();

                    if (File.Exists(filePath) == false)
                    {
                        File.Create(filePath).Dispose();

                        StringBuilder sb = new StringBuilder();
                        sb.Append($"FAILED login attempt with USER: {username} at {DateTime.UtcNow} UTC. \n");

                        File.AppendAllText(filePath, sb.ToString());
                        sb.Clear();
                    }
                    else if (File.Exists(filePath) == true)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append($"FAILED login attempt with USER: {username} at {DateTime.UtcNow} UTC. \n");

                        File.AppendAllText(filePath, sb.ToString());
                        sb.Clear();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }

        }

        
           

        //private void upcomingAppt(string Id)
        //{
        //    string userId = Id;
            
        //    string appointmentAlert = $"SELECT * FROM appointment";
        //    cmd = new MySqlCommand(appointmentAlert, conn);
        //    adp = new MySqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    adp.Fill(dt);

        //    foreach(DataRow dr in dt.Rows)
        //    {
        //        if (dr["userId"].ToString() == userId)
        //        {
        //            var dBTime = DateTime.Parse(dr["start"].ToString()).ToLocalTime();
        //            var localTime = DateTime.Now.ToLocalTime();

        //            MessageBox.Show(dBTime.ToString(), localTime.ToString());
        //            if (dBTime.Date == localTime.Date)
        //            {
        //                var timeDifferential = dBTime.Subtract(localTime);
        //                if (timeDifferential.TotalMinutes <= 15)
        //                {
        //                    MessageBox.Show("Attention!\nThere is an appointment within the next 15 minutes.");
        //                }
        //            }
        //        }
        //    }



        //}

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
