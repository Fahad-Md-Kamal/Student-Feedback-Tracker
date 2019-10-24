namespace ADIDemoDec19
{
    partial class frmAssessment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtADate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAss = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.dtADate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboAss);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboGrade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboUser);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboCourse);
            this.groupBox1.Controls.Add(this.txtMark);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 293);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assessment Information";
            // 
            // dtADate
            // 
            this.dtADate.Location = new System.Drawing.Point(134, 163);
            this.dtADate.Name = "dtADate";
            this.dtADate.Size = new System.Drawing.Size(121, 20);
            this.dtADate.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(27, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Assessment Date : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(27, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Assessment Type : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboAss
            // 
            this.cboAss.FormattingEnabled = true;
            this.cboAss.Location = new System.Drawing.Point(134, 126);
            this.cboAss.Name = "cboAss";
            this.cboAss.Size = new System.Drawing.Size(121, 21);
            this.cboAss.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(27, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Grade : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboGrade
            // 
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(134, 94);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(121, 21);
            this.cboGrade.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "User : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboUser
            // 
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(134, 60);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(121, 21);
            this.cboUser.TabIndex = 22;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(27, 237);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(27, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Course : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCourse
            // 
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(134, 27);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(121, 21);
            this.cboCourse.TabIndex = 19;
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(134, 195);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(121, 20);
            this.txtMark.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(27, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mark : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 337);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAssessment";
            this.Text = "frmAssessment";
            this.Load += new System.EventHandler(this.frmAssessment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtADate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAss;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label label1;
    }
}