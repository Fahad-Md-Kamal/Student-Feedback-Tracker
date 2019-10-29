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
    public partial class frmFeedbackType : Form
    {
        Database1Entities db = new Database1Entities();
        string msg;

        public frmFeedbackType()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {

            gv.DataSource = db.FeedbackTypes.Select(d =>
                new {
                    ID = d.Id,
                    FeedbackType = d.fType,
                    d.Description,
                }).ToList();

            Helper.SetNullTxtBx(gbx);
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FeedbackType fdbt = new FeedbackType();
            fdbt.fType = txtType.Text;
            fdbt.Description = txtDescription.Text;

            db.FeedbackTypes.Add(fdbt);
            db.SaveChanges();
            MessageBox.Show("Feedback Type Created Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gv.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtType.Text = row.Cells[1].Value.ToString();
                txtDescription.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Helper.CheckNull(gbx))
            {
                MessageBox.Show("Empty Field Found", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Helper.CheckInt(txtId.Text))
            {
                MessageBox.Show("Id Must be Numeric", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(txtId.Text);

                    var feedbackType = db.FeedbackTypes.Where(c => c.Id == id).FirstOrDefault();

                    feedbackType.fType = txtType.Text.ToUpper();
                    feedbackType.Description = txtDescription.Text;
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Data Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    msg = ex.ToString();
                    MessageBox.Show(msg.ToString() , "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
