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

        private void btnUser_Click(object sender, EventArgs e)
        {
            PanelFormLoader.ServingForm(new frmStaffRegister(), pnlService);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnStdntUser_Click(object sender, EventArgs e)
        {
            PanelFormLoader.ServingForm(new frmStudentRegister(), pnlService);
        }

        private void btnAssessment_Click(object sender, EventArgs e)
        {
            PanelFormLoader.ServingForm(new frmAssessment(), pnlService);
        }
    }
}
