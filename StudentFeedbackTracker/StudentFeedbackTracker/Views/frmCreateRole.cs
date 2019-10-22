﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbackTracker.Views
{
    public partial class frmCreateRole : Form
    {
        Database1Entities1 db = new Database1Entities1();
        public frmCreateRole()
        {
            InitializeComponent();
            LoadList();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UserRole role = new UserRole() { uRole = txtRoleName.Text};
            db.UserRoles.Add(role);
            db.SaveChanges();
            LoadList();

            MessageBox.Show("Data Inserted Successfully");
        }


        private void LoadList()
        {
            var CList = db.UserRoles.Select(c => new { Id = c.Id, Role = c.uRole }).ToList();
            dgv.DataSource = CList;
        }




    }
}