using C969_Appointment_Mangement_System.Database;
using C969_Appointment_Mangement_System.Models;
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

namespace C969_Appointment_Mangement_System
{
    public partial class AddCustomerForm : Form
    {

        MySqlCommand cmd;
        MySqlConnection conn = DBConnection.conn;

        // private MainForm mainForm = null;

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameText.Text.Trim();
            string address = AddressText.Text.Trim();
            string phone = phoneNumberText.Text.Trim();
            string city = cityText.Text.Trim();
            string country = countryText.Text.Trim();

             
            
            try
            {

                // Checks to see if country already exists and adds country if it doesn't
                string countryIfExists = "SELECT countryId FROM country ORDER BY countryId DESC LIMIT 1";
                cmd = new MySqlCommand(countryIfExists, conn);
                int countryIndex = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

                string addCountry = $"INSERT INTO country VALUES({countryIndex}, '{country}', UTC_TIMESTAMP() , 'admin', UTC_TIMESTAMP() , UTC_TIMESTAMP() )";
                var countryInsertCommand = new MySqlCommand(addCountry, conn);
                countryInsertCommand.Prepare();
                countryInsertCommand.ExecuteNonQuery();


                // Checks to see if city already exists and adds city if it doesn't
                string cityIfExists = "SELECT cityId FROM city ORDER BY cityId DESC LIMIT 1";
                cmd = new MySqlCommand(cityIfExists, conn);
                int cityIndex = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

                string addCity = $"INSERT INTO city VALUES({cityIndex},'{city}', {countryIndex}, UTC_TIMESTAMP(), 'admin', UTC_TIMESTAMP(), 'admin')";
                var cityInsertCommand = new MySqlCommand(addCity, conn);
                cityInsertCommand.Prepare();
                cityInsertCommand.ExecuteNonQuery();

                // Checks to see if address already exists and adds address if it doesn't
                string addressIfExists = "SELECT addressId FROM address ORDER BY addressId DESC LIMIT 1";
                cmd = new MySqlCommand(addressIfExists, conn);
                int addressIndex = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

                string addAddress = $"INSERT INTO address VALUES({addressIndex}, '{address}', '', {cityIndex}, 12345, '{phone}', UTC_TIMESTAMP(), 'admin', UTC_TIMESTAMP(), 'admin')";
                var addressInsertCommand = new MySqlCommand(addAddress, conn);
                addressInsertCommand.Prepare();
                addressInsertCommand.ExecuteNonQuery();

                // Checks to see if customer already exists and add customer if it doesn't
                string customerIfExists = "SELECT customerId FROM customer ORDER BY customerId DESC LIMIT 1";
                cmd = new MySqlCommand(customerIfExists, conn);
                int customerIndex = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

                string addCustomer = $"INSERT INTO customer VALUES({customerIndex}, '{name}', {addressIndex}, 1, UTC_TIMESTAMP(), 'admin', UTC_TIMESTAMP(), 'admin')";
                var customerInsertCommand = new MySqlCommand(addCustomer, conn);
                customerInsertCommand.Prepare();
                customerInsertCommand.ExecuteNonQuery();

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
