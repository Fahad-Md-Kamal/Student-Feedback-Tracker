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
    public partial class frmSubjectAssessment : Form
    {
        Database1Entities db = new Database1Entities();
        public frmSubjectAssessment()
        {
            InitializeComponent();
        }

        private void frmSubjectAssessment_Load(object sender, EventArgs e)
        {
            LoadAssessment();
            LoadSubject();
        }

        private void LoadAssessment()
        {
            var ass = db.AssessmentTypes.ToList();

            cboAss.DataSource = ass;
            cboAss.DisplayMember = "assType";
            cboAss.ValueMember = "Id";

        }


        private void LoadSubject()
        {
            var sub = db.Subjects.ToList();

            cboSubject.DataSource = sub;
            cboSubject.DisplayMember = "sName";
            cboSubject.ValueMember = "Id";

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
    }
}
