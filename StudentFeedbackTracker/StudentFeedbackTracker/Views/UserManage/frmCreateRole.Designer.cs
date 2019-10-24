namespace StudentFeedbackTracker.Views.UserManage
{
    partial class frmCreateRole
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
            this.gbxRoleForm = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gbxRoleForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxRoleForm
            // 
            this.gbxRoleForm.BackColor = System.Drawing.Color.White;
            this.gbxRoleForm.Controls.Add(this.btnCreate);
            this.gbxRoleForm.Controls.Add(this.txtType);
            this.gbxRoleForm.Controls.Add(this.lblType);
            this.gbxRoleForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxRoleForm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRoleForm.Location = new System.Drawing.Point(0, 0);
            this.gbxRoleForm.Name = "gbxRoleForm";
            this.gbxRoleForm.Size = new System.Drawing.Size(381, 580);
            this.gbxRoleForm.TabIndex = 6;
            this.gbxRoleForm.TabStop = false;
            this.gbxRoleForm.Text = "Role Creation Form";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Location = new System.Drawing.Point(191, 264);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(157, 35);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(119, 203);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(229, 26);
            this.txtType.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(7, 206);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(84, 23);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Role Name:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(381, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(310, 580);
            this.dgv.TabIndex = 7;
            // 
            // frmCreateRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 580);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gbxRoleForm);
            this.Name = "frmCreateRole";
            this.Text = "frmCreateRole";
            this.gbxRoleForm.ResumeLayout(false);
            this.gbxRoleForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRoleForm;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DataGridView dgv;
    }
}