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
    public partial class frmListAssessmentType : Form
    {
        Database1Entities db = new Database1Entities();
        public frmListAssessmentType()
        {
            InitializeComponent();
        }

        private void frmListAssessmentType_Load(object sender, EventArgs e)
        {

            LoadAssTypeList();
        }

        private void LoadAssTypeList()
        {
            var asstype = db.AssessmentTypes.Select(d =>
                new { UserId = d.Id, d.assType, d.Mark }).ToList();
            gv.DataSource = asstype;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAssTypeList();
        }
    }
}
