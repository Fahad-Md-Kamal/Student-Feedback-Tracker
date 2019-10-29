namespace StudentFeedbackTracker_00171328.Forms
{
    partial class frmStaff
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
            this.pnlService = new System.Windows.Forms.Panel();
            this.pnlbtn = new System.Windows.Forms.Panel();
            this.btnSubjectAss = new System.Windows.Forms.Button();
            this.btnBarChart = new System.Windows.Forms.Button();
            this.btnWordCloud = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnAssessment = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.pnlbtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlService
            // 
            this.pnlService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlService.Location = new System.Drawing.Point(206, 67);
            this.pnlService.Name = "pnlService";
            this.pnlService.Size = new System.Drawing.Size(985, 668);
            this.pnlService.TabIndex = 6;
            // 
            // pnlbtn
            // 
            this.pnlbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(33)))));
            this.pnlbtn.Controls.Add(this.btnSubjectAss);
            this.pnlbtn.Controls.Add(this.btnBarChart);
            this.pnlbtn.Controls.Add(this.btnWordCloud);
            this.pnlbtn.Controls.Add(this.btnNote);
            this.pnlbtn.Controls.Add(this.btnFeedback);
            this.pnlbtn.Controls.Add(this.btnAssessment);
            this.pnlbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlbtn.Location = new System.Drawing.Point(0, 67);
            this.pnlbtn.Name = "pnlbtn";
            this.pnlbtn.Size = new System.Drawing.Size(206, 668);
            this.pnlbtn.TabIndex = 5;
            // 
            // btnSubjectAss
            // 
            this.btnSubjectAss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubjectAss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectAss.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubjectAss.ForeColor = System.Drawing.Color.White;
            this.btnSubjectAss.Location = new System.Drawing.Point(12, 98);
            this.btnSubjectAss.Name = "btnSubjectAss";
            this.btnSubjectAss.Size = new System.Drawing.Size(180, 43);
            this.btnSubjectAss.TabIndex = 0;
            this.btnSubjectAss.Text = "Assessment Subject";
            this.btnSubjectAss.UseVisualStyleBackColor = true;
            this.btnSubjectAss.Click += new System.EventHandler(this.btnSubjectAss_Click);
            // 
            // btnBarChart
            // 
            this.btnBarChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBarChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarChart.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnBarChart.ForeColor = System.Drawing.Color.White;
            this.btnBarChart.Location = new System.Drawing.Point(12, 467);
            this.btnBarChart.Name = "btnBarChart";
            this.btnBarChart.Size = new System.Drawing.Size(180, 43);
            this.btnBarChart.TabIndex = 0;
            this.btnBarChart.Text = "BAR CHART";
            this.btnBarChart.UseVisualStyleBackColor = true;
            this.btnBarChart.Click += new System.EventHandler(this.btnBarChart_Click);
            // 
            // btnWordCloud
            // 
            this.btnWordCloud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWordCloud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWordCloud.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnWordCloud.ForeColor = System.Drawing.Color.White;
            this.btnWordCloud.Location = new System.Drawing.Point(12, 388);
            this.btnWordCloud.Name = "btnWordCloud";
            this.btnWordCloud.Size = new System.Drawing.Size(180, 43);
            this.btnWordCloud.TabIndex = 0;
            this.btnWordCloud.Text = "WORD CLOUD";
            this.btnWordCloud.UseVisualStyleBackColor = true;
            this.btnWordCloud.Click += new System.EventHandler(this.btnWordCloud_Click);
            // 
            // btnNote
            // 
            this.btnNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNote.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnNote.ForeColor = System.Drawing.Color.White;
            this.btnNote.Location = new System.Drawing.Point(12, 315);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(180, 43);
            this.btnNote.TabIndex = 0;
            this.btnNote.Text = "NOTE";
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnFeedback.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.Location = new System.Drawing.Point(12, 244);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(180, 43);
            this.btnFeedback.TabIndex = 0;
            this.btnFeedback.Text = "FEEDBACK";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnAssessment
            // 
            this.btnAssessment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssessment.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnAssessment.ForeColor = System.Drawing.Color.White;
            this.btnAssessment.Location = new System.Drawing.Point(12, 171);
            this.btnAssessment.Name = "btnAssessment";
            this.btnAssessment.Size = new System.Drawing.Size(180, 43);
            this.btnAssessment.TabIndex = 0;
            this.btnAssessment.Text = "ASSESSMENT DETAIL";
            this.btnAssessment.UseVisualStyleBackColor = true;
            this.btnAssessment.Click += new System.EventHandler(this.btnAssessment_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SeaGreen;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1191, 67);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Student Feedback Tracker";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserType
            // 
            this.lblUserType.BackColor = System.Drawing.Color.SeaGreen;
            this.lblUserType.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.White;
            this.lblUserType.Location = new System.Drawing.Point(2, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(181, 67);
            this.lblUserType.TabIndex = 7;
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 735);
            this.Controls.Add(this.pnlService);
            this.Controls.Add(this.pnlbtn);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUserType);
            this.Name = "frmStaff";
            this.Text = "frmStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlbtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlService;
        private System.Windows.Forms.Panel pnlbtn;
        private System.Windows.Forms.Button btnSubjectAss;
        private System.Windows.Forms.Button btnBarChart;
        private System.Windows.Forms.Button btnWordCloud;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnAssessment;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserType;
    }
}