﻿namespace C969_Appointment_Mangement_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.appointmentsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerDGV = new System.Windows.Forms.DataGridView();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.updateCustomerBtn = new System.Windows.Forms.Button();
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.deleteAppointmentBtn = new System.Windows.Forms.Button();
            this.updateAppointmentBtn = new System.Windows.Forms.Button();
            this.addAppointmentBtn = new System.Windows.Forms.Button();
            this.dayScheduleDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.monthlyApptBtn = new System.Windows.Forms.Button();
            this.custApptCount = new System.Windows.Forms.Button();
            this.userScheduleBtn = new System.Windows.Forms.Button();
            this.dayScheduleDTP = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.daySchedSubmitBtn = new System.Windows.Forms.Button();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.clearSearchResultsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayScheduleDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentsDGV
            // 
            this.appointmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDGV.Location = new System.Drawing.Point(12, 65);
            this.appointmentsDGV.Name = "appointmentsDGV";
            this.appointmentsDGV.Size = new System.Drawing.Size(829, 256);
            this.appointmentsDGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Appointments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(892, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customers";
            // 
            // customerDGV
            // 
            this.customerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDGV.Location = new System.Drawing.Point(896, 65);
            this.customerDGV.Name = "customerDGV";
            this.customerDGV.Size = new System.Drawing.Size(632, 256);
            this.customerDGV.TabIndex = 2;
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(1227, 327);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(94, 23);
            this.addCustomerBtn.TabIndex = 6;
            this.addCustomerBtn.Text = "Add Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // updateCustomerBtn
            // 
            this.updateCustomerBtn.Location = new System.Drawing.Point(1327, 327);
            this.updateCustomerBtn.Name = "updateCustomerBtn";
            this.updateCustomerBtn.Size = new System.Drawing.Size(99, 23);
            this.updateCustomerBtn.TabIndex = 7;
            this.updateCustomerBtn.Text = "Update Customer";
            this.updateCustomerBtn.UseVisualStyleBackColor = true;
            this.updateCustomerBtn.Click += new System.EventHandler(this.updateCustomerBtn_Click);
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Location = new System.Drawing.Point(1432, 327);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(96, 23);
            this.deleteCustomerBtn.TabIndex = 8;
            this.deleteCustomerBtn.Text = "Delete Customer";
            this.deleteCustomerBtn.UseVisualStyleBackColor = true;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // deleteAppointmentBtn
            // 
            this.deleteAppointmentBtn.Location = new System.Drawing.Point(729, 327);
            this.deleteAppointmentBtn.Name = "deleteAppointmentBtn";
            this.deleteAppointmentBtn.Size = new System.Drawing.Size(112, 23);
            this.deleteAppointmentBtn.TabIndex = 11;
            this.deleteAppointmentBtn.Text = "Delete Appointment";
            this.deleteAppointmentBtn.UseVisualStyleBackColor = true;
            this.deleteAppointmentBtn.Click += new System.EventHandler(this.deleteAppointmentBtn_Click);
            // 
            // updateAppointmentBtn
            // 
            this.updateAppointmentBtn.Location = new System.Drawing.Point(604, 327);
            this.updateAppointmentBtn.Name = "updateAppointmentBtn";
            this.updateAppointmentBtn.Size = new System.Drawing.Size(119, 23);
            this.updateAppointmentBtn.TabIndex = 10;
            this.updateAppointmentBtn.Text = "Update Appointment";
            this.updateAppointmentBtn.UseVisualStyleBackColor = true;
            this.updateAppointmentBtn.Click += new System.EventHandler(this.updateAppointmentBtn_Click);
            // 
            // addAppointmentBtn
            // 
            this.addAppointmentBtn.Location = new System.Drawing.Point(492, 327);
            this.addAppointmentBtn.Name = "addAppointmentBtn";
            this.addAppointmentBtn.Size = new System.Drawing.Size(106, 23);
            this.addAppointmentBtn.TabIndex = 9;
            this.addAppointmentBtn.Text = "Add Appointment";
            this.addAppointmentBtn.UseVisualStyleBackColor = true;
            this.addAppointmentBtn.Click += new System.EventHandler(this.addAppointmentBtn_Click);
            // 
            // dayScheduleDGV
            // 
            this.dayScheduleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayScheduleDGV.Location = new System.Drawing.Point(12, 425);
            this.dayScheduleDGV.Name = "dayScheduleDGV";
            this.dayScheduleDGV.Size = new System.Drawing.Size(829, 287);
            this.dayScheduleDGV.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Appointment Calendar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1084, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Reports";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1085, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Monthly Appointment Types";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1070, 618);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Customer Appointment Counts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1174, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "User Schedule";
            // 
            // monthlyApptBtn
            // 
            this.monthlyApptBtn.Location = new System.Drawing.Point(1296, 493);
            this.monthlyApptBtn.Name = "monthlyApptBtn";
            this.monthlyApptBtn.Size = new System.Drawing.Size(75, 23);
            this.monthlyApptBtn.TabIndex = 20;
            this.monthlyApptBtn.Text = "Generate";
            this.monthlyApptBtn.UseVisualStyleBackColor = true;
            this.monthlyApptBtn.Click += new System.EventHandler(this.monthlyApptBtn_Click);
            // 
            // custApptCount
            // 
            this.custApptCount.Location = new System.Drawing.Point(1296, 615);
            this.custApptCount.Name = "custApptCount";
            this.custApptCount.Size = new System.Drawing.Size(75, 23);
            this.custApptCount.TabIndex = 21;
            this.custApptCount.Text = "Generate";
            this.custApptCount.UseVisualStyleBackColor = true;
            this.custApptCount.Click += new System.EventHandler(this.custApptCount_Click);
            // 
            // userScheduleBtn
            // 
            this.userScheduleBtn.Location = new System.Drawing.Point(1296, 553);
            this.userScheduleBtn.Name = "userScheduleBtn";
            this.userScheduleBtn.Size = new System.Drawing.Size(75, 23);
            this.userScheduleBtn.TabIndex = 22;
            this.userScheduleBtn.Text = "Generate";
            this.userScheduleBtn.UseVisualStyleBackColor = true;
            this.userScheduleBtn.Click += new System.EventHandler(this.userScheduleBtn_Click);
            // 
            // dayScheduleDTP
            // 
            this.dayScheduleDTP.CustomFormat = "MM-dd-yyy";
            this.dayScheduleDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dayScheduleDTP.Location = new System.Drawing.Point(95, 399);
            this.dayScheduleDTP.Name = "dayScheduleDTP";
            this.dayScheduleDTP.Size = new System.Drawing.Size(105, 20);
            this.dayScheduleDTP.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Day Schedule:";
            // 
            // daySchedSubmitBtn
            // 
            this.daySchedSubmitBtn.Location = new System.Drawing.Point(219, 396);
            this.daySchedSubmitBtn.Name = "daySchedSubmitBtn";
            this.daySchedSubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.daySchedSubmitBtn.TabIndex = 25;
            this.daySchedSubmitBtn.Text = "Submit";
            this.daySchedSubmitBtn.UseVisualStyleBackColor = true;
            this.daySchedSubmitBtn.Click += new System.EventHandler(this.daySchedSubmitBtn_Click);
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(1204, 37);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(159, 20);
            this.searchTb.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1107, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Customer Name:";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(1369, 36);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 29;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // clearSearchResultsBtn
            // 
            this.clearSearchResultsBtn.Location = new System.Drawing.Point(1450, 37);
            this.clearSearchResultsBtn.Name = "clearSearchResultsBtn";
            this.clearSearchResultsBtn.Size = new System.Drawing.Size(75, 23);
            this.clearSearchResultsBtn.TabIndex = 30;
            this.clearSearchResultsBtn.Text = "Clear";
            this.clearSearchResultsBtn.UseVisualStyleBackColor = true;
            this.clearSearchResultsBtn.Click += new System.EventHandler(this.clearSearchResultsBtn_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.searchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 785);
            this.Controls.Add(this.clearSearchResultsBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.daySchedSubmitBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dayScheduleDTP);
            this.Controls.Add(this.userScheduleBtn);
            this.Controls.Add(this.custApptCount);
            this.Controls.Add(this.monthlyApptBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dayScheduleDGV);
            this.Controls.Add(this.deleteAppointmentBtn);
            this.Controls.Add(this.updateAppointmentBtn);
            this.Controls.Add(this.addAppointmentBtn);
            this.Controls.Add(this.deleteCustomerBtn);
            this.Controls.Add(this.updateCustomerBtn);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerDGV);
            this.Controls.Add(this.appointmentsDGV);
            this.Name = "MainForm";
            this.Text = " Main";
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayScheduleDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentsDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView customerDGV;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Button updateCustomerBtn;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.Button deleteAppointmentBtn;
        private System.Windows.Forms.Button updateAppointmentBtn;
        private System.Windows.Forms.Button addAppointmentBtn;
        private System.Windows.Forms.DataGridView dayScheduleDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button monthlyApptBtn;
        private System.Windows.Forms.Button custApptCount;
        private System.Windows.Forms.Button userScheduleBtn;
        private System.Windows.Forms.DateTimePicker dayScheduleDTP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button daySchedSubmitBtn;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button clearSearchResultsBtn;
    }
}