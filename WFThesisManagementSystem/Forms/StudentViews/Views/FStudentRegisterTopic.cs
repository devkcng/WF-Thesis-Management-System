using System;
using System.Drawing;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services; // Thêm dòng này để sử dụng Size

namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    public partial class FStudentRegisterTopic : Form
    {
        private StudentRepository _studentRepository;
        private StudentGroupRepository _studentGroupRepository;
        private TeacherRepository _teacherRepository;
        private readonly TopicRepository _topicRepository;
        private RegistrationService _registrationService;
        private RegisterQueueRepository _registerQueueRepository;
        UserSessionHelper _userSessionHelper = UserSessionHelper.Instance;

        private ThesisManagementContext _context;
        public FStudentRegisterTopic(ThesisManagementContext context)
        {

            InitializeComponent();
            this.Size = new Size(800, 700);

            _context = context;
            _studentRepository = new StudentRepository(_context);
            _studentGroupRepository = new StudentGroupRepository(_context);
            _teacherRepository = new TeacherRepository(_context);
            _topicRepository = new TopicRepository(_context);
            _registerQueueRepository = new RegisterQueueRepository(_context);
            _registrationService = new RegistrationService(_studentRepository.GetById(_userSessionHelper.UserID), _context);

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
            this.Hide();
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

                uCTopic.Margin = new Padding(0, 0, 0, 20); // Adjust the last parameter to control vertical spacing

                if (!_registrationService.Unregistered())
                {

                    if (_registrationService.AlreadyRegistered())
                    {
                        var studentGroup = _studentGroupRepository.GetById(_studentRepository.GetById(_userSessionHelper.UserID).group_id.Value);
                        if (studentGroup.topic_id == uCTopic.Id)
                        {
                            uCTopic.ptbStatus.Image = Properties.Resources.accepted_picture;
                            uCTopic.lblStatus.Visible = true;
                            uCTopic.ptbStatus.Visible = true;
                        }
                    }
                    else if (_registrationService.InQueue() && _registerQueueRepository.GetById(_userSessionHelper.UserID).topic_id == uCTopic.Id)
                    {
                        uCTopic.ptbStatus.Image = Properties.Resources.pending_picture;
                        uCTopic.lblStatus.Visible = true;
                        uCTopic.ptbStatus.Visible = true;
                    }
                }
                else
                {

                }
                flpAllTopics.Controls.Add(uCTopic);
            }
        }

        #region ucTask-Events

        // when click on a Group task -> show subtask 

        private void UCTopic_Clicked(object sender, EventArgs e)
        {
            UCTopic uCTopic = sender as UCTopic;
            this.Hide();
            Topic topic = new Topic();
            FShowTopic fShowTopic = new FShowTopic(_topicRepository.GetById(uCTopic.Id), _context);
            fShowTopic.Show();
        }

        #endregion

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Check if the reason for closing is the user clicking the close button
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancel the form closing event
                    return;
                }
                Application.Exit();
            }
        }
    }
}
