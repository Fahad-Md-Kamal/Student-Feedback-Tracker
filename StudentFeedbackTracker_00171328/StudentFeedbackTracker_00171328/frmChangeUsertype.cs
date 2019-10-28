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
    public partial class frmChangeUsertype : Form
    {
        Database1Entities db = new Database1Entities();
        public frmChangeUsertype()
        {
            InitializeComponent();
        }

        private void frmChangeUsertype_Load(object sender, EventArgs e)
        {
            var data = db.UserTypes.ToList();

            cboType.DataSource = data;
            cboType.DisplayMember = "tName";
            cboType.ValueMember = "Id";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int idn = Int32.Parse(txtId.Text);
            var data = db.Users.Where(d => d.Id == idn).FirstOrDefault();
            if (data != null)
            {
                //data.uName = txtUName.Text;
                //data.uPass = txtPass.Text;
                data.typeId = Int32.Parse( cboType.SelectedValue.ToString());

                db.SaveChanges();
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Not Found !!!");
            }
        }

        private void txtId_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int idn = Int32.Parse(txtId.Text);
                var data = db.Users.Where(d => d.Id == idn).FirstOrDefault();
                if (data != null)
                {
                    txtUName.Text = data.uName;
                    txtPass.Text = data.uPass;
                    cboType.SelectedValue = data.typeId;

                }
            }
            catch (Exception)
            {

            }
        }
    }
}
