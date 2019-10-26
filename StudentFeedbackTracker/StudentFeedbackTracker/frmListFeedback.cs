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
    public partial class frmListFeedback : Form
    {
        Database1Entities db = new Database1Entities();
        public frmListFeedback()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var data = db.Feedbacks.Select(d => 
                new { FeedBackID = d.Id,
                    AssessmentTitle = d.Assessment.assTitle,
                    d.Keywords,
                    d.Description,
                    FeedbackType = d.FeedbackType.fType,
                    d.assId}).ToList();

            gv.DataSource = data;
        }


    }
}
