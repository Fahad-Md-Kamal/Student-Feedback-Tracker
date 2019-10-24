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
    public partial class frmCourse : Form
    {
        Database1Entities db = new Database1Entities();
        public frmCourse()
        {
            InitializeComponent();
            LoadList();

            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnReset.Visible = false;
            btnInsert.Visible = true;
            txtCourseID.Visible = false;
            label1.Visible = false;
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Course cor = new Course() { cName = txtName.Text };
            db.Courses.Add(cor);
            db.SaveChanges();
            LoadList();

            MessageBox.Show("Data Inserted Successfully ...");
        }


        private void LoadList()
        {
            var clist = db.Courses.Select(d =>
                new { CourseId = d.Id, d.cName }).ToList();
            gv.DataSource = clist;
            txtCourseID.Text = "";
            txtName.Text = "";
        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                DataGridViewRow row = gv.Rows[e.RowIndex];
                txtCourseID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                btnReset.Visible = true;
                btnInsert.Visible = false;

                txtCourseID.Visible = true;
                label1.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idn = Int32.Parse(txtCourseID.Text);
            var data = db.Courses.Where(d => d.Id == idn).FirstOrDefault();
            if(txtName.Text != "")
            {
                data.cName = txtName.Text;
                db.SaveChanges();
                LoadList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int idn = Int32.Parse(txtCourseID.Text);
            var data = db.Courses.Where(d => d.Id == idn).FirstOrDefault();
            if (data != null)
            {
                db.Courses.Remove(data);
                db.SaveChanges();
                LoadList();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            LoadList();

            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnInsert.Visible = true;
            btnReset.Visible = false;
            txtCourseID.Visible = false;
            label1.Visible = false;
        }
    }
}
