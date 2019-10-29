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
    public partial class frmNote : Form
    {

        Database1Entities db = new Database1Entities();

        public frmNote()
        {
            InitializeComponent();
            lblNoteOwner.Text = Tools.UserName;
            LoadData();
        }

        void LoadData()
        {
            var feedback = db.Feedbacks.ToList();
            cboFeedback.DataSource = feedback;
            cboFeedback.DisplayMember = "keywords";
            cboFeedback.ValueMember = "Id";

            gv.DataSource = db.Notes.Where(d => d.uId == Tools.UserId).Select(d => 
            new { d.Id, Note = d.Notes, Keywor = d.Feedback.Keywords }).ToList();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNote.Text))
            {
                MessageBox.Show("Note Field is Empty", "ERROR !!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Note nt = new Note
                {
                    Notes = txtNote.Text,
                    fbId = Convert.ToInt32(cboFeedback.SelectedValue),
                    uId = Tools.UserId
                };

            db.Notes.Add(nt);
                db.SaveChanges();
                LoadData();

                MessageBox.Show("Note Saved Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR !!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNote.Text))
            {
                MessageBox.Show("Note Field is Empty", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int idx = Convert.ToInt32(txtId.Text);

                var data = db.Notes.Where(d => d.Id == idx).FirstOrDefault();
                data.Notes = txtNote.Text;

                db.SaveChanges();
                LoadData();

                MessageBox.Show("Note Updated Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = Convert.ToInt32(txtId.Text);
                var data = db.Notes.Where(d => d.Id == idx).FirstOrDefault();
                db.Notes.Remove(data);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Note Deleted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = gv.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtNote.Text = row.Cells[1].Value.ToString();
                cboFeedback.Text = row.Cells[2].Value.ToString();


                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                txtId.Visible = true;
                lblId.Visible = true;
            }
        }
    }
}
