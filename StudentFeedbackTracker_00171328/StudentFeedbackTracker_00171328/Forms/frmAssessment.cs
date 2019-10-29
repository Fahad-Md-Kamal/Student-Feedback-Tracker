using StudentFeedbackTracker_00171328;
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
    public partial class frmAssessment : Form
    {

        Database1Entities db = new Database1Entities();
        string msg;
        public frmAssessment()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            gv.DataSource = db.Assessments.Select(d =>
                new {
                    d.Id,
                    Title = d.assTitle,
                    AssessmaneDate = d.assDate,
                    Course = d.Course.cName,
                    Staff = d.User.uName,
                    Grade = d.Grade.gradeSign,
                    AssessmentType = d.AssessmentType.assType,
                    Score = d.mark
                }).ToList();

            Helper.SetNullTxtBx(groupBox1);
        }

        private void frmAssessment_Load(object sender, EventArgs e)
        {
            var data = db.Courses.ToList();

            cboCourse.DataSource = data;
            cboCourse.DisplayMember = "cName";
            cboCourse.ValueMember = "Id";

            var student = db.Users.Where(d=> d.UserType.Id == 3).ToList();

            cboUser.DataSource = student;
            cboUser.DisplayMember = "uName";
            cboUser.ValueMember = "Id";


            var grade = db.Grades.ToList();
            cboGrade.DataSource = grade;
            cboGrade.DisplayMember = "gradeSign";
            cboGrade.ValueMember = "Id";

            var asstype = db.AssessmentTypes.ToList();
            cboAss.DataSource = asstype;
            cboAss.DisplayMember = "assType";
            cboAss.ValueMember = "Id";

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Assessment ass = new Assessment();

            ass.cId = Int32.Parse( cboCourse.SelectedValue.ToString());
            ass.assDate = dtADate.Value;
            ass.gId = Convert.ToInt32(cboGrade.SelectedValue);
            ass.uId = Convert.ToInt32(cboUser.SelectedValue);
            ass.assId = Convert.ToInt32(cboAss.SelectedValue);
            ass.mark = Convert.ToInt32(txtMark.Text);
            ass.assTitle = txtTitle.Text;

            db.Assessments.Add(ass);
            db.SaveChanges();

            MessageBox.Show("Assessemnt Creaeted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32(txtID.Text);
            var data = db.Assessments.Where(x => x.Id == id).FirstOrDefault();

            try
            {

                data.assTitle = txtTitle.Text;
                data.assDate = dtADate.Value;
                data.mark = Convert.ToInt32(txtMark.Text);
                data.assId = Convert.ToInt32(cboAss.SelectedValue);
                data.cId = Convert.ToInt32(cboCourse.SelectedValue);
                data.gId = Convert.ToInt32(cboGrade.SelectedValue);
                data.uId = Convert.ToInt32(cboUser.SelectedValue);
                msg = "Assessment Updated Successfully";
                db.SaveChanges();
                LoadData();
            }
            catch (Exception ex)
            {

                msg = ex.ToString();
            }
            MessageBox.Show( msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = gv.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtTitle.Text = row.Cells[1].Value.ToString();
                dtADate.Value = DateTime.Parse(row.Cells[2].Value.ToString());


                cboCourse.Text = row.Cells[3].Value.ToString();
                cboUser.Text = row.Cells[4].FormattedValue.ToString();
                cboGrade.Text = row.Cells[5].Value.ToString();
                cboAss.Text = row.Cells[6].Value.ToString();

                txtMark.Text = row.Cells[7].Value.ToString();

                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                lblId.Visible = true;
                txtID.Visible = true;
            }
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

            gv.DataSource = db.Assessments
            .Select( d => new
            {
                d.Id,
                Title = d.assTitle,
                AssessmaneDate = d.assDate,
                Course = d.Course.cName,
                Staff = d.User.uName,
                Grade = d.Grade.gradeSign,
                AssessmentType = d.AssessmentType.assType,
                Score = d.mark
            })
            .Where(x => 
                x.Grade == txtSearch.Text || 
                x.Title.ToLower()
                .Contains(txtSearch.Text.ToLower()))
                .ToList();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            frmCourse frm = new frmCourse();
            frm.Show();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            frmGrade frm = new frmGrade();
            frm.Show();
        }

        private void btnAssType_Click(object sender, EventArgs e)
        {
            frmAssesmentType frm = new frmAssesmentType();
            frm.Show();
        }
    }
}
