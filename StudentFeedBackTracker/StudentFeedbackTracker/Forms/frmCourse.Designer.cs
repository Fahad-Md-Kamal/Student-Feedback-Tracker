namespace StudentFeedbackTracker.Forms
{
    partial class frmCourse
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
            this.lblId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.gxfrm = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.gxList = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.RoleType = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lstSubjects = new System.Windows.Forms.ListBox();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gbxStudents = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxSubjects = new System.Windows.Forms.GroupBox();
            this.gxfrm.SuspendLayout();
            this.gxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbxStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxSubjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.Location = new System.Drawing.Point(43, 76);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(122, 23);
            this.lblId.TabIndex = 1002;
            this.lblId.Text = "Id:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(78, 568);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 38);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(208, 568);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 38);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.Location = new System.Drawing.Point(43, 129);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(122, 23);
            this.lblFirstName.TabIndex = 1001;
            this.lblFirstName.Text = "Course Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(327, 568);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 38);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Register";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(208, 76);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(206, 26);
            this.txtId.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.Location = new System.Drawing.Point(43, 180);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(122, 23);
            this.lblLastName.TabIndex = 1004;
            this.lblLastName.Text = "Total Credit:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(208, 180);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(206, 26);
            this.txtLastName.TabIndex = 2;
            // 
            // gxfrm
            // 
            this.gxfrm.Controls.Add(this.lstStudents);
            this.gxfrm.Controls.Add(this.lstSubjects);
            this.gxfrm.Controls.Add(this.lblStudent);
            this.gxfrm.Controls.Add(this.lblId);
            this.gxfrm.Controls.Add(this.RoleType);
            this.gxfrm.Controls.Add(this.btnDelete);
            this.gxfrm.Controls.Add(this.btnUpdate);
            this.gxfrm.Controls.Add(this.lblFirstName);
            this.gxfrm.Controls.Add(this.btnAddStudent);
            this.gxfrm.Controls.Add(this.btnAdd);
            this.gxfrm.Controls.Add(this.btnSubmit);
            this.gxfrm.Controls.Add(this.txtFirstName);
            this.gxfrm.Controls.Add(this.txtId);
            this.gxfrm.Controls.Add(this.lblLastName);
            this.gxfrm.Controls.Add(this.txtLastName);
            this.gxfrm.Dock = System.Windows.Forms.DockStyle.Left;
            this.gxfrm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gxfrm.Location = new System.Drawing.Point(0, 0);
            this.gxfrm.Name = "gxfrm";
            this.gxfrm.Size = new System.Drawing.Size(533, 668);
            this.gxfrm.TabIndex = 1001;
            this.gxfrm.TabStop = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(208, 129);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(206, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // gxList
            // 
            this.gxList.Controls.Add(this.dgv);
            this.gxList.Controls.Add(this.btnsearch);
            this.gxList.Controls.Add(this.txtSearch);
            this.gxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gxList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gxList.Location = new System.Drawing.Point(533, 0);
            this.gxList.Name = "gxList";
            this.gxList.Size = new System.Drawing.Size(270, 668);
            this.gxList.TabIndex = 1006;
            this.gxList.TabStop = false;
            this.gxList.Text = "Course Info";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 83);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(264, 582);
            this.dgv.TabIndex = 2;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.DarkGreen;
            this.btnsearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsearch.Location = new System.Drawing.Point(3, 48);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(264, 35);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(3, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(264, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(433, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 31);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+ Subject";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStudent.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddStudent.Location = new System.Drawing.Point(433, 391);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(80, 31);
            this.btnAddStudent.TabIndex = 9;
            this.btnAddStudent.Text = "+ Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            // 
            // RoleType
            // 
            this.RoleType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoleType.Location = new System.Drawing.Point(43, 241);
            this.RoleType.Name = "RoleType";
            this.RoleType.Size = new System.Drawing.Size(123, 23);
            this.RoleType.TabIndex = 1016;
            this.RoleType.Text = "Subjects :";
            this.RoleType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStudent
            // 
            this.lblStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudent.Location = new System.Drawing.Point(43, 391);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(123, 23);
            this.lblStudent.TabIndex = 1016;
            this.lblStudent.Text = "Students:";
            this.lblStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstSubjects
            // 
            this.lstSubjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstSubjects.FormattingEnabled = true;
            this.lstSubjects.ItemHeight = 19;
            this.lstSubjects.Location = new System.Drawing.Point(208, 241);
            this.lstSubjects.Name = "lstSubjects";
            this.lstSubjects.Size = new System.Drawing.Size(206, 118);
            this.lstSubjects.TabIndex = 1017;
            // 
            // lstStudents
            // 
            this.lstStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 19;
            this.lstStudents.Location = new System.Drawing.Point(208, 391);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(206, 118);
            this.lstStudents.TabIndex = 1017;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Location = new System.Drawing.Point(3, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 26);
            this.textBox2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(3, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 83);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(281, 582);
            this.dataGridView2.TabIndex = 2;
            // 
            // gbxStudents
            // 
            this.gbxStudents.Controls.Add(this.dataGridView2);
            this.gbxStudents.Controls.Add(this.button2);
            this.gbxStudents.Controls.Add(this.textBox2);
            this.gbxStudents.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbxStudents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxStudents.Location = new System.Drawing.Point(1079, 0);
            this.gbxStudents.Name = "gbxStudents";
            this.gbxStudents.Size = new System.Drawing.Size(287, 668);
            this.gbxStudents.TabIndex = 1004;
            this.gbxStudents.TabStop = false;
            this.gbxStudents.Text = "Students";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 26);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(3, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(270, 582);
            this.dataGridView1.TabIndex = 2;
            // 
            // gbxSubjects
            // 
            this.gbxSubjects.Controls.Add(this.dataGridView1);
            this.gbxSubjects.Controls.Add(this.button1);
            this.gbxSubjects.Controls.Add(this.textBox1);
            this.gbxSubjects.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbxSubjects.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSubjects.Location = new System.Drawing.Point(803, 0);
            this.gbxSubjects.Name = "gbxSubjects";
            this.gbxSubjects.Size = new System.Drawing.Size(276, 668);
            this.gbxSubjects.TabIndex = 1005;
            this.gbxSubjects.TabStop = false;
            this.gbxSubjects.Text = "Subjects";
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 668);
            this.Controls.Add(this.gxList);
            this.Controls.Add(this.gbxSubjects);
            this.Controls.Add(this.gbxStudents);
            this.Controls.Add(this.gxfrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCourse";
            this.Text = "frmCourse";
            this.gxfrm.ResumeLayout(false);
            this.gxfrm.PerformLayout();
            this.gxList.ResumeLayout(false);
            this.gxList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbxStudents.ResumeLayout(false);
            this.gbxStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxSubjects.ResumeLayout(false);
            this.gbxSubjects.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox gxfrm;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox gxList;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.ListBox lstSubjects;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label RoleType;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox gbxStudents;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbxSubjects;
    }
}