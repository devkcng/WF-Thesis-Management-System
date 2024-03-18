using System;
using System.Web.UI;
using ComponentFactory.Krypton.Toolkit;

namespace WFThesisManagementSystem.TeacherViews.Views
{
    public partial class FTeacherDashboard : KryptonForm
    {
        public FTeacherDashboard()
        {
            InitializeComponent();
            ucTeacherAllTopics1.Hide();
            
            ucTeacherAllTopics1.btnCreate.Click += createTopic;

        }
        private void createTopic(object sender, EventArgs e)
        {
            ucTeacherAllTopics1.Hide();
            FTeacherCreateTopic fTeacherCreateTopic =  new FTeacherCreateTopic();
            fTeacherCreateTopic.Show();
            
        }

        

        private void ucAllTopics1_Load(object sender, EventArgs e)
        {

        }

        private void task_Click(object sender, EventArgs e)
        {
           // ucAllTopics1.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin fLogin = new FLogin();
            fLogin.Show();
        }

        private void Project_Click(object sender, EventArgs e)
        {
            ucTeacherAllTopics1.Show();
        }
    }
}
