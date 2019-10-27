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
    public partial class frmUserRegister : Form
    {
        ModelContext ctx = new ModelContext();
        public frmUserRegister()
        {
            InitializeComponent();
            DataLoader();
        }

        private void gbxForm_Enter(object sender, EventArgs e)
        {

        }

        private void frmUserRegister_Load(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
                MessageBox.Show(cmbRoles.SelectedItem.ToString());
            return;
            string msg;
            if ( ctx.Users.Any(x=> x.Username == txtUsername.Text)  || ctx.Users.Any(x => x.Email == txtEmail.Text))
            {
                msg = "Username and email must be unique";
            }
            else if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                msg = "Username and Email is required";
            }
            else
            {
                if (cmbRoles.SelectedItem == "STUDNET")
                {
                    MessageBox.Show(cmbRoles.SelectedItem.ToString());
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }


        void DataLoader()
        {
            dgv.DataSource = ctx.Users.Select(d => new { ID = d.Id, d.Username, d.FirstName, d.LastName, Role = d.Role.RoleName, d.Password }).ToList();


            cmbRoles.DataSource = ctx.Roles.ToList();
            cmbRoles.DisplayMember = "RoleName";
            cmbRoles.ValueMember = "Id";



            txtUsername.Text = null;
            txtAddress.Text = null;

        }

    }
}
