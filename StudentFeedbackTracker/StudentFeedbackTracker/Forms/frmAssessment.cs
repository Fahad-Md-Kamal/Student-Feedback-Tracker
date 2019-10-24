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
    public partial class frmAssessment : Form
    {

        Database1Entities db = new Database1Entities();
        public frmAssessment()
        {
            InitializeComponent();
        }

        private void frmAssessment_Load(object sender, EventArgs e)
        {
            var data = db.Courses.ToList();

            cboCourse.DataSource = data;
            cboCourse.DisplayMember = "cName";
            cboCourse.ValueMember = "Id";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Assessment ass = new Assessment();

            ass.cId = Int32.Parse( cboCourse.SelectedValue.ToString());
           

            db.Assessments.Add(ass);
            db.SaveChanges();

            MessageBox.Show("Success");
        }
    }
}
