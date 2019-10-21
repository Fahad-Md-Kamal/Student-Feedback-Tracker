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
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
            pnlBtn.Visible = false;
            
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            PanelformLoader.ServingForm(new frmLogin(), pnlParent);
        }
    }
}
