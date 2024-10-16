using C969_Appointment_Mangement_System.Database;
using C969_Appointment_Mangement_System.Models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Appointment_Mangement_System
{
    public partial class AddCustomerForm : Form
    {

        MySqlCommand cmd;
        MySqlConnection conn = DBConnection.conn;
        private delegate bool Validate();

        

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

            // phone numbers with dashes
            Regex phone1Regex = new Regex(@"^(\d{3}[-]?){1,2}(\d{4})$"); 

            // phone numbers without dashes
            //Regex phone2Regex = new Regex(@"^\d{10}$");

            // letter and spaces only
            Regex letterAndWhitespaceRegex = new Regex(@"^[a-zA-Z\s]+$");

            // letter, number and spaces needed for address
            Regex addressRegex = new Regex(@"^[a-zA-Z0-9\s]+$");




            Validate validate = () =>
            {
                bool validation = false;
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(country))
                {
                    MessageBox.Show("All fields must be filled out.");
                    validation = false;
                }
                else if (!phone1Regex.IsMatch(phone))
                {
                    MessageBox.Show("Please enter a valid 10 digit phone number.\nExample:\n123-456-7890 or 1234567890");
                    validation = false;
                }
                //else if (!phone2Regex.IsMatch(phone))
                //{
                //    MessageBox.Show("Please enter a valid 10 digit phone number.\nExample:\n123-456-7890 or 1234567890");
                //    validation = false;
                //}
                else if (!letterAndWhitespaceRegex.IsMatch(name) || !letterAndWhitespaceRegex.IsMatch(city) || !(letterAndWhitespaceRegex.IsMatch(country)))
                {
                    MessageBox.Show("Please only use uppercase and lowercase letters for the following fields:\nName, City, Country");
                    validation = false;
                }
                else if (!addressRegex.IsMatch(address))
                {
                    MessageBox.Show("Addresses can only have numbers, letters, and spaces.");
                    validation = false;
                }
                else
                {
                    validation = true;
                }
                return validation;
            };

            if(validate() == true)
            {
                try
                {
                    int countryIndex = getCountryIfExists(country);

                    int cityIndex = getCityIfExists(city, countryIndex);

                    int addressIndex = getAddressIfExists(address, phone, cityIndex);

                    getcustomerIfExists(name, addressIndex);

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

        private void getcustomerIfExists(string name, int addressIndex)
        {
            // Checks to see if customer already exists and add customer if it doesn't
            string customerIfExists = "SELECT customerId FROM customer ORDER BY customerId DESC LIMIT 1";
            cmd = new MySqlCommand(customerIfExists, conn);
            int customerIndex = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            string addCustomer = $"INSERT INTO customer VALUES({customerIndex}, '{name}', {addressIndex}, 1, UTC_TIMESTAMP(), 'admin', UTC_TIMESTAMP(), 'admin')";
            var customerInsertCommand = new MySqlCommand(addCustomer, conn);
            customerInsertCommand.Prepare();
            customerInsertCommand.ExecuteNonQuery();
        }

        private int getAddressIfExists(string address, string phone, int cityIndex)
        {
            // Checks to see if address already exists and adds address if it doesn't
            string addressIfExists = "SELECT addressId FROM address ORDER BY addressId DESC LIMIT 1";
            cmd = new MySqlCommand(addressIfExists, conn);
            int addressIndex = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            string addAddress = $"INSERT INTO address VALUES({addressIndex}, '{address}', '', {cityIndex}, 12345, '{phone}', UTC_TIMESTAMP(), 'admin', UTC_TIMESTAMP(), 'admin')";
            var addressInsertCommand = new MySqlCommand(addAddress, conn);
            addressInsertCommand.Prepare();
            addressInsertCommand.ExecuteNonQuery();
            return addressIndex;
        }

        private int getCityIfExists(string city, int countryIndex)
        {
            // Checks to see if city already exists and adds city if it doesn't
            string cityIfExists = "SELECT cityId FROM city ORDER BY cityId DESC LIMIT 1";
            cmd = new MySqlCommand(cityIfExists, conn);
            int cityIndex = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            string addCity = $"INSERT INTO city VALUES({cityIndex},'{city}', {countryIndex}, UTC_TIMESTAMP(), 'admin', UTC_TIMESTAMP(), 'admin')";
            var cityInsertCommand = new MySqlCommand(addCity, conn);
            cityInsertCommand.Prepare();
            cityInsertCommand.ExecuteNonQuery();
            return cityIndex;
        }

        private int getCountryIfExists(string country)
        {
            // Checks to see if country already exists and adds country if it doesn't
            string countryIfExists = "SELECT countryId FROM country ORDER BY countryId DESC LIMIT 1";
            cmd = new MySqlCommand(countryIfExists, conn);
            int countryIndex = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            string addCountry = $"INSERT INTO country VALUES({countryIndex}, '{country}', UTC_TIMESTAMP() , 'admin', UTC_TIMESTAMP() , UTC_TIMESTAMP() )";
            var countryInsertCommand = new MySqlCommand(addCountry, conn);
            countryInsertCommand.Prepare();
            countryInsertCommand.ExecuteNonQuery();
            return countryIndex;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form = new MainForm();
            form.Show();
        }
    }
}
