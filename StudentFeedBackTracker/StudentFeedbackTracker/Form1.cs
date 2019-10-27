using StudentFeedbackTracker.Forms;
using StudentFeedbackTracker.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbackTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Helpers.ServingForm(new frmUserRegister(), pnlService);
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            Helpers.ServingForm(new frmCourse(), pnlService);
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {

        }

        private void btnAssessment_Click(object sender, EventArgs e)
        {

        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {

        }

        private void btnWordCloud_Click(object sender, EventArgs e)
        {

        }

        private void btnBarchart_Click(object sender, EventArgs e)
        {

        }
    }
}
