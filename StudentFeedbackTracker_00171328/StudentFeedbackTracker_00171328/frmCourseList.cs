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
    public partial class frmCourseList : Form
    {
        Database1Entities db = new Database1Entities();
        public frmCourseList()
        {
            InitializeComponent();
        }

        private void frmCourseList_Load(object sender, EventArgs e)
        {
            LoadCourseList();
        }

        private void LoadCourseList()
        {
            var clist = db.Courses.Select(d => 
                new { CourseId = d.Id, d.cName }).ToList();
            gv.DataSource = clist;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCourseList();
        }
    }
}
