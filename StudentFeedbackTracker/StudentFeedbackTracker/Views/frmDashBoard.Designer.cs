namespace StudentFeedbackTracker.Views
{
    partial class frmDashBoard
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.lblAppHeader = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.creationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assessmetnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assessmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbacksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordCloudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.assessmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assessmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.examinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.suggestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordCloudToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managerUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assingCourseStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignCourseTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignSubjectStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignSubjectTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlServer = new System.Windows.Forms.Panel();
            this.pnlNav.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(189, 612);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.Controls.Add(this.lblAppHeader);
            this.pnlNav.Controls.Add(this.menuStrip1);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(189, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(543, 94);
            this.pnlNav.TabIndex = 1;
            // 
            // lblAppHeader
            // 
            this.lblAppHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(128)))), ((int)(((byte)(108)))));
            this.lblAppHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAppHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppHeader.ForeColor = System.Drawing.Color.White;
            this.lblAppHeader.Location = new System.Drawing.Point(0, 24);
            this.lblAppHeader.Name = "lblAppHeader";
            this.lblAppHeader.Size = new System.Drawing.Size(543, 70);
            this.lblAppHeader.TabIndex = 1;
            this.lblAppHeader.Text = "Student Feedback Tracker";
            this.lblAppHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(128)))), ((int)(((byte)(108)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creationsToolStripMenuItem,
            this.listsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.managerUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creationsToolStripMenuItem
            // 
            this.creationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courserToolStripMenuItem,
            this.subjectToolStripMenuItem,
            this.assessmetnToolStripMenuItem,
            this.feedbackToolStripMenuItem});
            this.creationsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.creationsToolStripMenuItem.Name = "creationsToolStripMenuItem";
            this.creationsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.creationsToolStripMenuItem.Text = "Creations";
            // 
            // courserToolStripMenuItem
            // 
            this.courserToolStripMenuItem.Name = "courserToolStripMenuItem";
            this.courserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.courserToolStripMenuItem.Text = "Courser";
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subjectToolStripMenuItem.Text = "Subject";
            // 
            // assessmetnToolStripMenuItem
            // 
            this.assessmetnToolStripMenuItem.Name = "assessmetnToolStripMenuItem";
            this.assessmetnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.assessmetnToolStripMenuItem.Text = "Assessment";
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            // 
            // listsToolStripMenuItem
            // 
            this.listsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.staffsToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.subjectsToolStripMenuItem,
            this.assessmentsToolStripMenuItem,
            this.feedbacksToolStripMenuItem,
            this.wordCloudToolStripMenuItem});
            this.listsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            this.listsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.listsToolStripMenuItem.Text = "Lists";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // staffsToolStripMenuItem
            // 
            this.staffsToolStripMenuItem.Name = "staffsToolStripMenuItem";
            this.staffsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.staffsToolStripMenuItem.Text = "Staffs";
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coursesToolStripMenuItem.Text = "Courses";
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subjectsToolStripMenuItem.Text = "Subjects";
            // 
            // assessmentsToolStripMenuItem
            // 
            this.assessmentsToolStripMenuItem.Name = "assessmentsToolStripMenuItem";
            this.assessmentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.assessmentsToolStripMenuItem.Text = "Assessments";
            // 
            // feedbacksToolStripMenuItem
            // 
            this.feedbacksToolStripMenuItem.Name = "feedbacksToolStripMenuItem";
            this.feedbacksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.feedbacksToolStripMenuItem.Text = "Feedbacks";
            // 
            // wordCloudToolStripMenuItem
            // 
            this.wordCloudToolStripMenuItem.Name = "wordCloudToolStripMenuItem";
            this.wordCloudToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wordCloudToolStripMenuItem.Text = "WordCloud";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.subjectToolStripMenuItem1,
            this.assessmentToolStripMenuItem,
            this.feedbackToolStripMenuItem1,
            this.suggestionToolStripMenuItem,
            this.commentsToolStripMenuItem,
            this.wordCloudToolStripMenuItem1});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // subjectToolStripMenuItem1
            // 
            this.subjectToolStripMenuItem1.Name = "subjectToolStripMenuItem1";
            this.subjectToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.subjectToolStripMenuItem1.Text = "Subject";
            // 
            // assessmentToolStripMenuItem
            // 
            this.assessmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assessmentToolStripMenuItem1,
            this.examinationToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.assessmentToolStripMenuItem.Name = "assessmentToolStripMenuItem";
            this.assessmentToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.assessmentToolStripMenuItem.Text = "Assessment";
            // 
            // assessmentToolStripMenuItem1
            // 
            this.assessmentToolStripMenuItem1.Name = "assessmentToolStripMenuItem1";
            this.assessmentToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.assessmentToolStripMenuItem1.Text = "Assessment";
            // 
            // examinationToolStripMenuItem
            // 
            this.examinationToolStripMenuItem.Name = "examinationToolStripMenuItem";
            this.examinationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.examinationToolStripMenuItem.Text = "Examination";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // feedbackToolStripMenuItem1
            // 
            this.feedbackToolStripMenuItem1.Name = "feedbackToolStripMenuItem1";
            this.feedbackToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.feedbackToolStripMenuItem1.Text = "Summetive Feedback";
            // 
            // suggestionToolStripMenuItem
            // 
            this.suggestionToolStripMenuItem.Name = "suggestionToolStripMenuItem";
            this.suggestionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.suggestionToolStripMenuItem.Text = "Suggestion";
            // 
            // commentsToolStripMenuItem
            // 
            this.commentsToolStripMenuItem.Name = "commentsToolStripMenuItem";
            this.commentsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.commentsToolStripMenuItem.Text = "Comments";
            // 
            // wordCloudToolStripMenuItem1
            // 
            this.wordCloudToolStripMenuItem1.Name = "wordCloudToolStripMenuItem1";
            this.wordCloudToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.wordCloudToolStripMenuItem1.Text = "Word Cloud";
            // 
            // managerUserToolStripMenuItem
            // 
            this.managerUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assingCourseStudentToolStripMenuItem,
            this.assignCourseTeacherToolStripMenuItem,
            this.assignSubjectStudentToolStripMenuItem,
            this.assignSubjectTeacherToolStripMenuItem});
            this.managerUserToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.managerUserToolStripMenuItem.Name = "managerUserToolStripMenuItem";
            this.managerUserToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.managerUserToolStripMenuItem.Text = "Manager User";
            // 
            // assingCourseStudentToolStripMenuItem
            // 
            this.assingCourseStudentToolStripMenuItem.Name = "assingCourseStudentToolStripMenuItem";
            this.assingCourseStudentToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.assingCourseStudentToolStripMenuItem.Text = "Register User";
            // 
            // assignCourseTeacherToolStripMenuItem
            // 
            this.assignCourseTeacherToolStripMenuItem.Name = "assignCourseTeacherToolStripMenuItem";
            this.assignCourseTeacherToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.assignCourseTeacherToolStripMenuItem.Text = "Update User";
            // 
            // assignSubjectStudentToolStripMenuItem
            // 
            this.assignSubjectStudentToolStripMenuItem.Name = "assignSubjectStudentToolStripMenuItem";
            this.assignSubjectStudentToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.assignSubjectStudentToolStripMenuItem.Text = "Assign Subject Student";
            // 
            // assignSubjectTeacherToolStripMenuItem
            // 
            this.assignSubjectTeacherToolStripMenuItem.Name = "assignSubjectTeacherToolStripMenuItem";
            this.assignSubjectTeacherToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.assignSubjectTeacherToolStripMenuItem.Text = "Assign Subject Teacher";
            // 
            // pnlServer
            // 
            this.pnlServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlServer.Location = new System.Drawing.Point(189, 94);
            this.pnlServer.Name = "pnlServer";
            this.pnlServer.Size = new System.Drawing.Size(543, 518);
            this.pnlServer.TabIndex = 2;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 612);
            this.Controls.Add(this.pnlServer);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlSidebar);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDashBoard";
            this.Text = "frmDashBoard";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblAppHeader;
        private System.Windows.Forms.ToolStripMenuItem creationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assessmetnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assessmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbacksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordCloudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem assessmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assessmentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem examinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suggestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordCloudToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managerUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assingCourseStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignCourseTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignSubjectStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignSubjectTeacherToolStripMenuItem;
        private System.Windows.Forms.Panel pnlServer;
    }
}