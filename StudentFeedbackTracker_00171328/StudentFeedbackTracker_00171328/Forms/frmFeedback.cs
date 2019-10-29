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

            gv.DataSource = db.Feedbacks.Select(d =>
                new {
                    FeedBackID = d.Id,
                    d.Keywords,
                    d.Description,
                    FeedbackType = d.FeedbackType.fType,
                    AssessmentTitle = d.Assessment.assTitle,
                }).ToList();

            Helper.SetNullTxtBx(gbxFrm);
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtKeyword.Text))
            {
                MessageBox.Show("Please Enter Some Keyworkds", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please Enter Some Description.", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Feedback fb = new Feedback()
                {
                    Keywords = txtKeyword.Text,
                    Description = txtDescription.Text,
                    assId = Convert.ToInt32(cboAss.SelectedValue),
                    fbTypeId = Convert.ToInt32(cboType.SelectedValue)
                };

                db.Feedbacks.Add(fb);
                db.SaveChanges();
                MessageBox.Show("Feedback Saved Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.ToString(), "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtKeyword.Text))
            {
                MessageBox.Show("Please Enter Some Keyworkds", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please Enter Some Description.", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int idx = Convert.ToInt32(txtId.Text);
                var data = db.Feedbacks.Where(d => d.Id == idx).FirstOrDefault();

                data.Keywords = txtKeyword.Text;
                data.Description = txtDescription.Text;
                data.assId = Convert.ToInt32(cboAss.SelectedValue);
                data.fbTypeId = Convert.ToInt32(cboType.SelectedValue);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Feedback Updated Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() , "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }


        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gv.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtKeyword.Text = row.Cells[1].Value.ToString();
                txtDescription.Text = row.Cells[2].Value.ToString();
                cboType.Text = row.Cells[3].Value.ToString();
                cboAss.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmFeedbackType frm = new frmFeedbackType();
            frm.Show();
        }
    }
}
