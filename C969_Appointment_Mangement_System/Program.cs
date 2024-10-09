using C969_Appointment_Mangement_System.Database;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Appointment_Mangement_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DBConnection.startConnection();
            Application.Run(new LoginForm());
            DBConnection.stopConnection();
        }
    }
}
