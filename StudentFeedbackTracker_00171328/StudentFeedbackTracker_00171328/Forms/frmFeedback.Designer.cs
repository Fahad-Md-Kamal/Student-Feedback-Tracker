namespace StudentFeedbackTracker_00171328
{
    partial class frmFeedback
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
            this.lblAssessment = new System.Windows.Forms.Label();
            this.cboAss = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblFeedbackType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.gbxFrm = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.gv = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPageFitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAssessment
            // 
            this.lblAssessment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAssessment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAssessment.Location = new System.Drawing.Point(44, 259);
            this.lblAssessment.Name = "lblAssessment";
            this.lblAssessment.Size = new System.Drawing.Size(100, 23);
            this.lblAssessment.TabIndex = 23;
            this.lblAssessment.Text = "Assessment : ";
            this.lblAssessment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboAss
            // 
            this.cboAss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboAss.FormattingEnabled = true;
            this.cboAss.Location = new System.Drawing.Point(165, 259);
            this.cboAss.Name = "cboAss";
            this.cboAss.Size = new System.Drawing.Size(165, 21);
            this.cboAss.TabIndex = 22;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Location = new System.Drawing.Point(256, 308);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(74, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblFeedbackType
            // 
            this.lblFeedbackType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFeedbackType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFeedbackType.Location = new System.Drawing.Point(44, 223);
            this.lblFeedbackType.Name = "lblFeedbackType";
            this.lblFeedbackType.Size = new System.Drawing.Size(100, 23);
            this.lblFeedbackType.TabIndex = 20;
            this.lblFeedbackType.Text = "Feedback type : ";
            this.lblFeedbackType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboType
            // 
            this.cboType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(165, 222);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(165, 21);
            this.cboType.TabIndex = 19;
            // 
            // gbxFrm
            // 
            this.gbxFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbxFrm.Controls.Add(this.btnAdd);
            this.gbxFrm.Controls.Add(this.lblPageFitle);
            this.gbxFrm.Controls.Add(this.txtDescription);
            this.gbxFrm.Controls.Add(this.lblDescription);
            this.gbxFrm.Controls.Add(this.txtId);
            this.gbxFrm.Controls.Add(this.lblId);
            this.gbxFrm.Controls.Add(this.txtKeyword);
            this.gbxFrm.Controls.Add(this.lblKeyword);
            this.gbxFrm.Controls.Add(this.lblAssessment);
            this.gbxFrm.Controls.Add(this.cboAss);
            this.gbxFrm.Controls.Add(this.btnUpdate);
            this.gbxFrm.Controls.Add(this.btnSubmit);
            this.gbxFrm.Controls.Add(this.lblFeedbackType);
            this.gbxFrm.Controls.Add(this.cboType);
            this.gbxFrm.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxFrm.Location = new System.Drawing.Point(0, 0);
            this.gbxFrm.Name = "gbxFrm";
            this.gbxFrm.Size = new System.Drawing.Size(428, 373);
            this.gbxFrm.TabIndex = 4;
            this.gbxFrm.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.Location = new System.Drawing.Point(165, 186);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(165, 20);
            this.txtDescription.TabIndex = 27;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Location = new System.Drawing.Point(44, 187);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 26;
            this.lblDescription.Text = "Description : ";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKeyword.Location = new System.Drawing.Point(165, 150);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(165, 20);
            this.txtKeyword.TabIndex = 25;
            // 
            // lblKeyword
            // 
            this.lblKeyword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKeyword.Location = new System.Drawing.Point(44, 151);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(100, 23);
            this.lblKeyword.TabIndex = 24;
            this.lblKeyword.Text = "Keyword : ";
            this.lblKeyword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gv
            // 
            this.gv.BackgroundColor = System.Drawing.Color.White;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv.Location = new System.Drawing.Point(428, 0);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(416, 373);
            this.gv.TabIndex = 5;
            this.gv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellClick);
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.Location = new System.Drawing.Point(44, 115);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 23);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "Id : ";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(165, 114);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(165, 20);
            this.txtId.TabIndex = 25;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(165, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(68, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblPageFitle
            // 
            this.lblPageFitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblPageFitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPageFitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPageFitle.Font = new System.Drawing.Font("High Tower Text", 28F, System.Drawing.FontStyle.Bold);
            this.lblPageFitle.ForeColor = System.Drawing.Color.White;
            this.lblPageFitle.Location = new System.Drawing.Point(3, 16);
            this.lblPageFitle.Name = "lblPageFitle";
            this.lblPageFitle.Size = new System.Drawing.Size(422, 62);
            this.lblPageFitle.TabIndex = 28;
            this.lblPageFitle.Text = "Feedback Information";
            this.lblPageFitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(342, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 24);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "+ ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 373);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.gbxFrm);
            this.Name = "frmFeedback";
            this.Text = "frmFeedback";
            this.gbxFrm.ResumeLayout(false);
            this.gbxFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAssessment;
        private System.Windows.Forms.ComboBox cboAss;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblFeedbackType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.GroupBox gbxFrm;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Label lblPageFitle;
        private System.Windows.Forms.Button btnAdd;
    }
}