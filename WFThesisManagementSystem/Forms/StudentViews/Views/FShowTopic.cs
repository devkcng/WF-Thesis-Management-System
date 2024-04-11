using System;
using System.Windows.Forms;

using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;
using System.Drawing;
using System.Linq; // Thêm dòng này để sử dụng Size

namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    public partial class FShowTopic : Form
    {
        private Topic _topic;
        StudentRepository _studentRepository;
        StudentGroupRepository _studentGroupRepository;
        RegisterQueueRepository _registerQueue;
        UserSessionHelper _userSessionHelper = UserSessionHelper.Instance;
        private ThesisManagementContext _context;
        public FShowTopic(Topic topic, ThesisManagementContext context)
        {
            InitializeComponent();
            this.Size = new Size(600, 600);

            _context = context;
            _studentRepository = new StudentRepository(_context);
            _studentGroupRepository = new StudentGroupRepository(_context);
            _registerQueue = new RegisterQueueRepository(_context);
            this._topic = topic;
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
                lblGroupName.Visible= false;
                txtGroupName.Visible = false;
                dgvrRegisterMember.Visible = false;
                txtGroupName.Enabled = true;
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FStudentRegisterTopic fStudentRegisterTopic = new FStudentRegisterTopic(_context);
            fStudentRegisterTopic.Show();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            var student = _studentRepository.GetById(_userSessionHelper.UserID);
            var studentGroup = _studentGroupRepository.GetByTopicId(_topic.topic_id);
            var registrationService = new RegistrationService(student, _topic, studentGroup.group_name);
            if (registrationService.AlreadyRegistered())
            {
                MessageBox.Show("You have been registered");
                return;
            }
            if (registrationService.InQueue())
            {
                MessageBox.Show("You have been in queue");
                return;
            }
            if (registrationService.Unregistered())
            {
                FTopicRegister fTopicRegister = new FTopicRegister(_topic, _context);
                fTopicRegister.Show();
                this.Close();
            }
            //if (studentGroup == null)
            //{
            //    if (_studentRepository.GetById(_userSessionHelper.UserID).group_id == null && _registerQueue.GetById(_userSessionHelper.UserID) == null)
            //    {
            //        FTopicRegister fTopicRegister = new FTopicRegister(_topic, _context);
            //        fTopicRegister.Show();
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("You have been registered");

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("This topic has been choosed");
            //}

        }
    }
}
