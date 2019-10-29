using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbackTracker_00171328.Forms
{
    public partial class stdntAssessDtl : Form
    {

        Database1Entities db = new Database1Entities();

        public stdntAssessDtl()
        {
            InitializeComponent();
            LoadData();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

            gv.DataSource = db.Assessments.Select(d =>
               new {
                   d.Id,
                   Title = d.assTitle,
                   AssessmaneDate = d.assDate,
                   Course = d.Course.cName,
                   Student = d.User.uName,
                   Grade = d.Grade.gradeSign,
                   AssessmentType = d.AssessmentType.assType,
                   Score = d.mark
               }).
               Where(x =>
                x.Student == Tools.UserName && x.Grade == txtSearch.Text.ToUpper())
                .ToList();
        }


        void LoadData()
        {
            gv.DataSource = db.Assessments.Select(d =>
               new {
                   d.Id,
                   Title = d.assTitle,
                   AssessmaneDate = d.assDate,
                   Course = d.Course.cName,
                   Student = d.User.uName,
                   Grade = d.Grade.gradeSign,
                   AssessmentType = d.AssessmentType.assType,
                   Score = d.mark
               }).
               Where(x =>
                x.Student == Tools.UserName)
                .ToList();

        }
    }
}
