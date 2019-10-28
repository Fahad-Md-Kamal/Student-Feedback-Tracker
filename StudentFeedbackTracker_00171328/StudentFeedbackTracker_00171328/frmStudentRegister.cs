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

            MessageBox.Show("Success");
        }

        private void frmStudentRegister_Load(object sender, EventArgs e)
        {
            var data = db.Courses.ToList();

            cboCourse.DataSource = data;
            cboCourse.DisplayMember = "cName";
            cboCourse.ValueMember = "Id";
        }
    }
}
