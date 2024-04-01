using System;
using System.Data;
using System.Windows.Forms;
using WFThesisManagementSystem.DataAccess;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherAllTopics : UserControl
    {
        private Topic _topic;
        TopicRepository _topicRepository;
        public UcTeacherAllTopics()
        {
            InitializeComponent();
            var _context = new ThesisManagementContext();
            _topicRepository = new TopicRepository(_context);


        }
        //public UcTeacherAllTopics(object sender,EventArgs e)
        //{
        //    UcTeacherAllTopics_Load(sender,e);
        //}
        private void ListTopic()
        {
            //DBConnect dBConnect = new DBConnect();
            //DataTable dataTable = dBConnect.LoadData("Topics");
            var Table = _topicRepository.GetAll();
            flpTopicView.Controls.Clear();
            foreach (var topic in Table)
            {
                _topic = new Topic();
                UcTeacherSingleTopic singletopic = new UcTeacherSingleTopic();
                _topic.topic_name = topic.topic_name;
                _topic.topic_description = topic.topic_description;
                singletopic.SetTopic(_topic);
                flpTopicView.Controls.Add(singletopic);
            }
            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    DataRow row = dataTable.Rows[i];
            //    UcTeacherSingleTopic singletopic = new UcTeacherSingleTopic();
               
            //    _topic.topic_name = row["topic_name"].ToString();
            //    _topic.topic_description = row["topic_description"].ToString();
            //    //topic.Requirement = row["requirement"].ToString();
            //    //topic.Category = row["category"].ToString();
            //    //topic.Technology = row["technology"].ToString();
            //   // singletopic.Button.Click += edit;
            //    singletopic.SetTopic(topic);
            //    flpTopicView.Controls.Add(singletopic);
            //}    
                

        }
      
       

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
