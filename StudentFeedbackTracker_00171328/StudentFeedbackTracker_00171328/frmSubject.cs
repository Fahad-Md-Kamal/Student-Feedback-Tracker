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
    public partial class frmSubject : Form
    {
        Database1Entities db = new Database1Entities();
        public frmSubject()
        {
            InitializeComponent();
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            LoadCourseData();
        }

        private void LoadCourseData()
        {
            var course = db.Courses.ToList();

            cboCourse.DataSource = course;
            cboCourse.DisplayMember = "cName";
            cboCourse.ValueMember = "Id";

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Subject sub = new Subject() {
                sName = txtName.Text,
                cId = Int32.Parse(cboCourse.SelectedValue.ToString())
            };
            db.Subjects.Add(sub);
            db.SaveChanges();

            MessageBox.Show("Data Inserted Successfully ...");

        }
    }
}
