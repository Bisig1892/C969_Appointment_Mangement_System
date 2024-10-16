namespace C969_Appointment_Mangement_System
{
    partial class AddCustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.phoneNumberText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.countryText = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Country";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(111, 85);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(158, 20);
            this.nameText.TabIndex = 3;
            // 
            // phoneNumberText
            // 
            this.phoneNumberText.Location = new System.Drawing.Point(111, 189);
            this.phoneNumberText.Name = "phoneNumberText";
            this.phoneNumberText.Size = new System.Drawing.Size(158, 20);
            this.phoneNumberText.TabIndex = 11;
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(111, 111);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(158, 20);
            this.AddressText.TabIndex = 5;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(111, 137);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(158, 20);
            this.cityText.TabIndex = 7;
            // 
            // countryText
            // 
            this.countryText.Location = new System.Drawing.Point(111, 163);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(158, 20);
            this.countryText.TabIndex = 9;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(100, 231);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(86, 23);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add Customer";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(194, 231);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 14;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 312);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.countryText);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.phoneNumberText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox phoneNumberText;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox countryText;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}