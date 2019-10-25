namespace ADIDemoDec19
{
    partial class frmNote
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFeedback = new System.Windows.Forms.ComboBox();
            this.lblNoteOwner = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(28, 140);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboFeedback);
            this.groupBox1.Controls.Add(this.lblNoteOwner);
            this.groupBox1.Controls.Add(this.lblOwner);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 202);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Note Information";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(28, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Feedback : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboFeedback
            // 
            this.cboFeedback.FormattingEnabled = true;
            this.cboFeedback.Location = new System.Drawing.Point(135, 75);
            this.cboFeedback.Name = "cboFeedback";
            this.cboFeedback.Size = new System.Drawing.Size(121, 21);
            this.cboFeedback.TabIndex = 31;
            // 
            // lblNoteOwner
            // 
            this.lblNoteOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNoteOwner.Location = new System.Drawing.Point(135, 38);
            this.lblNoteOwner.Name = "lblNoteOwner";
            this.lblNoteOwner.Size = new System.Drawing.Size(121, 23);
            this.lblNoteOwner.TabIndex = 30;
            this.lblNoteOwner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOwner
            // 
            this.lblOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOwner.Location = new System.Drawing.Point(28, 37);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(100, 23);
            this.lblOwner.TabIndex = 29;
            this.lblOwner.Text = "Owner :";
            this.lblOwner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(135, 111);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(121, 20);
            this.txtNote.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(28, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Note : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 327);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNote";
            this.Text = "frmNote";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNoteOwner;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboFeedback;
    }
}