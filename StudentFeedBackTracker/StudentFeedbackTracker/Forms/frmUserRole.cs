using StudentFeedbackTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbackTracker.Forms
{
    public partial class frmUserRole : Form
    {
        ModelContext ctx = new ModelContext();

        public frmUserRole()
        {
            InitializeComponent();
            LoadData();
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            lblId.Visible = false;
            txtId.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validation(txtRoleName.Text))
            {

                ctx.Roles.Add(new Role { RoleName = txtRoleName.Text.ToUpper() });
                ctx.SaveChanges();
                LoadData();
                MessageBox.Show("Role Created Successfully", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            MessageBox.Show("Invalid Role Input", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LoadData()
        {
            dgv.DataSource = ctx.Roles.Select(x=> new { ID = x.Id, Role = x.RoleName }).ToList();
            txtId.Text = null;
            txtRoleName.Text = null;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtRoleName.Text = row.Cells[1].Value.ToString();

                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                lblId.Visible = true;
                txtId.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ( Validation(txtRoleName.Text))
            {
                int Id = Convert.ToInt32(txtId.Text);

                var role = ctx.Roles.Where(x => x.Id == Id).FirstOrDefault();
                role.RoleName = txtRoleName.Text.ToUpper();
                ctx.SaveChanges();
                LoadData();
                MessageBox.Show("Role Created Successfully", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Invalid Input", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        bool Validation( string txt )
        {
            if (string.IsNullOrEmpty(txt))
            {
                return false;
            }
            else if (ctx.Roles.Any(x => x.RoleName == txtRoleName.Text.ToUpper()))
            {
                return false;
            }

            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text);
            Role data = ctx.Roles.Where(x=> x.Id == Id).FirstOrDefault();
            ctx.Roles.Remove(data);
            ctx.SaveChanges();
            LoadData();
            MessageBox.Show("Role Removed", "Deleted !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
