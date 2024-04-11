using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Helper.SearchEngineHelper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using System.Drawing; // Thêm dòng này để sử dụng Size

namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    public partial class FStudentRegisterTopic : Form
    {
        private StudentRepository _studentRepository;
        private StudentGroupRepository _studentGroupRepository;
        private readonly TopicRepository _topicRepository;
        private ThesisManagementContext _context;
        public FStudentRegisterTopic(ThesisManagementContext context)
        {

            InitializeComponent();
            this.Size = new Size(750,500);

            _context = context;
            _studentRepository = new StudentRepository(_context);
            _studentGroupRepository = new StudentGroupRepository(_context);
            _topicRepository = new TopicRepository(_context);
        }

        private void dgvTopics_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvTopics.Rows[e.RowIndex];
                    var topicId = Convert.ToInt32(row.Cells["topic_id"].Value);
                    var topic = _topicRepository.GetById(topicId);
                    FShowTopic fRegisterTopic = new FShowTopic(topic, _context);
                    fRegisterTopic.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = txtDescribe.Text;
            var searchEngine = new TFIDF();
            if (query != null)
            {
                List<Document> searchResults = searchEngine.Search(query);
                dgvTopics.Rows.Clear();
                foreach (var document in searchResults)
                {
                    // Add a row to the DataGridView for each document
                    dgvTopics.Rows.Add(
                        document.TopicId,
                        document.TopicName,
                        document.TopicDescription,
                        document.TopicTechnology,
                        document.TopicRequirement,
                        document.TopicCategory,
                        document.TopicMaxMembers,
                        document.TeacherName
                    );
                }
            }
            else
            {
                dgvTopics.Rows.Clear();
                FStudentRegisterTopic_Load(sender, e);
            }

        }

        private void ptbReload_Click(object sender, EventArgs e)
        {
            dgvTopics.Rows.Clear();
            FStudentRegisterTopic_Load(sender, e);
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            FStudentDashboard fStudentDashboard = new FStudentDashboard();
            fStudentDashboard.Show();
            this.Close();
        }

        private void FStudentRegisterTopic_Load(object sender, EventArgs e)
        {
            dgvTopics.Rows.Clear();
            var topics = _topicRepository.GetAll();
            foreach (var topic in topics)
            {
                dgvTopics.Rows.Add(
                    topic.topic_id,
                    topic.topic_name,
                    topic.topic_description,
                    topic.topic_technology,
                    topic.topic_requirement,
                    topic.topic_category,
                    topic.max_members,
                    topic.Teacher.teacher_name
                );
            }
        }
    }
}
