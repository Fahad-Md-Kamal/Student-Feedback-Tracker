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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnStaffs_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmStaffRegister(), pnlService);
        }

        private void btnStdntUser_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmStudentRegister(), pnlService);
        }

        private void btnAssessment_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmAssessment(), pnlService);
        }

        private void btnCourseDetail_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmCourse(), pnlService);
        }

        private void btnBarChart_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmBarChart(), pnlService);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Helper.PanelLoader(new frmChangeUsertype(), pnlService);
        }
    }
}
