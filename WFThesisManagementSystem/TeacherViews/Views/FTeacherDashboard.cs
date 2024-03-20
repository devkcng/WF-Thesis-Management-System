using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using ComponentFactory.Krypton.Toolkit;

namespace WFThesisManagementSystem.TeacherViews.Views
{
    public partial class FTeacherDashboard : KryptonForm
    {
        public FTeacherDashboard()
        {
            InitializeComponent();
            ucTeacherAllTopics1.Hide();
            ucTeacherAllTask1.Hide();
            ucTeacherInfor1.Hide();
            ucTeacherEditInfor1.Hide();
            
            ucTeacherAllTopics1.btnCreate.Click += createTopic;
            //foreach(Control control in ucTeacherAllTopics1.flpTopicView.Controls)
            //{
            //    if(control is Button && control.)
            //    {
            //        Button btn = (Button)control;
            //        btn.PerformClick += editTopic;
            //    }    
            //}    
            

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
            ucTeacherAllTopics1.Hide();
            ucTeacherAllTask1.Show();
            ucTeacherEditInfor1.Hide();
            ucTeacherInfor1.Hide();
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
            ucTeacherAllTask1.Hide();
            ucTeacherEditInfor1.Hide();
            ucTeacherInfor1.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ucTeacherAllTopics1.Hide();
            ucTeacherAllTask1.Hide();
            ucTeacherInfor1.Show();
            ucTeacherEditInfor1.Hide();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucTeacherAllTopics1.Hide();
            ucTeacherAllTask1.Hide();
            ucTeacherInfor1.Show();
            ucTeacherEditInfor1.Show();
        }
    }
}
