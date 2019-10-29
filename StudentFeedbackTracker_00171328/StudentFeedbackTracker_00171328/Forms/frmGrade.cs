﻿using System;
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
    public partial class frmGrade : Form
    {
        Database1Entities db = new Database1Entities();
        public frmGrade()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Grade grd = new Grade()
            {
                gradeSign = txtGrade.Text,
                maxMark = int.Parse( txtMaxMarks.Text),
                minMark = int.Parse( txtMinMarks.Text)
            };
            db.Grades.Add(grd);
            db.SaveChanges();

            MessageBox.Show("Data Inserted Successfully ...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Dispose();
        }
    }
}