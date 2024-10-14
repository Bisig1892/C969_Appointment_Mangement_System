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

namespace C969_Appointment_Mangement_System
{
    public partial class MainForm : Form
    {
        MySqlDataReader reader;
        MySqlCommand cmd;
        MySqlConnection conn = DBConnection.conn;


        public MainForm()
        {
            InitializeComponent();
            populateCustomerTable();
        }

        private void populateCustomerTable()
        {
            cmd = new MySqlCommand("SELECT customer.customerId AS ID, customer.customerName AS Customer_Name, address.address AS Address, address.phone AS Phone, city.city AS City, country.country AS Country " +
                                    "FROM customer JOIN address ON customer.addressId = address.addressId " +
                                                  "JOIN city ON address.cityId = city.cityId " +
                                                  "JOIN country ON city.countryId = country.countryId;", conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                var custTable = new BindingSource();
                custTable.DataSource = reader;
                CustomerDGV.DataSource = custTable;
            }
            reader.Close();
        }


    }
}
