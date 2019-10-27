namespace StudentFeedbackTracker
{
    partial class Form1
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
            this.lblSiteTitle = new System.Windows.Forms.Label();
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.pnlService = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnAssessment = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnWordCloud = new System.Windows.Forms.Button();
            this.btnBarchart = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.pnlBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSiteTitle
            // 
            this.lblSiteTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(100)))), ((int)(((byte)(93)))));
            this.lblSiteTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSiteTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSiteTitle.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteTitle.ForeColor = System.Drawing.Color.White;
            this.lblSiteTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSiteTitle.Name = "lblSiteTitle";
            this.lblSiteTitle.Size = new System.Drawing.Size(800, 61);
            this.lblSiteTitle.TabIndex = 0;
            this.lblSiteTitle.Text = "Student Feedback Tracker";
            this.lblSiteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBtns
            // 
            this.pnlBtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.pnlBtns.Controls.Add(this.btnCourse);
            this.pnlBtns.Controls.Add(this.btnBarchart);
            this.pnlBtns.Controls.Add(this.btnWordCloud);
            this.pnlBtns.Controls.Add(this.btnFeedback);
            this.pnlBtns.Controls.Add(this.btnAssessment);
            this.pnlBtns.Controls.Add(this.btnSubject);
            this.pnlBtns.Controls.Add(this.btnUser);
            this.pnlBtns.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBtns.Location = new System.Drawing.Point(0, 61);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(166, 491);
            this.pnlBtns.TabIndex = 1;
            // 
            // pnlService
            // 
            this.pnlService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlService.Location = new System.Drawing.Point(166, 61);
            this.pnlService.Name = "pnlService";
            this.pnlService.Size = new System.Drawing.Size(634, 491);
            this.pnlService.TabIndex = 2;
            // 
            // btnUser
            // 
            this.btnUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(12, 19);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(137, 38);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "&USERS";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.Color.White;
            this.btnCourse.Location = new System.Drawing.Point(12, 89);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(137, 38);
            this.btnCourse.TabIndex = 1;
            this.btnCourse.Text = "&COURSE";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnAssessment
            // 
            this.btnAssessment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssessment.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssessment.ForeColor = System.Drawing.Color.White;
            this.btnAssessment.Location = new System.Drawing.Point(12, 229);
            this.btnAssessment.Name = "btnAssessment";
            this.btnAssessment.Size = new System.Drawing.Size(137, 38);
            this.btnAssessment.TabIndex = 1;
            this.btnAssessment.Text = "&ASSESSMENT";
            this.btnAssessment.UseVisualStyleBackColor = true;
            this.btnAssessment.Click += new System.EventHandler(this.btnAssessment_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.Location = new System.Drawing.Point(12, 299);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(137, 38);
            this.btnFeedback.TabIndex = 1;
            this.btnFeedback.Text = "&FEEDBACK";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnWordCloud
            // 
            this.btnWordCloud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWordCloud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWordCloud.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWordCloud.ForeColor = System.Drawing.Color.White;
            this.btnWordCloud.Location = new System.Drawing.Point(12, 369);
            this.btnWordCloud.Name = "btnWordCloud";
            this.btnWordCloud.Size = new System.Drawing.Size(137, 38);
            this.btnWordCloud.TabIndex = 1;
            this.btnWordCloud.Text = "&WORDCLOUD";
            this.btnWordCloud.UseVisualStyleBackColor = true;
            this.btnWordCloud.Click += new System.EventHandler(this.btnWordCloud_Click);
            // 
            // btnBarchart
            // 
            this.btnBarchart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBarchart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarchart.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarchart.ForeColor = System.Drawing.Color.White;
            this.btnBarchart.Location = new System.Drawing.Point(12, 439);
            this.btnBarchart.Name = "btnBarchart";
            this.btnBarchart.Size = new System.Drawing.Size(137, 38);
            this.btnBarchart.TabIndex = 1;
            this.btnBarchart.Text = "&BARCHART";
            this.btnBarchart.UseVisualStyleBackColor = true;
            this.btnBarchart.Click += new System.EventHandler(this.btnBarchart_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubject.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubject.ForeColor = System.Drawing.Color.White;
            this.btnSubject.Location = new System.Drawing.Point(12, 159);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(137, 38);
            this.btnSubject.TabIndex = 1;
            this.btnSubject.Text = "&SUBJECT";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.pnlService);
            this.Controls.Add(this.pnlBtns);
            this.Controls.Add(this.lblSiteTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSiteTitle;
        private System.Windows.Forms.Panel pnlBtns;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnBarchart;
        private System.Windows.Forms.Button btnWordCloud;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnAssessment;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel pnlService;
        private System.Windows.Forms.Button btnSubject;
    }
}

