using StudentFeedbackTracker_00171328.Forms;
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
    public partial class frmLogin : Form
    {
        Database1Entities db = new Database1Entities();
        public frmLogin()
        {
            InitializeComponent();
            this.Text = "User Login";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            var data = db.Users.Where(d => d.uName == txtName.Text && 
                d.uPass == txtPass.Text).FirstOrDefault();
            if (data != null)
            {
                Tools.UserType = data.UserType.tName;
                Tools.UserId = data.Id;
                Tools.UserName = data.uName;

                this.Hide();
                frmAdmin frm = new frmAdmin();
                frm.Text = "Welcome " + Tools.UserType;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sorry, Invalid User Name OR Password !!!");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
