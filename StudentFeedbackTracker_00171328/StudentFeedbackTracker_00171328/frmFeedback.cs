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
    public partial class frmFeedback : Form
    {
        Database1Entities db = new Database1Entities();
        public frmFeedback()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var feedbackType = db.FeedbackTypes.ToList();
            cboType.DataSource = feedbackType;
            cboType.DisplayMember = "fType";
            cboType.ValueMember = "Id";

            var assessment = db.Assessments.ToList();
            cboAss.DataSource = assessment;
            cboAss.DisplayMember = "assTitle";
            cboAss.ValueMember = "Id";
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Feedback fb = new Feedback()
            {
                Keywords = txtKeyword.Text,
                Description = txtDescription.Text,
                assId   = Convert.ToInt32(cboAss.SelectedValue),
                fbTypeId = Convert.ToInt32(cboType.SelectedValue)
            };

            db.Feedbacks.Add(fb);
            db.SaveChanges();
            MessageBox.Show("Feedback Saved");

        }
    }
}
