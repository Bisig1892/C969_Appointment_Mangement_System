namespace C969_Appointment_Mangement_System
{
    partial class AddAppointmentForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.typeText = new System.Windows.Forms.TextBox();
            this.userIdCB = new System.Windows.Forms.ComboBox();
            this.CustomerIdCB = new System.Windows.Forms.ComboBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.dateDTP = new System.Windows.Forms.DateTimePicker();
            this.startDTP = new System.Windows.Forms.DateTimePicker();
            this.endDTP = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.addAppointmentBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "End";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Title";
            // 
            // typeText
            // 
            this.typeText.Location = new System.Drawing.Point(83, 212);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(199, 20);
            this.typeText.TabIndex = 9;
            // 
            // userIdCB
            // 
            this.userIdCB.FormattingEnabled = true;
            this.userIdCB.Location = new System.Drawing.Point(83, 87);
            this.userIdCB.Name = "userIdCB";
            this.userIdCB.Size = new System.Drawing.Size(96, 21);
            this.userIdCB.TabIndex = 3;
            // 
            // CustomerIdCB
            // 
            this.CustomerIdCB.FormattingEnabled = true;
            this.CustomerIdCB.Location = new System.Drawing.Point(83, 134);
            this.CustomerIdCB.Name = "CustomerIdCB";
            this.CustomerIdCB.Size = new System.Drawing.Size(96, 21);
            this.CustomerIdCB.TabIndex = 5;
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(83, 171);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(199, 20);
            this.titleText.TabIndex = 7;
            // 
            // dateDTP
            // 
            this.dateDTP.CustomFormat = "MM-dd-yyyy";
            this.dateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDTP.Location = new System.Drawing.Point(327, 131);
            this.dateDTP.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(200, 20);
            this.dateDTP.TabIndex = 11;
            // 
            // startDTP
            // 
            this.startDTP.CustomFormat = "";
            this.startDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startDTP.Location = new System.Drawing.Point(327, 171);
            this.startDTP.Name = "startDTP";
            this.startDTP.ShowUpDown = true;
            this.startDTP.Size = new System.Drawing.Size(199, 20);
            this.startDTP.TabIndex = 13;
            // 
            // endDTP
            // 
            this.endDTP.CustomFormat = "HH:mm";
            this.endDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endDTP.Location = new System.Drawing.Point(327, 210);
            this.endDTP.Name = "endDTP";
            this.endDTP.ShowUpDown = true;
            this.endDTP.Size = new System.Drawing.Size(200, 20);
            this.endDTP.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Add Appointment";
            // 
            // addAppointmentBtn
            // 
            this.addAppointmentBtn.Location = new System.Drawing.Point(334, 269);
            this.addAppointmentBtn.Name = "addAppointmentBtn";
            this.addAppointmentBtn.Size = new System.Drawing.Size(105, 23);
            this.addAppointmentBtn.TabIndex = 16;
            this.addAppointmentBtn.Text = "Add Appointment";
            this.addAppointmentBtn.UseVisualStyleBackColor = true;
            this.addAppointmentBtn.Click += new System.EventHandler(this.addAppointmentBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(451, 269);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 17;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 356);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addAppointmentBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.endDTP);
            this.Controls.Add(this.startDTP);
            this.Controls.Add(this.dateDTP);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.CustomerIdCB);
            this.Controls.Add(this.userIdCB);
            this.Controls.Add(this.typeText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAppointmentForm";
            this.Text = "Add Appointment";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox typeText;
        private System.Windows.Forms.ComboBox userIdCB;
        private System.Windows.Forms.ComboBox CustomerIdCB;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.DateTimePicker dateDTP;
        private System.Windows.Forms.DateTimePicker startDTP;
        private System.Windows.Forms.DateTimePicker endDTP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addAppointmentBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}