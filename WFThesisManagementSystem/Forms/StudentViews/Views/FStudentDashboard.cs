using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl;
using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;
using UserControl = System.Windows.Forms.UserControl;

namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    public partial class FStudentDashboard : KryptonForm
    {

        public FStudentDashboard()
        {
            InitializeComponent();

        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UCStudentProject uc = new UCStudentProject(student.student_id);
            //addUserControl(uc);
        }

        private void task_Click(object sender, EventArgs e)
        {
            UCStudentTask uc = new UCStudentTask();
            addUserControl(uc);
        }

        private void worklogs_Click(object sender, EventArgs e)
        {
            UCStudentWorkLogs uc = new UCStudentWorkLogs();
            addUserControl(uc);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UcTeacherInfor uc = new UcTeacherInfor();
            addUserControl(uc);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            fLogin.Show();
            this.Close();
        }

        private void performance_Click(object sender, EventArgs e)
        {

        }



    }
}
