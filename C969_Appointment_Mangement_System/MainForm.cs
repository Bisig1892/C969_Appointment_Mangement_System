using C969_Appointment_Mangement_System.Appointment;
using C969_Appointment_Mangement_System.Database;
using C969_Appointment_Mangement_System.Reports;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            populateAppointmentTable();
        }
        // populates the appointment table
        private void populateAppointmentTable()
        {
            cmd = new MySqlCommand("SELECT appointmentId AS ID, customer.customerId AS 'Customer ID', customer.customerName AS Customer, user.userId AS 'User ID', user.userName AS User, title AS Title, type AS Type, " +
                                        "appointment.start AS Date, appointment.start AS 'Start Time', appointment.end AS 'End Time'" +
                                        "FROM appointment JOIN Customer ON appointment.customerID = customer.customerId " +
                                                         "JOIN User ON appointment.userId = user.userId ORDER BY Date ASC;", conn);


            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            appointmentsDGV.DataSource = dt;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["Date"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[i]["Date"], TimeZoneInfo.Local).ToString();
                dt.Rows[i]["Start Time"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[i]["Start Time"], TimeZoneInfo.Local).ToString();
                dt.Rows[i]["End Time"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[i]["End Time"], TimeZoneInfo.Local).ToString();

                appointmentsDGV.Columns[7].DefaultCellStyle.Format = "MM'-'dd'-'yyyy";
                appointmentsDGV.Columns[8].DefaultCellStyle.Format = "hh':'mm tt";
                appointmentsDGV.Columns[9].DefaultCellStyle.Format = "hh':'mm tt";
            }

            appointmentsDGV.Columns["Customer ID"].Visible = false;
            appointmentsDGV.Columns["User ID"].Visible = false;



        }

        // populates the customer table
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
                customerDGV.DataSource = custTable;
            }
            reader.Close();
        }
        // opens the add customer form
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
            this.Close();
        }
        // opens the update customer form with the information prefilled in textboxes for selected customer
        private void updateCustomerBtn_Click(object sender, EventArgs e)
        {
            string customerId = customerDGV.CurrentRow.Cells[0].Value.ToString();
            string name = customerDGV.CurrentRow.Cells[1].Value.ToString();
            string address = customerDGV.CurrentRow.Cells[2].Value.ToString();
            string phone = customerDGV.CurrentRow.Cells[3].Value.ToString();
            string city = customerDGV.CurrentRow.Cells[4].Value.ToString();
            string country = customerDGV.CurrentRow.Cells[5].Value.ToString();

            if (customerDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer you would like to update information for.");
            }
            else
            {
                UpdateCustomerForm updateCustomerForm = new UpdateCustomerForm(customerId, name, address, phone, city, country);
                updateCustomerForm.Show();
                this.Close();
            }
        }
        // deletes the customer selected
        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            if (customerDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer from the table to delete.");
            }
            else
            {
                try
                {
                    int customerId = (int)customerDGV.SelectedRows[0].Cells[0].Value;
                    string deleteCustomer = $"DELETE FROM customer WHERE customerId = {customerId}";
                    DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer?", MessageBoxButtons.YesNo);
                    if ( confirmation == DialogResult.Yes)
                    {
                        cmd = new MySqlCommand(deleteCustomer, conn);
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                        populateCustomerTable();
                    }
                }
                catch (MySqlException ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void addAppointmentBtn_Click(object sender, EventArgs e)
        {
            AddAppointmentForm addForm = new AddAppointmentForm();
            addForm.Show();
            this.Close();
        }

        private void updateAppointmentBtn_Click(object sender, EventArgs e)
        {
            string appointmentId = appointmentsDGV.CurrentRow.Cells[0].Value.ToString();
            string customerId = appointmentsDGV.CurrentRow.Cells[1].Value.ToString();
            string userId = appointmentsDGV.CurrentRow.Cells[3].Value.ToString();
            string title = appointmentsDGV.CurrentRow.Cells[5].Value.ToString();
            string type = appointmentsDGV.CurrentRow.Cells[6].Value.ToString();
            string date = appointmentsDGV.CurrentRow.Cells[7].Value.ToString();
            string startTime = appointmentsDGV.CurrentRow.Cells[8].Value.ToString();
            string endTime = appointmentsDGV.CurrentRow.Cells[9].Value.ToString();

            if (appointmentsDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to update.");
            }
            else
            {
                UpdateAppointmentForm updateFrom = new UpdateAppointmentForm(appointmentId, customerId, userId, title, type, date, startTime, endTime);
                updateFrom.Show();
                this.Close();
            }
        }

        private void deleteAppointmentBtn_Click(object sender, EventArgs e)
        {
            if (appointmentsDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to from the table to delete.");
            }
            else
            {
                try
                {
                    int apptId = (int)appointmentsDGV.SelectedRows[0].Cells[0].Value;
                    string deleteAppointment = $"DELETE FROM appointment WHERE appointmentId = {apptId}";
                    DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this appointment?", "Delete Appointment?", MessageBoxButtons.YesNo);
                    if (confirmation == DialogResult.Yes)
                    {
                        cmd = new MySqlCommand(deleteAppointment, conn);
                        cmd.Prepare(); 
                        cmd.ExecuteNonQuery();
                        populateAppointmentTable();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void monthlyApptBtn_Click(object sender, EventArgs e)
        {
            MonthlyApptTypeForm monthlyApptForm = new MonthlyApptTypeForm();
            monthlyApptForm.Show();
        }
    }
}
