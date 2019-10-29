namespace StudentFeedbackTracker_00171328
{
    partial class frmGrade
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
            this.txtMinMarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxMarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMinMarks);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMaxMarks);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.txtGrade);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 181);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grade Information";
            // 
            // txtMinMarks
            // 
            this.txtMinMarks.Location = new System.Drawing.Point(116, 87);
            this.txtMinMarks.Name = "txtMinMarks";
            this.txtMinMarks.Size = new System.Drawing.Size(128, 20);
            this.txtMinMarks.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Minimum Mark : ";
            // 
            // txtMaxMarks
            // 
            this.txtMaxMarks.Location = new System.Drawing.Point(116, 61);
            this.txtMaxMarks.Name = "txtMaxMarks";
            this.txtMaxMarks.Size = new System.Drawing.Size(128, 20);
            this.txtMaxMarks.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maximum Mark : ";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(24, 132);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(116, 33);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(128, 20);
            this.txtGrade.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grade : ";
            // 
            // frmGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 221);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmGrade";
            this.Text = "frmGrade";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinMarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxMarks;
    }
}