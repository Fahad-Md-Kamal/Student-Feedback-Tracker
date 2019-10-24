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
    public partial class frmListSubjectAss : Form
    {
        Database1Entities db = new Database1Entities();
        public frmListSubjectAss()
        {
            InitializeComponent();
        }

        private void frmListSubjectAss_Load(object sender, EventArgs e)
        {

            LoadSubjectAssList();
        }

        private void LoadSubjectAssList()
        {
            var subass = db.SubjectAssessments.Select(d =>
                new { d.Id, d.Subject.sName, d.asId }).ToList();
            gv.DataSource = subass;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSubjectAssList();
        }
    }
}
