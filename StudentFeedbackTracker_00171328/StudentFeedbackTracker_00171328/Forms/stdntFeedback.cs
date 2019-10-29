using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbackTracker_00171328.Forms
{
    public partial class stdntFeedback : Form
    {
        Database1Entities db = new Database1Entities();

        public stdntFeedback()
        {
            InitializeComponent();
            LoadData();
        }



        private void LoadData()
        {


            gv.DataSource = db.Feedbacks.Select(d =>
                new {
                    FeedBackID = d.Id,
                    d.Keywords,
                    d.Description,
                    FeedbackType = d.FeedbackType.fType,
                    AssessmentTitle = d.Assessment.assTitle,
                }).ToList();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gv.DataSource = db.Feedbacks.Select(d =>
                new {
                    FeedBackID = d.Id,
                    d.Keywords,
                    d.Description,
                    FeedbackType = d.FeedbackType.fType,
                    AssessmentTitle = d.Assessment.assTitle,
                })
                .Where(x =>
                x.Keywords.Contains(txtSearch.Text.ToLower()) ||
                x.Description.Contains(txtSearch.Text.ToLower())).ToList();
        }
    }
}
