﻿namespace C969_Appointment_Mangement_System.Reports
{
    partial class UserScheduleReportForm
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
            this.userApptDGV = new System.Windows.Forms.DataGridView();
            this.userIdCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userApptDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Schedule Report";
            // 
            // userApptDGV
            // 
            this.userApptDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userApptDGV.Location = new System.Drawing.Point(12, 80);
            this.userApptDGV.Name = "userApptDGV";
            this.userApptDGV.Size = new System.Drawing.Size(755, 348);
            this.userApptDGV.TabIndex = 1;
            // 
            // userIdCB
            // 
            this.userIdCB.FormattingEnabled = true;
            this.userIdCB.Location = new System.Drawing.Point(96, 53);
            this.userIdCB.Name = "userIdCB";
            this.userIdCB.Size = new System.Drawing.Size(121, 21);
            this.userIdCB.TabIndex = 2;
            this.userIdCB.SelectedIndexChanged += new System.EventHandler(this.userIdCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select User Id:";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(692, 434);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // UserScheduleReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 474);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userIdCB);
            this.Controls.Add(this.userApptDGV);
            this.Controls.Add(this.label1);
            this.Name = "UserScheduleReportForm";
            this.Text = "User Schedule Report";
            ((System.ComponentModel.ISupportInitialize)(this.userApptDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView userApptDGV;
        private System.Windows.Forms.ComboBox userIdCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeBtn;
    }
}