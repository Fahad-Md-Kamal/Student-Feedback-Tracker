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
    public partial class frmFeedbackType : Form
    {
        Database1Entities db = new Database1Entities();
        public frmFeedbackType()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FeedbackType fdbt = new FeedbackType();
            fdbt.fType = txtType.Text;
            fdbt.Description = txtDescription.Text;

            db.FeedbackTypes.Add(fdbt);
            db.SaveChanges();
            MessageBox.Show("Feedback Type Created Successfully");
        }
    }
}
