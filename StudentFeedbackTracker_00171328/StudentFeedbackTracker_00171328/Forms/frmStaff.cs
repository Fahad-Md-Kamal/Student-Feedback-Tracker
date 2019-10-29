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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
            lblUserType.Text = Tools.UserName + Environment.NewLine + Tools.UserType;
        }

        private void btnCourseDetail_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmCourse(), pnlService);
        }

        private void btnSubjectAss_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmSubjectAssessment(), pnlService);
        }

        private void btnAssessment_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmAssessment(), pnlService);
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmFeedback(), pnlService);
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmNote(), pnlService);
        }

        private void btnWordCloud_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmWordCloud(), pnlService);

        }

        private void btnBarChart_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmBarChart(), pnlService);
        }
    }
}
