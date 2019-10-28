namespace StudentFeedbackTracker_00171328
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtADate = new System.Windows.Forms.DateTimePicker();
            this.lblAssessmentDate = new System.Windows.Forms.Label();
            this.lblAssType = new System.Windows.Forms.Label();
            this.cboAss = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.lblMark = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gv = new System.Windows.Forms.DataGridView();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnGrade = new System.Windows.Forms.Button();
            this.btnAssType = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btnAssType);
            this.groupBox1.Controls.Add(this.btnGrade);
            this.groupBox1.Controls.Add(this.btnCourse);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.dtADate);
            this.groupBox1.Controls.Add(this.lblAssessmentDate);
            this.groupBox1.Controls.Add(this.lblAssType);
            this.groupBox1.Controls.Add(this.cboAss);
            this.groupBox1.Controls.Add(this.lblGrade);
            this.groupBox1.Controls.Add(this.cboGrade);
            this.groupBox1.Controls.Add(this.lblStaff);
            this.groupBox1.Controls.Add(this.cboUser);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.lblCourse);
            this.groupBox1.Controls.Add(this.cboCourse);
            this.groupBox1.Controls.Add(this.txtMark);
            this.groupBox1.Controls.Add(this.lblMark);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 429);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assessment Information";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTitle.Location = new System.Drawing.Point(232, 69);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(121, 20);
            this.txtTitle.TabIndex = 32;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Location = new System.Drawing.Point(100, 69);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 23);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Title : ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtADate
            // 
            this.dtADate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtADate.Location = new System.Drawing.Point(232, 290);
            this.dtADate.Name = "dtADate";
            this.dtADate.Size = new System.Drawing.Size(121, 20);
            this.dtADate.TabIndex = 30;
            // 
            // lblAssessmentDate
            // 
            this.lblAssessmentDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAssessmentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAssessmentDate.Location = new System.Drawing.Point(100, 288);
            this.lblAssessmentDate.Name = "lblAssessmentDate";
            this.lblAssessmentDate.Size = new System.Drawing.Size(100, 23);
            this.lblAssessmentDate.TabIndex = 29;
            this.lblAssessmentDate.Text = "Assessment Date : ";
            this.lblAssessmentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAssType
            // 
            this.lblAssType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAssType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAssType.Location = new System.Drawing.Point(100, 244);
            this.lblAssType.Name = "lblAssType";
            this.lblAssType.Size = new System.Drawing.Size(100, 23);
            this.lblAssType.TabIndex = 27;
            this.lblAssType.Text = "Assessment Type : ";
            this.lblAssType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboAss
            // 
            this.cboAss.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboAss.FormattingEnabled = true;
            this.cboAss.Location = new System.Drawing.Point(232, 246);
            this.cboAss.Name = "cboAss";
            this.cboAss.Size = new System.Drawing.Size(121, 21);
            this.cboAss.TabIndex = 26;
            // 
            // lblGrade
            // 
            this.lblGrade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrade.Location = new System.Drawing.Point(100, 200);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(100, 23);
            this.lblGrade.TabIndex = 25;
            this.lblGrade.Text = "Grade : ";
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboGrade
            // 
            this.cboGrade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(232, 202);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(121, 21);
            this.cboGrade.TabIndex = 24;
            // 
            // lblStaff
            // 
            this.lblStaff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStaff.Location = new System.Drawing.Point(100, 113);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(100, 23);
            this.lblStaff.TabIndex = 23;
            this.lblStaff.Text = "Staff : ";
            this.lblStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboUser
            // 
            this.cboUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(232, 115);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(121, 21);
            this.cboUser.TabIndex = 22;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSubmit.Location = new System.Drawing.Point(290, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(63, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse.Location = new System.Drawing.Point(100, 157);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(100, 23);
            this.lblCourse.TabIndex = 20;
            this.lblCourse.Text = "Course : ";
            this.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCourse
            // 
            this.cboCourse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(232, 159);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(121, 21);
            this.cboCourse.TabIndex = 19;
            // 
            // txtMark
            // 
            this.txtMark.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMark.Location = new System.Drawing.Point(232, 333);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(121, 20);
            this.txtMark.TabIndex = 18;
            // 
            // lblMark
            // 
            this.lblMark.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMark.Location = new System.Drawing.Point(100, 331);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(100, 23);
            this.lblMark.TabIndex = 17;
            this.lblMark.Text = "Mark : ";
            this.lblMark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.Location = new System.Drawing.Point(191, 383);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(63, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Location = new System.Drawing.Point(100, 383);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gv
            // 
            this.gv.BackgroundColor = System.Drawing.Color.White;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv.Location = new System.Drawing.Point(477, 0);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(317, 429);
            this.gv.TabIndex = 4;
            this.gv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellClick);
            // 
            // btnCourse
            // 
            this.btnCourse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.Color.White;
            this.btnCourse.Location = new System.Drawing.Point(369, 157);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(63, 23);
            this.btnCourse.TabIndex = 33;
            this.btnCourse.Text = "+ Add";
            this.btnCourse.UseVisualStyleBackColor = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrade.ForeColor = System.Drawing.Color.White;
            this.btnGrade.Location = new System.Drawing.Point(369, 200);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(63, 23);
            this.btnGrade.TabIndex = 33;
            this.btnGrade.Text = "+ Add";
            this.btnGrade.UseVisualStyleBackColor = false;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnAssType
            // 
            this.btnAssType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAssType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAssType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssType.ForeColor = System.Drawing.Color.White;
            this.btnAssType.Location = new System.Drawing.Point(369, 244);
            this.btnAssType.Name = "btnAssType";
            this.btnAssType.Size = new System.Drawing.Size(63, 23);
            this.btnAssType.TabIndex = 33;
            this.btnAssType.Text = "+ Add";
            this.btnAssType.UseVisualStyleBackColor = false;
            this.btnAssType.Click += new System.EventHandler(this.btnAssType_Click);
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.Location = new System.Drawing.Point(100, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 23);
            this.lblId.TabIndex = 31;
            this.lblId.Text = "ID : ";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtID.Location = new System.Drawing.Point(232, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 32;
            // 
            // frmAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 429);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAssessment";
            this.Text = "frmAssessment";
            this.Load += new System.EventHandler(this.frmAssessment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtADate;
        private System.Windows.Forms.Label lblAssessmentDate;
        private System.Windows.Forms.Label lblAssType;
        private System.Windows.Forms.ComboBox cboAss;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAssType;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
    }
}