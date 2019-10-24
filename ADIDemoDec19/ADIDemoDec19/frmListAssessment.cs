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
    public partial class frmListAssessment : Form
    {
        Database1Entities db = new Database1Entities();
        public frmListAssessment()
        {
            InitializeComponent();
        }

        private void frmListAssessment_Load(object sender, EventArgs e)
        {

            LoadAssList();
        }

        private void LoadAssList()
        {
            var stf = db.Assessments.Select(d =>
                new { d.Id, d.assDate, d.Course.cName, d.User.uName, d.mark }).ToList();
            gv.DataSource = stf;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAssList();
        }
    }
}
