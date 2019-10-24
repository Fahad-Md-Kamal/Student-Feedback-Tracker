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
    public partial class frmUserTypeList : Form
    {
        Database1Entities db = new Database1Entities();
        public frmUserTypeList()
        {
            InitializeComponent();
        }

        private void frmUserTypeList_Load(object sender, EventArgs e)
        {
            LoadUserList();
        }

        private void LoadUserList()
        {
            var us = db.UserTypes.Select(d =>
                new { TypeId = d.Id, d.tName }).ToList();
            gv.DataSource = us;
        }
    }
}
