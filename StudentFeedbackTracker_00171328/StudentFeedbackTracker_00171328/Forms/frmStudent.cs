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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
            this.lblUserType.Text = Tools.UserName + Environment.NewLine + Tools.UserType;
        }

        
        private void btnAssessment_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmAssessment(), pnlService);
        }
        

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmFeedback(), pnlService);
        }

        private void lblUserType_Click(object sender, EventArgs e)
        {
            frmChangeUserInfo frm = new frmChangeUserInfo();
            frm.Show();
        }

        private void btnNote_Click_1(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmNote(), pnlService);
        }


        private void btnAllFeedback_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new stdntFeedback(), pnlService);
        }

        private void btnAssessmentsDtl_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new stdntAssessDtl(), pnlService);
        }

    }
}
