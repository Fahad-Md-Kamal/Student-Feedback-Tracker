using StudentFeedbackTracker.Controls;
using StudentFeedbackTracker.Helper;
using StudentFeedbackTracker.Views;
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
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            PanelformLoader.ServingForm(new frmStudentsBtns(), pnlbtn);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void addNewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelformLoader.ServingForm(new frmRegistrationForm(), pnlService);
        }

        private void blocUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelformLoader.ServingForm(new frmCreateRole(), pnlService);
        }
    }
}
