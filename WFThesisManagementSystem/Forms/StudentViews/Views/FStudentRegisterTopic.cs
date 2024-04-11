using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Helper.SearchEngineHelper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using System.Drawing;
using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl; // Thêm dòng này để sử dụng Size

namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    public partial class FStudentRegisterTopic : Form
    {
        private StudentRepository _studentRepository;
        private StudentGroupRepository _studentGroupRepository;
        private TeacherRepository _teacherRepository;
        private readonly TopicRepository _topicRepository;
        private ThesisManagementContext _context;
        public FStudentRegisterTopic(ThesisManagementContext context)
        {

            InitializeComponent();
            this.Size = new Size(800,700);

            _context = context;
            _studentRepository = new StudentRepository(_context);
            _studentGroupRepository = new StudentGroupRepository(_context);
            _teacherRepository= new TeacherRepository(_context);
            _topicRepository = new TopicRepository(_context);
        }

        


        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    var query = txtDescribe.Text;
        //    var searchEngine = new TFIDF();
        //    if (query != null)
        //    {
        //        List<Document> searchResults = searchEngine.Search(query);
        //        dgvTopics.Rows.Clear();
        //        foreach (var document in searchResults)
        //        {
        //            // Add a row to the DataGridView for each document
        //            dgvTopics.Rows.Add(
        //                document.TopicId,
        //                document.TopicName,
        //                document.TopicDescription,
        //                document.TopicTechnology,
        //                document.TopicRequirement,
        //                document.TopicCategory,
        //                document.TopicMaxMembers,
        //                document.TeacherName
        //            );
        //        }
        //    }
        //    else
        //    {
        //        dgvTopics.Rows.Clear();
        //        FStudentRegisterTopic_Load(sender, e);
        //    }

        //}

        //private void ptbReload_Click(object sender, EventArgs e)
        //{
        //    dgvTopics.Rows.Clear();
        //    FStudentRegisterTopic_Load(sender, e);
        //}

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            FStudentDashboard fStudentDashboard = new FStudentDashboard();
            fStudentDashboard.Show();
            this.Close();
        }

        private void FStudentRegisterTopic_Load(object sender, EventArgs e)
        {
            var topics = _topicRepository.GetAll();
            flpAllTopics.Controls.Clear();
            foreach (var topic in topics)
            {
                UCTopic uCTopic = new UCTopic();
                uCTopic.Name = topic.topic_name;
                uCTopic.Id = topic.topic_id;
                uCTopic.Description = topic.topic_description;
                uCTopic.Technology = topic.topic_technology;
                uCTopic.Requirement = topic.topic_requirement;
                uCTopic.Category = topic.topic_category;
                uCTopic.MaxMember = topic.max_members.Value;
                uCTopic.TeacherName = _teacherRepository.GetById(topic.teacher_id.Value).teacher_name;
                uCTopic.TeacherId = topic.teacher_id.Value;
                uCTopic.Clicked += UCTopic_Clicked;
                flpAllTopics.Controls.Add(uCTopic);
            }
        }

        #region ucTask-Events

        // when click on a Group task -> show subtask 

        private void UCTopic_Clicked(object sender, EventArgs e)
        { 
            UCTopic uCTopic = sender as UCTopic;
            this.Close();
            Topic topic =new Topic();
            FShowTopic fShowTopic = new FShowTopic(_topicRepository.GetById(uCTopic.Id), _context);
            fShowTopic.Show();
        }

        #endregion
    }
}
