using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIDemoDec19
{
    public partial class frmAssessment : Form
    {

        Database1Entities db = new Database1Entities();
        public frmAssessment()
        {
            InitializeComponent();
        }

        private void frmAssessment_Load(object sender, EventArgs e)
        {
            var data = db.Courses.ToList();

            cboCourse.DataSource = data;
            cboCourse.DisplayMember = "cName";
            cboCourse.ValueMember = "Id";

            var student = db.Users.Where(d=> d.UserType.Id == 2).ToList();

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

            MessageBox.Show("Success");
        }
    }
}
