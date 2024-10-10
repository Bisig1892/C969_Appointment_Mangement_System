using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
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


        public LoginForm()
        {
            InitializeComponent();
            CheckLanguage();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

        }

        private void CheckLanguage()
        {
            if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "MX")
            {
                this.Text = "Acceso";
                loginLabel.Text = "Acceso";
                usernameLabel.Text = "Nombre de usuario";
                passwordLabel.Text = "Contraseña";
                loginBtn.Text = "Acceso";
                closeBtn.Text = "Cerca";
            }
        }
    }
}
