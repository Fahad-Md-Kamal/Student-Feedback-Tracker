namespace StudentFeedbackTracker
{
    partial class frmBase
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assessmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlbtn = new System.Windows.Forms.Panel();
            this.pnlService = new System.Windows.Forms.Panel();
            this.createCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(0, 27);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(1184, 39);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Student Feedback Tracker";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.subjectsToolStripMenuItem,
            this.assessmentsToolStripMenuItem,
            this.feedbackToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUsersToolStripMenuItem,
            this.modifyUsersToolStripMenuItem,
            this.blocUserToolStripMenuItem});
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addNewUsersToolStripMenuItem
            // 
            this.addNewUsersToolStripMenuItem.Name = "addNewUsersToolStripMenuItem";
            this.addNewUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewUsersToolStripMenuItem.Text = "Add new Users";
            this.addNewUsersToolStripMenuItem.Click += new System.EventHandler(this.addNewUsersToolStripMenuItem_Click);
            // 
            // modifyUsersToolStripMenuItem
            // 
            this.modifyUsersToolStripMenuItem.Name = "modifyUsersToolStripMenuItem";
            this.modifyUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyUsersToolStripMenuItem.Text = "Modify Users";
            // 
            // blocUserToolStripMenuItem
            // 
            this.blocUserToolStripMenuItem.Name = "blocUserToolStripMenuItem";
            this.blocUserToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.blocUserToolStripMenuItem.Text = "Create Role";
            this.blocUserToolStripMenuItem.Click += new System.EventHandler(this.blocUserToolStripMenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCourseToolStripMenuItem});
            this.coursesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.coursesToolStripMenuItem.Text = "Courses";
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.subjectsToolStripMenuItem.Text = "Subjects";
            // 
            // assessmentsToolStripMenuItem
            // 
            this.assessmentsToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assessmentsToolStripMenuItem.Name = "assessmentsToolStripMenuItem";
            this.assessmentsToolStripMenuItem.Size = new System.Drawing.Size(124, 23);
            this.assessmentsToolStripMenuItem.Text = "Assessments";
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            // 
            // pnlbtn
            // 
            this.pnlbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlbtn.Location = new System.Drawing.Point(0, 66);
            this.pnlbtn.Name = "pnlbtn";
            this.pnlbtn.Size = new System.Drawing.Size(242, 642);
            this.pnlbtn.TabIndex = 6;
            // 
            // pnlService
            // 
            this.pnlService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlService.Location = new System.Drawing.Point(242, 66);
            this.pnlService.Name = "pnlService";
            this.pnlService.Size = new System.Drawing.Size(942, 642);
            this.pnlService.TabIndex = 7;
            // 
            // createCourseToolStripMenuItem
            // 
            this.createCourseToolStripMenuItem.Name = "createCourseToolStripMenuItem";
            this.createCourseToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.createCourseToolStripMenuItem.Text = "Create Course";
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 708);
            this.Controls.Add(this.pnlService);
            this.Controls.Add(this.pnlbtn);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmBase";
            this.Text = "frmBase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assessmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocUserToolStripMenuItem;
        private System.Windows.Forms.Panel pnlbtn;
        private System.Windows.Forms.Panel pnlService;
        private System.Windows.Forms.ToolStripMenuItem createCourseToolStripMenuItem;
    }
}