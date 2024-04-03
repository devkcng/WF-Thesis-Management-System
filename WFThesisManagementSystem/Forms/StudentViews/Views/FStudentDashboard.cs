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
            ucsTudentSubTasks1.Hide();
            ucStudentTask1.Hide();
            ucStudentWorkLogs1.Hide();

        }
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void task_Click(object sender, EventArgs e)
        {
            ucsTudentSubTasks1.Hide();
            ucStudentTask1.Show();
            ucStudentWorkLogs1.Hide();
        }

        private void worklogs_Click(object sender, EventArgs e)
        {
            ucsTudentSubTasks1.Hide();
            ucStudentTask1.Hide();
            ucStudentWorkLogs1.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

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
