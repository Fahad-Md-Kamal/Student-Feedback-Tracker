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
    public partial class frmStaffRegister : Form
    {

        Database1Entities db = new Database1Entities();
        public frmStaffRegister()
        {
            InitializeComponent();
        }

        private void frmStaffRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            User u = new User();

            u.uName = txtUName.Text;
            u.uPass = txtPass.Text;
            u.typeId = 3;

            db.Users.Add(u);
            db.SaveChanges();

            Staff stf = new Staff();

            stf.fName = txtName.Text;
            stf.Address = txtAddress.Text;
            stf.DOB = dtDOB.Value;
            stf.Email = txtEmail.Text;
            stf.Salary = decimal.Parse( txtSalary.Text);
            stf.uId = u.Id;

            db.Staffs.Add(stf);
            db.SaveChanges();

            MessageBox.Show("Success");
        }
    }
}
