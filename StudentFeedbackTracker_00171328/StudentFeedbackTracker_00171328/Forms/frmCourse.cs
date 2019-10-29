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
    public partial class frmCourse : Form
    {
        Database1Entities db = new Database1Entities();
        string msg;

        public frmCourse()
        {
            InitializeComponent();
            LoadCourseList();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (!Helper.TxTNullCheck(txtName))
            {
                MessageBox.Show("Course Name Cannot be Empty");
                return;
            }
            Course cor = new Course() { cName = txtName.Text };
            db.Courses.Add(cor);
            db.SaveChanges();
            
            MessageBox.Show("Data Inserted Successfully ...");
        }

        private void LoadCourseList()
        {
            gv.DataSource = db.Courses.Select(d =>
                new { CourseId = d.Id, d.cName }).ToList();


            GvStudentList.DataSource = db.Students.Select(s => new { Roll =s.RollNo, Username = s.User.uName, Course = s.Course.cName }).ToList();

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            txtId.Visible = false;
            lblId.Visible = false;
            txtId.Text = null;
            txtName.Text = null;
        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = gv.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();


                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                txtId.Visible = true;
                lblId.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (!Helper.CheckNull(groupBox1))
            {
                msg += "Empty Field Found";
            }
            if (!Helper.CheckInt(txtId.Text))
            {
                msg += "Id Must be Numeric";
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(txtId.Text);

                    var course = db.Courses.Where(c => c.Id == id).FirstOrDefault();

                    course.cName = txtName.Text.ToUpper();
                    db.SaveChanges();
                    LoadCourseList();
                    msg += "Data Updated Successfully";
                }
                catch (Exception ex)
                {
                    msg = ex.ToString();
                }
            }
            
            MessageBox.Show( msg, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var course = db.Courses.Where(c => c.Id == id).FirstOrDefault();

            db.Courses.Remove(course);
            db.SaveChanges();
            LoadCourseList();
            MessageBox.Show("Data Deleted", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
