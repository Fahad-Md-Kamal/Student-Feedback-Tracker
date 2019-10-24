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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void allCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourseList frm = new frmCourseList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse frm = new frmCourse();
            frm.MdiParent = this;
            frm.Show();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubject frm = new ADIDemoDec19.frmSubject();
            frm.MdiParent = this;
            frm.Show();
        }

        private void allSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectList frm = new ADIDemoDec19.frmSubjectList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (Tools.UserType != "Admin")
            //{
            //    courseToolStripMenuItem.Visible = false;
            //    subjectToolStripMenuItem.Visible = false;
            //}
        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentRegister frm = new frmStudentRegister();
            frm.MdiParent = this;
            frm.Show();
        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaffRegister frm = new frmStaffRegister();
            frm.MdiParent = this;
            frm.Show();
        }

        private void changeUserTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUsertype frm = new frmChangeUsertype();
            frm.MdiParent = this;
            frm.Show();
        }

        private void allUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserList frm = new frmUserList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void changeUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUserInfo frm = new frmChangeUserInfo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void assessmentTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssesmentType frm = new frmAssesmentType();
            frm.MdiParent = this;
            frm.Show();
        }

        private void allStudentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListStudent frm = new frmListStudent();
            frm.MdiParent = this;
            frm.Show();
        }

        private void allStaffInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListStaff frm = new frmListStaff();
            frm.MdiParent = this;
            frm.Show();
        }

        private void allUserTypeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUserType frm = new frmListUserType();
            frm.MdiParent = this;
            frm.Show();
        }

        private void allAssessmentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAssessment frm = new frmListAssessment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void assessmentSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectAssessment frm = new frmSubjectAssessment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void allAssessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssesmentType frm = new frmAssesmentType();
            frm.MdiParent = this;
            frm.Show();
        }

        private void allUserRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserTypeList frm = new frmUserTypeList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void allAssementTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAssessmentType frm = new frmListAssessmentType();
            frm.MdiParent = this;
            frm.Show();
        }

        private void assessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssessment frm = new frmAssessment();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
