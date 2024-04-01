using System;
using System.Windows.Forms;

using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;

namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    public partial class FRegisterTopic : Form
    {
        private Topic _topic;
        StudentRepository _studentRepository;
        StudentGroupRepository _studentGroupRepository;
        RegisterQueueRepository _registerQueue;
        UserSessionHelper _userSessionHelper = UserSessionHelper.Instance;
        public FRegisterTopic(Topic topic)
        {
            InitializeComponent();
            var context = new ThesisManagementContext();
            _studentRepository = new StudentRepository(context);
            _studentGroupRepository = new StudentGroupRepository(context);
            _registerQueue = new RegisterQueueRepository(context);
            this._topic = topic;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text == "")
            {
                MessageBox.Show("Please enter group name");
                return;
            }
            var student = _studentRepository.GetById(_userSessionHelper.UserID);
            RegistrationService registrationService = new
                RegistrationService(student, _topic, txtGroupName.Text);
            if (registrationService.Register())
            {
                MessageBox.Show("Register successfully");
                this.Close();
                FStudentRegisterTopic fStudentRegisterTopic = new FStudentRegisterTopic();
                fStudentRegisterTopic.Show();
            }
            else
            {
                MessageBox.Show("Register failed");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FStudentRegisterTopic fStudentRegisterTopic = new FStudentRegisterTopic();
            fStudentRegisterTopic.Show();
        }

        private void FRegisterTopic_Load(object sender, EventArgs e)
        {
            //Topic information load
            lblTopicName.Text = _topic.topic_name;
            txtDescription.Text = _topic.topic_description;
            lblLoadTechnology.Text = _topic.topic_technology;
            lblLoadRequirement.Text = _topic.topic_requirement;
            lblLoadCategory.Text = _topic.topic_category;
            lblLoadMaxMember.Text = _topic.max_members.ToString();
            lblLoadTeacherName.Text = _topic.Teacher.teacher_name;

            //Load group information
            var studentGroup = _studentGroupRepository.GetByTopicId(_topic.topic_id);
            var registerQueueOfStudent = _registerQueue.GetByGroupId(_topic.topic_id);
            if (studentGroup != null)
            {
                dgvrRegisterMember.Visible = true;
                txtGroupName.Enabled = false;
                txtGroupName.Text = studentGroup.group_name;
                var studentInGroupList = _studentRepository.GetAll();
                foreach (var student in studentInGroupList)
                {
                    if (student.group_id == studentGroup.group_id)
                    {
                        dgvrRegisterMember.Rows.Add(student.student_name, student.student_id);
                    }
                }
            }
            else
            {
                dgvrRegisterMember.Visible = false;
                txtGroupName.Enabled = true;
            }
        }
    }
}
