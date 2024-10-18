using C969_Appointment_Mangement_System.Database;
using C969_Appointment_Mangement_System.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C969_Appointment_Mangement_System
{
    public partial class UpdateCustomerForm : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn = DBConnection.conn;
        private delegate bool Validate();
        string customerId;

        public UpdateCustomerForm(string custId, string custName, string custAddress, string custPhone, string custCity, string custCountry)
        {
            InitializeComponent();

            customerId = custId;
            nameText.Text = custName.Trim();
            AddressText.Text = custAddress.Trim();
            phoneNumberText.Text = custPhone.Trim();
            cityText.Text = custCity.Trim();
            countryText.Text = custCountry.Trim();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string name = nameText.Text.Trim();
            string address = AddressText.Text.Trim();
            string city = cityText.Text.Trim();
            string country = countryText.Text.Trim();

            string phone = phoneNumberText.Text.Trim();

            // phone numbers with dashes
            Regex phone1Regex = new Regex(@"^(\d{3}[-]?){1,2}(\d{4})$");

            // phone numbers without dashes
            //Regex phone2Regex = new Regex(@"^\d{10}$");

            // letter and spaces only
            Regex letterAndWhitespaceRegex = new Regex(@"^[a-zA-Z\s]+$");

            // letter, number and spaces needed for address
            Regex addressRegex = new Regex(@"^[a-zA-Z0-9\s]+$");


            // validates the text entries made by the user with the regex created above
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

            // updates the records for the customer selected
            if (validate() == true)
            {
                try
                {
                    string updateQuery = "UPDATE customer JOIN address ON customer.addressId = address.addressId " +
                                "LEFT JOIN city ON address.cityId = city.cityId " +
                                "LEFT JOIN country ON city.countryId = country.countryId " +
                                $"SET customer.customerName = '{name}', " +
                                    $"address.Phone = '{phone}', " +
                                    $"address.address = '{address}', " +
                                    $"city.city = '{city}', " +
                                    $"country.country = '{country}' " +
                                    $"WHERE customer.customerId = {customerId} ;";
                    
                    cmd = new MySqlCommand(updateQuery, DBConnection.conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successful.");


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
        // closes form and reloads main form
        private void closeBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }

}
