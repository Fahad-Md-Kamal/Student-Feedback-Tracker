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
            gv.DataSource = db.Staffs.Select(d =>
                new { StaffId = d.Id, d.fName, d.Address, d.DOB, d.Email, d.Salary, d.User.uName, d.User.uPass }).ToList();

            Helper.SetNullTxtBx(gbxfrm);
            dtDOB.Value = DateTime.Now;

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            lblId.Visible = false;
            txtId.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUName.Text))
            {
                MessageBox.Show("User Name Is Required","ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Staff Email Address is Required", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
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
                MessageBox.Show("Staff record Saved Successfully", "SUCCESS !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUName.Text))
            {
                MessageBox.Show("User Name Is Required", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Staff Email Address is Required", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int idx = Convert.ToInt32(txtId.Text);
                var data = db.Staffs.Where(d => d.Id == idx).FirstOrDefault();

                data.fName = txtName.Text;
                data.Address = txtAddress.Text;
                data.DOB = dtDOB.Value;
                data.Email = txtEmail.Text;
                data.Salary = int.Parse(txtSalary.Text);
                data.User.uName = txtUName.Text;
                data.User.uPass = txtPass.Text;

                db.SaveChanges();

                LoadStaffList();
                MessageBox.Show("Staff's Information Updated Successfully", "SUCCESS !!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = Convert.ToInt32(txtId.Text);
                var data = db.Staffs.Where(d => d.Id == idx).FirstOrDefault();

                db.Staffs.Remove(data);
                db.SaveChanges();
                MessageBox.Show("Staff's Information data deleted Successfully", "SUCCESS !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
