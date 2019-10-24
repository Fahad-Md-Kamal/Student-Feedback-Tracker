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
    public partial class frmListUserType : Form
    {
        Database1Entities db = new Database1Entities();
        public frmListUserType()
        {
            InitializeComponent();
        }

        private void frmListUserType_Load(object sender, EventArgs e)
        {

            LoadUserTypeList();
        }

        private void LoadUserTypeList()
        {
            var ut = db.UserTypes.Select(d =>
                new { UserId = d.Id, d.tName }).ToList();
            gv.DataSource = ut;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUserTypeList();
        }
    }
}
