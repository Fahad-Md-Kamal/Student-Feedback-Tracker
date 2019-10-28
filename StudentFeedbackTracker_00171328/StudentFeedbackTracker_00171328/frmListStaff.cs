using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbackTracker_00171328
{
    public partial class frmListStaff : Form
    {
        Database1Entities db = new Database1Entities();
        public frmListStaff()
        {
            InitializeComponent();
        }

        private void frmListStaff_Load(object sender, EventArgs e)
        {

            LoadStaffList();
        }

        private void LoadStaffList()
        {
            var stf = db.Staffs.Select(d =>
                new { StaffId = d.Id, d.fName, d.Address, d.Email, d.Salary }).ToList();
            gv.DataSource = stf;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStaffList();
        }
    }
}
