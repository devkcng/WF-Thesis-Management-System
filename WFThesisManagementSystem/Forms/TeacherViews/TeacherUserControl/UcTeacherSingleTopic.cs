using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;

using WFThesisManagementSystem.Forms.TeacherViews.Views;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl
{
    public partial class UcTeacherSingleTopic : UserControl
    {
        TopicRepository _topicRepository;
        StudentGroupRepository _studentGroupRepository;
        public UcTeacherSingleTopic()
        {
            InitializeComponent();
            var _context = new ThesisManagementContext();
            _topicRepository = new TopicRepository(_context);
            _studentGroupRepository = new StudentGroupRepository(_context);
        }

        private void UcTeacherSingleTopic_Load(object sender, EventArgs e)
        {

        }
        #region Properties
        private string name;
        private string description;
        private Guna2Button button;
        public void SetTopic(Topic topic)
        {
            lblName.Text = topic.topic_name;
            lblDescription.Text = topic.topic_description;
            Name = topic.topic_name;
            Description = topic.topic_description;

        }
        [Category("custom props")]
        public string Name
        {
            get { return name; }
            set { name = value; lblName.Text = value; }

        }
        [Category("custom props")]
        public string Description
        {
            get { return description; }
            set { description = value; lblDescription.Text = value; }
        }
        [Category("custom props")]
        public Guna2Button Button
        {
            get { return button; }
            set { button = value; btnEdit = value; }
        }
        #endregion
        //private void editTopic(object sender, EventArgs e)
        //{
            
        //}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //DBConnect dBConnect = new DBConnect();
            //DataTable dataTable = dBConnect.LoadData("Topics");

            FTeacherEditTopic fTeacherEditTopic = new FTeacherEditTopic();
            fTeacherEditTopic.Show();
            var Table = _topicRepository.GetAll();
            foreach (var topic in Table)
            {

                if (Name == topic.topic_name)
                {
                    fTeacherEditTopic.ucTeacherEditTopic1.txtTopicName.Text = topic.topic_name;
                    fTeacherEditTopic.ucTeacherEditTopic1.txtTopicDescription.Text = topic.topic_description;
                    fTeacherEditTopic.ucTeacherEditTopic1.txtTopicRequirement.Text = topic.topic_requirement;
                    fTeacherEditTopic.ucTeacherEditTopic1.cbxTopicCategory.SelectedItem = topic.topic_category;
                    fTeacherEditTopic.ucTeacherEditTopic1.cbxTopicTechnology.SelectedItem = topic.topic_technology;
                    fTeacherEditTopic.ucTeacherEditTopic1.cbxNumber.SelectedItem = Convert.ToString(topic.max_members);
                    fTeacherEditTopic.ucTeacherEditTopic1.txtTopicId.Text = Convert.ToString(topic.topic_id);
                }
            }
            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    DataRow row = dataTable.Rows[i];
            //    if (Name == row["topic_name"].ToString())
            //    {
            //        fTeacherEditTopic.ucTeacherEditTopic1.txtTopicName.Text = row["topic_name"].ToString();
            //        fTeacherEditTopic.ucTeacherEditTopic1.txtTopicDescription.Text= row["topic_description"].ToString();
            //        fTeacherEditTopic.ucTeacherEditTopic1.txtTopicRequirement.Text= row["topic_requirement"].ToString();
            //        fTeacherEditTopic.ucTeacherEditTopic1.cbxTopicCategory.SelectedItem= row["topic_category"].ToString();
            //        fTeacherEditTopic.ucTeacherEditTopic1.cbxTopicTechnology.SelectedItem = row["topic_technology"].ToString();
            //        fTeacherEditTopic.ucTeacherEditTopic1.cbxNumber.SelectedItem = row["max_members"].ToString();
            //        fTeacherEditTopic.ucTeacherEditTopic1.txtTopicId.Text = row["topic_id"].ToString();
            //        //fTeacherEditTopic.ucTeacherEditTopic1.txtTeacherId.Text = row["teacher_id"].ToString();
            //    }

            //}    

        }

        private void lblName_Click(object sender, EventArgs e)
        {
            var topic = _topicRepository.GetAll().FirstOrDefault(x=>x.topic_name == Name);
            var studentGroup = _studentGroupRepository.GetAll().FirstOrDefault(x=>x.topic_id == topic.topic_id);
            if(studentGroup != null)
            {
                FTeacherRegist fTeacherRegist = new FTeacherRegist(studentGroup);
                fTeacherRegist.Show();
            }
            
            //DBConnect dBConnect = new DBConnect();
            //DataTable dataTableStudentGroup = dBConnect.LoadData("Student_Group");
            //DataTable dataTableTopics = dBConnect.LoadData("Topics");
            //string topicidtmp = "";
            //string groupid = "";
            //for (int i = 0; i < dataTableStudentGroup.Rows.Count; i++)
            //{
            //    DataRow rowStudentGroup = dataTableStudentGroup.Rows[i];
            //    for (int j = 0; j < dataTableTopics.Rows.Count; j++)
            //    {
            //        DataRow rowTopics = dataTableTopics.Rows[j];
            //        if (Name == rowTopics["topic_name"].ToString())
            //        {
            //            topicidtmp = rowTopics["topic_id"].ToString();
            //        }

            //    }
            //    if (topicidtmp == rowStudentGroup["topic_id"].ToString())
            //    {
            //        groupid = rowStudentGroup["group_id"].ToString();
            //        break;
            //    }
            //}
            //FTeacherRegist fTeacherRegist = new FTeacherRegist(groupid);
            //fTeacherRegist.Show();
            //FTeacherRegist fTeacherRegist = new FTeacherRegist();
            //fTeacherRegist.Show();
        }
    }
}
