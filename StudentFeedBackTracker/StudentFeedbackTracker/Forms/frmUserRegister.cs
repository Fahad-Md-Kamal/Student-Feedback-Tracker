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
        string msg;
        int cellIndex;

        public frmUserRegister()
        {
            InitializeComponent();
            DataLoader();



            cmbRoles.DataSource = ctx.Roles.ToList();
            cmbRoles.DisplayMember = "RoleName";
            cmbRoles.ValueMember = "Id";
        }

        private void gbxForm_Enter(object sender, EventArgs e)
        {

        }

        private void frmUserRegister_Load(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
             

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
            dgv.DataSource = ctx.Users.Select(d => 
            new {
                ID = d.Id,
                d.Username,
                d.FirstName,
                d.LastName,
                d.Email,
                d.DoB,
                d.Address,
                Role = d.Role.RoleName,
                d.Password }).ToList();


            txtUsername.Text = null;
            txtAddress.Text = null;
            txtEmail.Text = null;
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtPassword.Text = null;

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {

            int rl = Convert.ToInt32(cmbRoles.SelectedValue);

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                msg += "Username is Required";
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                msg += "Password is Required";
                return;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                msg += "Email is Required";
                return;
            }
            else
            {

                if (rl == 3)
                {
                    ctx.Students.Add(
                        new Student
                        {

                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            Address = txtAddress.Text,
                            Email = txtEmail.Text,
                            Password = txtPassword.Text,
                            DoB = dtp.Value,
                            Username = txtUsername.Text,
                            RoleId = 3
                        });

                    msg = "Student Registered Successfully";
                }
                else if (rl == 2)
                {
                    ctx.Staffs.Add(new Staff
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Address = txtAddress.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        DoB = dtp.Value,
                        Username = txtUsername.Text,
                        RoleId = 3
                    });
                    msg = "Student Registered Successfully";
                }
            }


            ctx.SaveChanges();

            DataLoader();
            MessageBox.Show(msg , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtUsername.Text = row.Cells[1].Value.ToString();
                txtFirstName.Text = row.Cells[2].Value.ToString();
                txtLastName.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                dtp.Value = DateTime.Parse(row.Cells[5].Value.ToString());
                txtAddress.Text = row.Cells[6].Value.ToString();
                cmbRoles.SelectedItem = row.Cells[7].Value;
                txtPassword.Text = row.Cells[8].Value.ToString();

                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                lblId.Visible = true;
                txtId.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUserRole frm = new frmUserRole();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
