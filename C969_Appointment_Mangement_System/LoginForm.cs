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

namespace C969_Appointment_Mangement_System
{
    public partial class LoginForm : Form
    {
        MySqlDataReader reader;
        MySqlCommand cmd;
        MySqlConnection conn = DBConnection.conn;

        private readonly string userCulture = CultureInfo.CurrentCulture.Name;
        public static string username { get; set; }
        public static int userID { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            //CheckLanguage();
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


            try
            {
                //verifyUser(username, password);
                cmd = new MySqlCommand($"SELECT userId, userName, password FROM user WHERE userName = '{username}' AND password = '{password}'", conn);
                DBConnection.startConnection();
                using (reader = cmd.ExecuteReader())
          
                if (reader.HasRows)
                {
                    if (userCulture == "es-MX")
                    {
                        MessageBox.Show($"Inicio de sesión exitosa \n¡Bienvenido {username}!");
                    }
                    else
                    {
                        MessageBox.Show($"Login successful \nWelcome {username}!");
                    }
                    this.Hide();
                    reader.Close();

                    MainForm mainForm = new MainForm();
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
                    usernameTb.Clear();
                    passwordTb.Clear();
                    reader.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
