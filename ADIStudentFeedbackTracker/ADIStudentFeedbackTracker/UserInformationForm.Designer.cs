namespace ADIStudentFeedbackTracker
{
    partial class UserInformationForm
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
            this.gbxUserRegistration = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblConfPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblJoined = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxAdminSection = new System.Windows.Forms.GroupBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.lblEmailShow = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.gbxUserRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxAdminSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUserRegistration
            // 
            this.gbxUserRegistration.Controls.Add(this.lblImagePath);
            this.gbxUserRegistration.Controls.Add(this.btnUpload);
            this.gbxUserRegistration.Controls.Add(this.lblEmailShow);
            this.gbxUserRegistration.Controls.Add(this.gbxAdminSection);
            this.gbxUserRegistration.Controls.Add(this.pictureBox1);
            this.gbxUserRegistration.Controls.Add(this.dateTimePicker1);
            this.gbxUserRegistration.Controls.Add(this.txtPassword);
            this.gbxUserRegistration.Controls.Add(this.lblPassword);
            this.gbxUserRegistration.Controls.Add(this.lblEmail);
            this.gbxUserRegistration.Controls.Add(this.lblDoB);
            this.gbxUserRegistration.Controls.Add(this.txtLastName);
            this.gbxUserRegistration.Controls.Add(this.lblLastName);
            this.gbxUserRegistration.Controls.Add(this.txtFirstName);
            this.gbxUserRegistration.Controls.Add(this.lblFirstName);
            this.gbxUserRegistration.Controls.Add(this.txtUserName);
            this.gbxUserRegistration.Controls.Add(this.lblUserName);
            this.gbxUserRegistration.Location = new System.Drawing.Point(12, 12);
            this.gbxUserRegistration.Name = "gbxUserRegistration";
            this.gbxUserRegistration.Size = new System.Drawing.Size(668, 730);
            this.gbxUserRegistration.TabIndex = 2;
            this.gbxUserRegistration.TabStop = false;
            this.gbxUserRegistration.Text = "Registration Information";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MMMM yyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // lblConfPassword
            // 
            this.lblConfPassword.Location = new System.Drawing.Point(-3, 100);
            this.lblConfPassword.Name = "lblConfPassword";
            this.lblConfPassword.Size = new System.Drawing.Size(103, 20);
            this.lblConfPassword.TabIndex = 7;
            this.lblConfPassword.Text = "Joined On:";
            this.lblConfPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(148, 284);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(168, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(9, 284);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(103, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(9, 238);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(103, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDoB
            // 
            this.lblDoB.Location = new System.Drawing.Point(9, 192);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(103, 20);
            this.lblDoB.TabIndex = 7;
            this.lblDoB.Text = "Date Of Birth:";
            this.lblDoB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Location = new System.Drawing.Point(148, 145);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(168, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(9, 145);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(103, 20);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Location = new System.Drawing.Point(148, 97);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(168, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(9, 97);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(103, 20);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "FirstName:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(463, 171);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Update";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(148, 51);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(168, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(9, 51);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(103, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name:";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJoined
            // 
            this.lblJoined.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJoined.Location = new System.Drawing.Point(136, 100);
            this.lblJoined.Name = "lblJoined";
            this.lblJoined.Size = new System.Drawing.Size(168, 20);
            this.lblJoined.TabIndex = 10;
            this.lblJoined.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(396, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 182);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // gbxAdminSection
            // 
            this.gbxAdminSection.Controls.Add(this.cmbUserRole);
            this.gbxAdminSection.Controls.Add(this.lblUserRole);
            this.gbxAdminSection.Controls.Add(this.btnSubmit);
            this.gbxAdminSection.Controls.Add(this.lblJoined);
            this.gbxAdminSection.Controls.Add(this.lblConfPassword);
            this.gbxAdminSection.Location = new System.Drawing.Point(12, 454);
            this.gbxAdminSection.Name = "gbxAdminSection";
            this.gbxAdminSection.Size = new System.Drawing.Size(569, 205);
            this.gbxAdminSection.TabIndex = 12;
            this.gbxAdminSection.TabStop = false;
            this.gbxAdminSection.Text = "Admin Section";
            // 
            // lblUserRole
            // 
            this.lblUserRole.Location = new System.Drawing.Point(6, 46);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(103, 20);
            this.lblUserRole.TabIndex = 13;
            this.lblUserRole.Text = "User Name:";
            this.lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Location = new System.Drawing.Point(136, 47);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(168, 21);
            this.cmbUserRole.TabIndex = 14;
            // 
            // lblEmailShow
            // 
            this.lblEmailShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmailShow.Location = new System.Drawing.Point(148, 238);
            this.lblEmailShow.Name = "lblEmailShow";
            this.lblEmailShow.Size = new System.Drawing.Size(168, 20);
            this.lblEmailShow.TabIndex = 13;
            this.lblEmailShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(396, 295);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(185, 36);
            this.btnUpload.TabIndex = 15;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // lblImagePath
            // 
            this.lblImagePath.BackColor = System.Drawing.SystemColors.Control;
            this.lblImagePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImagePath.Location = new System.Drawing.Point(396, 272);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(185, 20);
            this.lblImagePath.TabIndex = 16;
            this.lblImagePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 754);
            this.Controls.Add(this.gbxUserRegistration);
            this.Name = "UserInformationForm";
            this.Text = "UserInformationForm";
            this.gbxUserRegistration.ResumeLayout(false);
            this.gbxUserRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxAdminSection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUserRegistration;
        private System.Windows.Forms.Label lblJoined;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblConfPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox gbxAdminSection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblEmailShow;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblImagePath;
    }
}