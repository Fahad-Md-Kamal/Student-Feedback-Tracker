using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbackTracker.Forms
{
    public partial class UserRegister : Form
    {
        Database1Entities1 db = new Database1Entities1();

        public UserRegister()
        {
            InitializeComponent();
        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            //var Roles = db.UserRoles.Select(d =>
            //new { RoleId = d.Id, Role = d.uRole }).ToList();  

            cmbUserRole.DataSource = db.UserRoles.ToList();
            cmbUserRole.DisplayMember = "uRole";
            cmbUserRole.ValueMember = "Id";
            dataGridView1.DataSource = db.UserRoles.Select(d => new { RoleId = d.Id, Role = d.uRole }).ToList();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {

            UserRole role = new UserRole() { uRole = cmbUserRole.SelectedValue.ToString() };

            db.UserRoles.Add(role);
            db.SaveChanges();

            MessageBox.Show("Data Saved");

            dataGridView1.DataSource = db.UserRoles.Select(d => new { RoleId = d.Id, Role = d.uRole }).ToList();

        }
    }
}
