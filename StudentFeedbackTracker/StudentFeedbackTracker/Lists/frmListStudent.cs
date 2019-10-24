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
    public partial class frmListStudent : Form
    {
        Database1Entities db = new Database1Entities();
        public frmListStudent()
        {
            InitializeComponent();
        }

        private void frmListStudent_Load(object sender, EventArgs e)
        {

            LoadStudentList();
        }

        private void LoadStudentList()
        {
            var clist = db.Students.Select(d =>
                new { StudentId = d.Id, d.fName, d.Address, d.Email, d.Course.cName }).ToList();
            gv.DataSource = clist;
        }
    }
}
