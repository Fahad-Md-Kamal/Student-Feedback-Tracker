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
    public partial class frmChangeUserInfo : Form
    {

        Database1Entities db = new Database1Entities();
        public frmChangeUserInfo()
        {
            InitializeComponent();

            lblPageFitle.Text = Tools.UserName;

        }

        private void frmChangeUserInfo_Load(object sender, EventArgs e)
        {
            var data = db.Users.Where(d => d.Id == Tools.UserId).FirstOrDefault();

            txtId.Text = data.Id.ToString();
            txtUName.Text = data.uName;
            txtPass.Text = data.uPass;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            var data = db.Users.Where(d => d.Id == Tools.UserId).FirstOrDefault();
            if (data != null)
            {
                
                data.uPass = txtPass.Text;
            
                db.SaveChanges();
                MessageBox.Show("Password Changed Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Not Found !!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
