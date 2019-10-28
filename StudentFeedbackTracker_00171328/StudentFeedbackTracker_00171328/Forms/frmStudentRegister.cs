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
            User u = new User();

            u.uName = txtUName.Text;
            u.uPass = txtPass.Text;
            u.typeId = 2;

            db.Users.Add(u);
            db.SaveChanges();

            Student std = new Student();

            std.fName = txtName.Text;
            std.Address = txtAddress.Text;
            std.DOB = dtDOB.Value;
            std.Email = txtEmail.Text;
            std.RollNo = txtRoll.Text;
            std.cId = Int32.Parse(cboCourse.SelectedValue.ToString());
            std.uId = u.Id;

            db.Students.Add(std);
            db.SaveChanges();

            LoadList();
            MessageBox.Show("Success");

        }

        private void frmStudentRegister_Load(object sender, EventArgs e)
        {
            var data = db.Courses.ToList();

            cboCourse.DataSource = data;
            cboCourse.DisplayMember = "cName";
            cboCourse.ValueMember = "Id";
        }


        private void LoadList()
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

            txtEmail.Text = null;
            txtUName.Text = null;
            txtAddress.Text = null;
            txtPass.Text = null;
            txtPass.Text = null;
            txtPass.Text = null;


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
                cboCourse.SelectedItem = row.Cells[7].Value.ToString();
                txtAddress.Text = row.Cells[8].Value.ToString();


                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                lblId.Visible = true;
                txtId.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCourse frm = new frmCourse();
            frm.Show();
        }
    }
}
