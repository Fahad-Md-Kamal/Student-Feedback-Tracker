﻿using StudentFeedbackTracker_00171328;
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
        public frmAssessment()
        {
            InitializeComponent();
            LoadData();
        }

        private void frmAssessment_Load(object sender, EventArgs e)
        {
            var data = db.Courses.ToList();

            cboCourse.DataSource = data;
            cboCourse.DisplayMember = "cName";
            cboCourse.ValueMember = "Id";

            var staff = db.Users.Where(d=> d.UserType.Id == 3).ToList();

            cboUser.DataSource = staff;
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

            MessageBox.Show("Success");
            LoadData();
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

        private void LoadData()
        {
            gv.DataSource = db.Assessments.Select(d =>
                new { d.Id,
                    Title = d.assTitle,
                    AssessmaneDate = d.assDate,
                    Course = d.Course.cName,
                    Staff = d.User.uName,
                    Grade = d.Grade.gradeSign,
                    AssessmentType = d.AssessmentType.assType,
                    Score = d.mark
                }).ToList();





        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = gv.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtTitle.Text = row.Cells[1].Value.ToString();
                dtADate.Value = DateTime.Parse(row.Cells[2].Value.ToString());


                cboCourse.SelectedItem = row.Cells[3].Value.ToString();
                //cboUser.SelectedItem = row.Cells[4].FormattedValue.ToString();
                //cboGrade.SelectedValue = row.Cells[5].Value;
                //cboAss.SelectedValue = row.Cells[6].Value;

                txtMark.Text = row.Cells[7].Value.ToString();

                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                lblId.Visible = true;
                txtID.Visible = true;
            }
        }
    }
}
