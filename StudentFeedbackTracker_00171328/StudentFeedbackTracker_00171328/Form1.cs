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
            frmSubject frm = new StudentFeedbackTracker_00171328.frmSubject();
            frm.MdiParent = this;
            frm.Show();
        }

        private void allSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectList frm = new StudentFeedbackTracker_00171328.frmSubjectList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Tools.UserType == "STUDENT")
            {
                courseToolStripMenuItem.Visible = false;
                registerUserToolStripMenuItem.Visible = false;
                registerStaffToolStripMenuItem.Visible = false;
                changeUserTypeToolStripMenuItem.Visible = false;
                allUserInformationToolStripMenuItem.Visible = false;
                assessmentTypeToolStripMenuItem.Visible = false;
                allStudentInformationToolStripMenuItem.Visible = false;
                allUserTypeInformationToolStripMenuItem.Visible = false;
                allAssessmentInformationToolStripMenuItem.Visible = false;
                allAssessmentTypesToolStripMenuItem.Visible = false;
                subjectAssessmentToolStripMenuItem.Visible = false;
                allAssessmentSubjectToolStripMenuItem.Visible = false;
                assessmentToolStripMenuItem.Visible = false;
                gradeToolStripMenuItem.Visible = false;
                feedbackToolStripMenuItem.Visible = false;
                feedbackTypeToolStripMenuItem.Visible = false;
                allFeedbacksToolStripMenuItem.Visible = false;
                barChartToolStripMenuItem.Visible = false;
                wordCloudToolStripMenuItem.Visible = false;
            }
            else if (Tools.UserType == "STAFF")
            {

                courseToolStripMenuItem.Visible = false;
                registerUserToolStripMenuItem.Visible = false;
                registerStaffToolStripMenuItem.Visible = false;
                changeUserTypeToolStripMenuItem.Visible = false;
                allUserInformationToolStripMenuItem.Visible = false;
                allUserTypeInformationToolStripMenuItem.Visible = false;
                gradeToolStripMenuItem.Visible = false;
            }

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

        private void allAssessmentTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAssessmentType frm = new frmListAssessmentType();
            frm.MdiParent = this;
            frm.Show();
        }





        private void subjectAssessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSubjectAssessment frm = new frmSubjectAssessment();
            frm.MdiParent = this;
            frm.Show();
        }



        private void allAssessmentSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListSubjectAss frm = new frmListSubjectAss();
            frm.MdiParent = this;
            frm.Show();
        }


        private void assessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssessment frm = new frmAssessment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrade frm = new frmGrade();
            frm.MdiParent = this;
            frm.Show();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFeedback frm = new frmFeedback();
            frm.MdiParent = this;
            frm.Show();
        }


        private void feedbackTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFeedbackType frm = new frmFeedbackType();
            frm.MdiParent = this;
            frm.Show();
        }

        private void allFeedbacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListFeedback frm = new frmListFeedback();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBarChart frm = new frmBarChart();
            frm.MdiParent = this;
            frm.Show();
        }

        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNote frm = new frmNote();
            frm.MdiParent = this;
            frm.Show();
        }

        private void allNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListNote frm = new frmListNote();
            frm.MdiParent = this;
            frm.Show();
        }

        private void wordCloudToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
