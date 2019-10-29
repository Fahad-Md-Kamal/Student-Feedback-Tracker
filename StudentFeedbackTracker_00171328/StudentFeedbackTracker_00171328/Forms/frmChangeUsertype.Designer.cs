namespace StudentFeedbackTracker_00171328
{
    partial class frmChangeUsertype
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(288, 344);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Change";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(119, 85);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(223, 20);
            this.txtPass.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Password : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.cboType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtUName);
            this.panel1.Location = new System.Drawing.Point(29, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 159);
            this.panel1.TabIndex = 21;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(118, 112);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 21);
            this.cboType.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "User Id : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "User Type : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(118, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(224, 20);
            this.txtId.TabIndex = 22;
            this.txtId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyUp);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(12, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "User Name : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(119, 53);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(224, 20);
            this.txtUName.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 571);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change User Information";
            // 
            // gv
            // 
            this.gv.BackgroundColor = System.Drawing.Color.White;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv.Location = new System.Drawing.Point(417, 0);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(597, 571);
            this.gv.TabIndex = 5;
            this.gv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellClick);
            // 
            // frmChangeUsertype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 571);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChangeUsertype";
            this.Text = "frmChangeUsertype";
            this.Load += new System.EventHandler(this.frmChangeUsertype_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gv;
    }
}