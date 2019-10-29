namespace StudentFeedbackTracker_00171328
{
    partial class frmSubjectAssessment
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSubAdd = new System.Windows.Forms.Button();
            this.btnAssAdd = new System.Windows.Forms.Button();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.cboAss = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gv = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSubAdd);
            this.groupBox2.Controls.Add(this.btnAssAdd);
            this.groupBox2.Controls.Add(this.cboSubject);
            this.groupBox2.Controls.Add(this.cboAss);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 353);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subject Assessment Information";
            // 
            // btnSubAdd
            // 
            this.btnSubAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnSubAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubAdd.ForeColor = System.Drawing.Color.White;
            this.btnSubAdd.Location = new System.Drawing.Point(251, 127);
            this.btnSubAdd.Name = "btnSubAdd";
            this.btnSubAdd.Size = new System.Drawing.Size(75, 30);
            this.btnSubAdd.TabIndex = 6;
            this.btnSubAdd.Text = "+ADD";
            this.btnSubAdd.UseVisualStyleBackColor = false;
            this.btnSubAdd.Click += new System.EventHandler(this.btnSubAdd_Click);
            // 
            // btnAssAdd
            // 
            this.btnAssAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAssAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssAdd.ForeColor = System.Drawing.Color.White;
            this.btnAssAdd.Location = new System.Drawing.Point(251, 76);
            this.btnAssAdd.Name = "btnAssAdd";
            this.btnAssAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAssAdd.TabIndex = 5;
            this.btnAssAdd.Text = "+ ADD";
            this.btnAssAdd.UseVisualStyleBackColor = false;
            this.btnAssAdd.Click += new System.EventHandler(this.btnAssAdd_Click);
            // 
            // cboSubject
            // 
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(114, 133);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(121, 21);
            this.cboSubject.TabIndex = 4;
            // 
            // cboAss
            // 
            this.cboAss.FormattingEnabled = true;
            this.cboAss.Location = new System.Drawing.Point(114, 80);
            this.cboAss.Name = "cboAss";
            this.cboAss.Size = new System.Drawing.Size(121, 21);
            this.cboAss.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject : ";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(160, 194);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Assessment : ";
            // 
            // gv
            // 
            this.gv.BackgroundColor = System.Drawing.Color.White;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv.Location = new System.Drawing.Point(349, 0);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(309, 353);
            this.gv.TabIndex = 4;
            // 
            // frmSubjectAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 353);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmSubjectAssessment";
            this.Text = "frmSubjectAssessment";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.ComboBox cboAss;
        private System.Windows.Forms.Button btnSubAdd;
        private System.Windows.Forms.Button btnAssAdd;
        private System.Windows.Forms.DataGridView gv;
    }
}