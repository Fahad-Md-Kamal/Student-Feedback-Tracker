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
    public partial class frmSubjectAssessment : Form
    {
        Database1Entities db = new Database1Entities();
        public frmSubjectAssessment()
        {
            InitializeComponent();
            LoadData();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            SubjectAssessment SubjectAssessment = new SubjectAssessment();

            SubjectAssessment.sId = Convert.ToInt32(cboAss.SelectedValue);
            SubjectAssessment.asId = Convert.ToInt32(cboSubject.SelectedValue);

            db.SubjectAssessments.Add(SubjectAssessment);
            db.SaveChanges();

            MessageBox.Show("Subject Assignment Created");
        }


        private void LoadData()
        {
            gv.DataSource = db.SubjectAssessments.Select(d => new {ID  = d.Id, SubjectName = d.Subject.sName, AssessmentType = d.AssessmentType.assType }).ToList();

            var sub = db.Subjects.ToList();
            cboSubject.DataSource = sub;
            cboSubject.DisplayMember = "sName";
            cboSubject.ValueMember = "Id";

            var ass = db.AssessmentTypes.ToList();
            cboAss.DataSource = ass;
            cboAss.DisplayMember = "assType";
            cboAss.ValueMember = "Id";
        }

        private void btnAssAdd_Click(object sender, EventArgs e)
        {
            frmAssesmentType frm = new frmAssesmentType();
            frm.Show();
        }

        private void btnSubAdd_Click(object sender, EventArgs e)
        {
            frmSubject frm = new frmSubject();
            frm.Show();
        }

        private void frmSubjectAssessment_Load(object sender, EventArgs e)
        {
            if (Tools.UserType == "STAFF")
            {
                btnSubAdd.Visible = false;
            }
        }
    }
}
