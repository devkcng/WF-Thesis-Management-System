using System;
using System.Data;
using System.Windows.Forms;
using WFThesisManagementSystem.DataAccess;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherAllTopics : UserControl
    {
        public UcTeacherAllTopics()
        {
            InitializeComponent();
            
           
        }
        //public UcTeacherAllTopics(object sender,EventArgs e)
        //{
        //    UcTeacherAllTopics_Load(sender,e);
        //}
        private void ListTopic()
        {
            DBConnect dBConnect = new DBConnect();
            DataTable dataTable = dBConnect.LoadData("Topics");
            flpTopicView.Controls.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                UcTeacherSingleTopic singletopic = new UcTeacherSingleTopic();
                Topic topic = new Topic();
                topic.topic_name = row["topic_name"].ToString();
                topic.topic_description = row["topic_description"].ToString();
                //topic.Requirement = row["requirement"].ToString();
                //topic.Category = row["category"].ToString();
                //topic.Technology = row["technology"].ToString();
               // singletopic.Button.Click += edit;
                singletopic.SetTopic(topic);
                flpTopicView.Controls.Add(singletopic);
            }    
            //UcTeacherSingleTopic[]topics = new UcTeacherSingleTopic[dataTable.Rows.Count];
            
            //flpTopicView.Controls.Clear();
            //for (int i = 0; i < topics.Length; i++)
            //{
            //    topics[i] = new UcTeacherSingleTopic();
            //    topics[i].Name = "Kiến thức chuyên ngành";
            //    topics[i].Description = "Khó";
            //    //topics[i].Button.Click += editTopic;
            //    flpTopicView.Controls.Add(topics[i]);
            //}    

        }
        //private void edit(object sender, EventArgs e )
        //{
        //    FTeacherEditTopic fTeacherEditTopic = new FTeacherEditTopic();
        //    fTeacherEditTopic.Show();
        //}
       

        private void ucSingletopic1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void ucTeacherSingleTopic1_Load(object sender, EventArgs e)
        {

        }

        public void UcTeacherAllTopics_Load(object sender, EventArgs e)
        {
            ListTopic();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
           
        }
    }
}
