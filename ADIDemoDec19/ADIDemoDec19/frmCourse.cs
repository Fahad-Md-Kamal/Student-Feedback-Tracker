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
    public partial class frmCourse : Form
    {
        Database1Entities db = new Database1Entities();
        public frmCourse()
        {
            InitializeComponent();
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Course cor = new Course() { cName = txtName.Text };
            db.Courses.Add(cor);
            db.SaveChanges();

            MessageBox.Show("Data Inserted Successfully ...");
        }
    }
}
