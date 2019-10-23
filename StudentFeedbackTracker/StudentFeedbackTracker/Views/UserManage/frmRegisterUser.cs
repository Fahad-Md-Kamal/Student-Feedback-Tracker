using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbackTracker.Views.UserManage
{
    public partial class frmRegistrationForm : Form
    {
        Database1Entities1 db = new Database1Entities1();
        public frmRegistrationForm()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

            cmbUserType.DataSource = db.UserRoles.ToList();
            cmbUserType.DisplayMember = "uRole";
            cmbUserType.ValueMember = "Id";
            LoadList();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            User user = new User()
            {
                Username = txtUsername.Text,
                First_Name = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Passsword = txtPassword.Text,
                DoB = dtpDoB.Value,
                RoleId = Convert.ToInt32(cmbUserType.SelectedValue)
            };

            db.Users.Add(user);
            db.SaveChanges();
            LoadList();
            MessageBox.Show("User Stored Successfully Into The System", "Success !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void LoadList()
        {
            var List = db.Users.Select(c => new {c.Id,
                                                 c.Username,
                                                 Firstname = c.First_Name,
                                                 Lastname = c.LastName,
                                                 c.Email,
                                                 Password = c.Passsword,
                                                 c.DoB }).ToList();
            dgv.DataSource = List;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                dgv.CurrentRow.Selected = true;

                txtUsername.Text = dgv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtFirstName.Text = dgv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtLastName.Text = dgv.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtEmail.Text = dgv.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtPassword.Text = dgv.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();


                //if (dgv.CurrentCell != null && dgv.CurrentCell.Value != null)
                //    MessageBox.Show(dgv.CurrentCell.Value.ToString());
            }
        }

    }
}
