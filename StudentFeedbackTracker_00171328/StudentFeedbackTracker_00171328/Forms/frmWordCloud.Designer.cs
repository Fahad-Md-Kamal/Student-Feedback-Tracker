namespace StudentFeedbackTracker_00171328
{
    partial class frmWordCloud
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
            this.gv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv
            // 
            this.gv.BackgroundColor = System.Drawing.Color.White;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv.Location = new System.Drawing.Point(319, 0);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(432, 301);
            this.gv.TabIndex = 7;
            this.gv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.lblCount);
            this.groupBox1.Controls.Add(this.lblWord);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 301);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Note Information";
            // 
            // lblCount
            // 
            this.lblCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCount.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(156, 98);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(139, 39);
            this.lblCount.TabIndex = 27;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWord
            // 
            this.lblWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWord.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(6, 98);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(136, 39);
            this.lblWord.TabIndex = 26;
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmWordCloud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 301);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmWordCloud";
            this.Text = "frmWordCloud";
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblWord;
    }
}