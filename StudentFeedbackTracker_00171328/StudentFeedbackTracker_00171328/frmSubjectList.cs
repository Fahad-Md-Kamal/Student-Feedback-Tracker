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
    public partial class frmSubjectList : Form
    {
        Database1Entities db = new Database1Entities();
        public frmSubjectList()
        {
            InitializeComponent();
        }

        private void frmSubjectList_Load(object sender, EventArgs e)
        {
            LoadSubjectList();
        }

        private void LoadSubjectList()
        {
            var sub = db.Subjects.Select(d =>
                new { SubjectId = d.Id, d.sName, d.Course.cName }).ToList();
            gv.DataSource = sub;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSubjectList();
        }
    }
}
