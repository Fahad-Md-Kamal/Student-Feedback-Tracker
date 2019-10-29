namespace StudentFeedbackTracker_00171328
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gv = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCName = new System.Windows.Forms.Label();
            this.GvStudentList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gv);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblCName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 545);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Information";
            // 
            // gv
            // 
            this.gv.BackgroundColor = System.Drawing.Color.White;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv.Location = new System.Drawing.Point(3, 174);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(409, 368);
            this.gv.TabIndex = 2;
            this.gv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(65, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(161, 130);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsert.Location = new System.Drawing.Point(259, 130);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(193, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.Location = new System.Drawing.Point(88, 60);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(80, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID : ";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(193, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblCName
            // 
            this.lblCName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCName.Location = new System.Drawing.Point(88, 86);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(80, 13);
            this.lblCName.TabIndex = 0;
            this.lblCName.Text = "Course Name : ";
            this.lblCName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GvStudentList
            // 
            this.GvStudentList.BackgroundColor = System.Drawing.Color.White;
            this.GvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvStudentList.Location = new System.Drawing.Point(415, 0);
            this.GvStudentList.Name = "GvStudentList";
            this.GvStudentList.Size = new System.Drawing.Size(600, 545);
            this.GvStudentList.TabIndex = 3;
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 545);
            this.Controls.Add(this.GvStudentList);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCourse";
            this.Text = "frmCourse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.DataGridView GvStudentList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}