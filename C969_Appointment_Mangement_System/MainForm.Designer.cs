namespace C969_Appointment_Mangement_System
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
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentsDGV
            // 
            this.appointmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDGV.Location = new System.Drawing.Point(12, 49);
            this.appointmentsDGV.Name = "appointmentsDGV";
            this.appointmentsDGV.Size = new System.Drawing.Size(829, 256);
            this.appointmentsDGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Appointments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(892, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customers";
            // 
            // customerDGV
            // 
            this.customerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDGV.Location = new System.Drawing.Point(896, 49);
            this.customerDGV.Name = "customerDGV";
            this.customerDGV.Size = new System.Drawing.Size(632, 256);
            this.customerDGV.TabIndex = 2;
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(1227, 311);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(94, 23);
            this.addCustomerBtn.TabIndex = 6;
            this.addCustomerBtn.Text = "Add Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // updateCustomerBtn
            // 
            this.updateCustomerBtn.Location = new System.Drawing.Point(1327, 311);
            this.updateCustomerBtn.Name = "updateCustomerBtn";
            this.updateCustomerBtn.Size = new System.Drawing.Size(99, 23);
            this.updateCustomerBtn.TabIndex = 7;
            this.updateCustomerBtn.Text = "Update Customer";
            this.updateCustomerBtn.UseVisualStyleBackColor = true;
            this.updateCustomerBtn.Click += new System.EventHandler(this.updateCustomerBtn_Click);
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Location = new System.Drawing.Point(1432, 311);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(96, 23);
            this.deleteCustomerBtn.TabIndex = 8;
            this.deleteCustomerBtn.Text = "Delete Customer";
            this.deleteCustomerBtn.UseVisualStyleBackColor = true;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // deleteAppointmentBtn
            // 
            this.deleteAppointmentBtn.Location = new System.Drawing.Point(729, 311);
            this.deleteAppointmentBtn.Name = "deleteAppointmentBtn";
            this.deleteAppointmentBtn.Size = new System.Drawing.Size(112, 23);
            this.deleteAppointmentBtn.TabIndex = 11;
            this.deleteAppointmentBtn.Text = "Delete Appointment";
            this.deleteAppointmentBtn.UseVisualStyleBackColor = true;
            this.deleteAppointmentBtn.Click += new System.EventHandler(this.deleteAppointmentBtn_Click);
            // 
            // updateAppointmentBtn
            // 
            this.updateAppointmentBtn.Location = new System.Drawing.Point(604, 311);
            this.updateAppointmentBtn.Name = "updateAppointmentBtn";
            this.updateAppointmentBtn.Size = new System.Drawing.Size(119, 23);
            this.updateAppointmentBtn.TabIndex = 10;
            this.updateAppointmentBtn.Text = "Update Appointment";
            this.updateAppointmentBtn.UseVisualStyleBackColor = true;
            this.updateAppointmentBtn.Click += new System.EventHandler(this.updateAppointmentBtn_Click);
            // 
            // addAppointmentBtn
            // 
            this.addAppointmentBtn.Location = new System.Drawing.Point(492, 311);
            this.addAppointmentBtn.Name = "addAppointmentBtn";
            this.addAppointmentBtn.Size = new System.Drawing.Size(106, 23);
            this.addAppointmentBtn.TabIndex = 9;
            this.addAppointmentBtn.Text = "Add Appointment";
            this.addAppointmentBtn.UseVisualStyleBackColor = true;
            this.addAppointmentBtn.Click += new System.EventHandler(this.addAppointmentBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 693);
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
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).EndInit();
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
    }
}