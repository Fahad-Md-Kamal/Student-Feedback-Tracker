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
    public partial class frmStudentRegister : Form
    {
        Database1Entities db = new Database1Entities();
        public frmStudentRegister()
        {
            InitializeComponent();
            LoadList();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUName.Text))
            {
                MessageBox.Show("User Name Is Required","ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("User must have a password", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtRoll.Text))
            {
                MessageBox.Show("Student must have a roll", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            try
            {
                User u = new User
                {
                    uName = txtUName.Text,
                    uPass = txtPass.Text,
                    typeId = 2
                };

                db.Users.Add(u);
                db.SaveChanges();

                Student std = new Student
                {
                    fName = txtName.Text,
                    Address = txtAddress.Text,
                    DOB = dtDOB.Value,
                    Email = txtEmail.Text,
                    RollNo = txtRoll.Text,
                    cId = int.Parse(cboCourse.SelectedValue.ToString()),
                    uId = u.Id
                };

                db.Students.Add(std);
                db.SaveChanges();
                LoadList();
                MessageBox.Show("Student Registered Successfully", "SUCCESS !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmStudentRegister_Load(object sender, EventArgs e)
        {
            var data = db.Courses.ToList();

            cboCourse.DataSource = data;
            cboCourse.DisplayMember = "cName";
            cboCourse.ValueMember = "Id";


            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            lblId.Visible = false;
            txtId.Visible = false;


        }


        public void LoadList()
        {
            gv.DataSource = db.Students.Select(d =>
                            new { StudentId = d.Id,
                                RoLL = d.RollNo,
                                Name = d.fName,
                                UserName = d.User.uName,
                                DoB = d.DOB,
                                Email = d.Email,
                                Password = d.User.uPass,
                                Course = d.Course.cName,
                                Address = d.Address })
                                .ToList();

            Helper.SetNullTxtBx(groupBox1);

        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gv.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtRoll.Text = row.Cells[1].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                txtUName.Text = row.Cells[3].Value.ToString();
                dtDOB.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                txtEmail.Text = row.Cells[5].Value.ToString();
                txtPass.Text = row.Cells[6].Value.ToString();
                cboCourse.Text = row.Cells[7].Value.ToString();
                txtAddress.Text = row.Cells[8].Value.ToString();


                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                
                lblId.Visible = true;
                txtId.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = Convert.ToInt32(txtId.Text);

                var data = db.Students.Where(d => d.Id == idx).FirstOrDefault();

                data.RollNo = txtRoll.Text;
                data.fName = txtName.Text;
                data.Email = txtEmail.Text;
                data.Address = txtAddress.Text;
                data.DOB = dtDOB.Value;
                data.cId = Convert.ToInt32(cboCourse.SelectedValue);
                data.User.uName = txtUName.Text;
                data.User.uPass = txtPass.Text;

                db.SaveChanges();
                LoadList();
                MessageBox.Show("Student's Data Updated Successfully", "SUCCESS !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = Convert.ToInt32(txtId.Text);

                var data = db.Students.Where(d => d.Id == idx).FirstOrDefault();

                db.Students.Remove(data);
                db.SaveChanges();
                MessageBox.Show("Student's Data Deleted Successfully", "SUCCESS !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCourse frm = new frmCourse();
            frm.Show();
        }

    }
}
