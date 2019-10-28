using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbackTracker_00171328
{
    public partial class frmStaffRegister : Form
    {
        User u = new User();

        Database1Entities db = new Database1Entities();
        public frmStaffRegister()
        {
            InitializeComponent();
            LoadStaffList();
        }

        private void frmStaffRegister_Load(object sender, EventArgs e)
        {

        }


        private void LoadStaffList()
        {
            var stf = db.Staffs.Select(d =>
                new { StaffId = d.Id, d.fName, d.Address, d.DOB, d.Email, d.Salary, d.User.uName, d.User.uPass }).ToList();
            gv.DataSource = stf;


            txtId.Text = null;
            txtName.Text = null;
            txtAddress.Text = null;
            dtDOB.Value = DateTime.Now;
            txtEmail.Text = null;
            txtUName.Text = null;
            txtPass.Text = null;
            txtSalary.Text = null;



        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {

            u.uName = txtUName.Text;
            u.uPass = txtPass.Text;
            u.typeId = 3;

            db.Users.Add(u);
            db.SaveChanges();

            Staff stf = new Staff();

            stf.fName = txtName.Text;
            stf.Address = txtAddress.Text;
            stf.DOB = dtDOB.Value;
            stf.Email = txtEmail.Text;
            stf.Salary = decimal.Parse(txtSalary.Text);
            stf.uId = u.Id;

            db.Staffs.Add(stf);
            db.SaveChanges();

            LoadStaffList();
            MessageBox.Show("Success");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadStaffList();
        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gv.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                dtDOB.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                txtEmail.Text = row.Cells[4].Value.ToString();
                txtSalary.Text = row.Cells[5].Value.ToString();
                txtUName.Text = row.Cells[6].Value.ToString();
                txtPass.Text = row.Cells[7].Value.ToString();

                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                lblId.Visible = true;
                txtId.Visible = true;
            }
        }
    }
}
