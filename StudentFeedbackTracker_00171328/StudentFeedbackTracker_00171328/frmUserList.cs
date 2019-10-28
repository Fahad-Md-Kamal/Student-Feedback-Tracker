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
    public partial class frmUserList : Form
    {
        Database1Entities db = new Database1Entities();
        public frmUserList()
        {
            InitializeComponent();
        }

        private void frmUserList_Load(object sender, EventArgs e)
        {
            LoadUserList();
        }

        private void LoadUserList()
        {
            var us = db.Users.Select(d =>
                new { UserId = d.Id, d.uName, d.uPass, d.UserType.tName }).ToList();
            gv.DataSource = us;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUserList();
        }
    }
}
