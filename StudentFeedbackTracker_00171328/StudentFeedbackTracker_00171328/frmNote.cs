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

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Note nt = new Note();
            nt.Notes = txtNote.Text;
            nt.fbId = Convert.ToInt32(cboFeedback.SelectedValue);
            //nt.uId = Tools.UserId;

            db.Notes.Add(nt);
            db.SaveChanges();

            MessageBox.Show("Note Saved Successfully");
        }
    }
}
