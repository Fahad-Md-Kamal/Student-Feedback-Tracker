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
    public partial class frmAssesmentType : Form
    {
        Database1Entities db = new Database1Entities();
        public frmAssesmentType()
        {
            InitializeComponent();
        }

        private void frmAssesmentType_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            AssessmentType at = new AssessmentType();

            at.assType = txtName.Text;
            at.Mark = Int32.Parse( txtMarks.Text);

            db.AssessmentTypes.Add(at);
            db.SaveChanges();

            MessageBox.Show("Data Inserted Successfully ...");
        }
    }
}
