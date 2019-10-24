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


            LoadUserList();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int idn = Int32.Parse(txtId.Text);
            var data = db.Users.Where(d => d.Id == idn).FirstOrDefault();
            if (data != null)
            {
                data.typeId = Int32.Parse( cboType.SelectedValue.ToString());

                db.SaveChanges();
                MessageBox.Show("Success");
                LoadUserList();
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




        private void LoadUserList()
        {
            dgv.DataSource = db.Users.Select(d => 
            new { ID = d.Id, Username = d.uName, Password = d.uPass, Role = d.UserType.tName }).ToList();

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];

                txtId.Text = row.Cells[0].Value.ToString();
                txtUName.Text = row.Cells[1].Value.ToString();
                txtPass.Text = row.Cells[2].Value.ToString();
                cboType.Text = row.Cells[3].Value.ToString();
            }


    
        }
    }

}
