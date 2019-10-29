namespace StudentFeedbackTracker_00171328.Forms
{
    partial class frmStudent
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
            this.btnAllFeedback = new System.Windows.Forms.Button();
            this.btnAssessmentsDtl = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
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
            this.pnlService.Size = new System.Drawing.Size(823, 653);
            this.pnlService.TabIndex = 6;
            // 
            // pnlbtn
            // 
            this.pnlbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(33)))));
            this.pnlbtn.Controls.Add(this.btnAllFeedback);
            this.pnlbtn.Controls.Add(this.btnAssessmentsDtl);
            this.pnlbtn.Controls.Add(this.btnNote);
            this.pnlbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlbtn.Location = new System.Drawing.Point(0, 67);
            this.pnlbtn.Name = "pnlbtn";
            this.pnlbtn.Size = new System.Drawing.Size(206, 653);
            this.pnlbtn.TabIndex = 5;
            // 
            // btnAllFeedback
            // 
            this.btnAllFeedback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAllFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllFeedback.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnAllFeedback.ForeColor = System.Drawing.Color.White;
            this.btnAllFeedback.Location = new System.Drawing.Point(8, 217);
            this.btnAllFeedback.Name = "btnAllFeedback";
            this.btnAllFeedback.Size = new System.Drawing.Size(180, 43);
            this.btnAllFeedback.TabIndex = 2;
            this.btnAllFeedback.Text = "All Feedbacks";
            this.btnAllFeedback.UseVisualStyleBackColor = true;
            this.btnAllFeedback.Click += new System.EventHandler(this.btnAllFeedback_Click);
            // 
            // btnAssessmentsDtl
            // 
            this.btnAssessmentsDtl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAssessmentsDtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssessmentsDtl.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnAssessmentsDtl.ForeColor = System.Drawing.Color.White;
            this.btnAssessmentsDtl.Location = new System.Drawing.Point(8, 103);
            this.btnAssessmentsDtl.Name = "btnAssessmentsDtl";
            this.btnAssessmentsDtl.Size = new System.Drawing.Size(180, 43);
            this.btnAssessmentsDtl.TabIndex = 1;
            this.btnAssessmentsDtl.Text = "Assessment Detail";
            this.btnAssessmentsDtl.UseVisualStyleBackColor = true;
            this.btnAssessmentsDtl.Click += new System.EventHandler(this.btnAssessmentsDtl_Click);
            // 
            // btnNote
            // 
            this.btnNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNote.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnNote.ForeColor = System.Drawing.Color.White;
            this.btnNote.Location = new System.Drawing.Point(8, 331);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(180, 43);
            this.btnNote.TabIndex = 0;
            this.btnNote.Text = "NOTE";
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SeaGreen;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1029, 67);
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
            this.lblUserType.Click += new System.EventHandler(this.lblUserType_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 720);
            this.Controls.Add(this.pnlService);
            this.Controls.Add(this.pnlbtn);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmStudent";
            this.Text = "frmStudent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlbtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlService;
        private System.Windows.Forms.Panel pnlbtn;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Button btnAllFeedback;
        private System.Windows.Forms.Button btnAssessmentsDtl;
    }
}