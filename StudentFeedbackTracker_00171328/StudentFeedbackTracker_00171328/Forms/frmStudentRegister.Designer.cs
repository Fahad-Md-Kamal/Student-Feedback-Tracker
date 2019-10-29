namespace StudentFeedbackTracker_00171328
{
    partial class frmStudentRegister
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.lblRoll = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDoB = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.pnlUser);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.lblCourse);
            this.groupBox1.Controls.Add(this.cboCourse);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.dtDOB);
            this.groupBox1.Controls.Add(this.lblDoB);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 725);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(291, 493);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "+ Course";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.Silver;
            this.pnlUser.Controls.Add(this.txtPass);
            this.pnlUser.Controls.Add(this.lblPass);
            this.pnlUser.Controls.Add(this.lblUserName);
            this.pnlUser.Controls.Add(this.txtUName);
            this.pnlUser.Controls.Add(this.txtRoll);
            this.pnlUser.Controls.Add(this.lblRoll);
            this.pnlUser.Location = new System.Drawing.Point(28, 37);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(331, 109);
            this.pnlUser.TabIndex = 21;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(119, 45);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(193, 20);
            this.txtPass.TabIndex = 22;
            // 
            // lblPass
            // 
            this.lblPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPass.Location = new System.Drawing.Point(12, 42);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(100, 23);
            this.lblPass.TabIndex = 21;
            this.lblPass.Text = "Password : ";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserName
            // 
            this.lblUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserName.Location = new System.Drawing.Point(12, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(100, 23);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "User Name : ";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(119, 16);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(194, 20);
            this.txtUName.TabIndex = 19;
            // 
            // txtRoll
            // 
            this.txtRoll.Location = new System.Drawing.Point(119, 74);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(193, 20);
            this.txtRoll.TabIndex = 18;
            // 
            // lblRoll
            // 
            this.lblRoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoll.Location = new System.Drawing.Point(12, 71);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(100, 23);
            this.lblRoll.TabIndex = 17;
            this.lblRoll.Text = "Roll Number : ";
            this.lblRoll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(28, 545);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(157, 545);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(290, 545);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(71, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse.Location = new System.Drawing.Point(28, 495);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(100, 23);
            this.lblCourse.TabIndex = 20;
            this.lblCourse.Text = "Course : ";
            this.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCourse
            // 
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(135, 495);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(121, 21);
            this.cboCourse.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmail.Location = new System.Drawing.Point(28, 433);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email Address : ";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(136, 436);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // dtDOB
            // 
            this.dtDOB.CustomFormat = "yyyy/MM/dd";
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOB.Location = new System.Drawing.Point(135, 403);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(100, 20);
            this.dtDOB.TabIndex = 10;
            // 
            // lblDoB
            // 
            this.lblDoB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDoB.Location = new System.Drawing.Point(28, 403);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(100, 23);
            this.lblDoB.TabIndex = 6;
            this.lblDoB.Text = "Date of Birth : ";
            this.lblDoB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(135, 296);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(224, 92);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddress.Location = new System.Drawing.Point(28, 294);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address : ";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(135, 224);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(224, 20);
            this.txtId.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.Location = new System.Drawing.Point(28, 222);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 23);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id : ";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 263);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Location = new System.Drawing.Point(28, 261);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name : ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gv
            // 
            this.gv.BackgroundColor = System.Drawing.Color.White;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv.Location = new System.Drawing.Point(413, 0);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(473, 725);
            this.gv.TabIndex = 11;
            this.gv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellClick);
            // 
            // frmStudentRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 725);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStudentRegister";
            this.Text = "frmStudentRegister";
            this.Load += new System.EventHandler(this.frmStudentRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}