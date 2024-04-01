using System;
using System.Linq;
using System.Windows.Forms;

using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    public partial class FTeacherEditTopic : Form
    {
        //private readonly TopicDAO topicDAO = new TopicDAO();
        //private readonly DBConnect dbConnect = new DBConnect();
        private Topic _topic;
        TopicRepository _topicRepository;
        TopicService _topicService;
        TeacherAccountRepository _teacherAccountRepository;
        public FTeacherEditTopic()
        {
            InitializeComponent();
            
            var _context = new ThesisManagementContext();
            _topicRepository = new TopicRepository(_context);
            _topicService = new TopicService();
            _topic = new Topic();
            _teacherAccountRepository = new TeacherAccountRepository(_context);
            ucTeacherEditTopic1.btnClose.Click += close;
            ucTeacherEditTopic1.btnUpdate.Click += update;
            ucTeacherEditTopic1.btnDelete.Click += delete;

        }
        private void close(object sender, EventArgs e)
        {
            this.Hide();
        }
       
        private void delete(object sender, EventArgs e)
        {
            //_topic.topic_name = ucTeacherEditTopic1.txtTopicName.Text;
            //_topic.topic_requirement = ucTeacherEditTopic1.txtTopicRequirement.Text;
            //_topic.topic_category = ucTeacherEditTopic1.cbxTopicCategory.SelectedItem.ToString();
            //_topic.topic_technology = ucTeacherEditTopic1.cbxTopicTechnology.SelectedItem.ToString();
            //_topic.topic_description = ucTeacherEditTopic1.txtTopicDescription.Text;
            //_topic.topic_id = int.Parse(ucTeacherEditTopic1.txtTopicId.Text);
            //_topic.max_members = int.Parse(ucTeacherEditTopic1.cbxNumber.SelectedItem.ToString());
            if (_topicService.CheckTopicId(ucTeacherEditTopic1.txtTopicId.Text))
            {
                var topic = _topicRepository.GetById(int.Parse(ucTeacherEditTopic1.txtTopicId.Text));
                _topicRepository.Delete(topic);
                MessageBox.Show("Delete Success");
                this.Hide();
            }
            else MessageBox.Show("Error!!!");
            //Topic topic = new Topic(int.Parse(ucTeacherEditTopic1.txtTopicId.Text), ucTeacherEditTopic1.txtTopicName.Text, ucTeacherEditTopic1.txtTopicDescription.Text, ucTeacherEditTopic1.cbxTopicCategory.SelectedItem.ToString(), ucTeacherEditTopic1.cbxTopicTechnology.SelectedItem.ToString(), ucTeacherEditTopic1.txtTopicRequirement.Text, int.Parse(ucTeacherEditTopic1.cbxNumber.SelectedItem.ToString()));
            ////TopicDAO topicDAO = new TopicDAO();

            //if (dbConnect.ExecuteSqlQuery(topicDAO.DeleteTopic(topic)))
            //{
            //        MessageBox.Show("Delete Success");
            //        this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Error!!!");
            //} 

        }
        private void update(object sender, EventArgs e)
        {
            
            if (_topicService.CheckTopicId(ucTeacherEditTopic1.txtTopicId.Text) && _topicService.CheckMaxMember(ucTeacherEditTopic1.cbxNumber.SelectedItem.ToString()))
            {

                //var teacher = _teacherAccountRepository.GetAll().FirstOrDefault(x => x.teacher_username == UserSessionHelper.Instance.UserName && x.teacher_password == UserSessionHelper.Instance.Password);
                //_topic.teacher_id = teacher.teacher_id;
                
                _topic.topic_name = ucTeacherEditTopic1.txtTopicName.Text;
                _topic.topic_requirement = ucTeacherEditTopic1.txtTopicRequirement.Text;
                _topic.topic_category = ucTeacherEditTopic1.cbxTopicCategory.SelectedItem.ToString();
                _topic.topic_technology = ucTeacherEditTopic1.cbxTopicTechnology.SelectedItem.ToString();
                _topic.topic_description = ucTeacherEditTopic1.txtTopicDescription.Text;
                _topic.topic_id = int.Parse(ucTeacherEditTopic1.txtTopicId.Text);
                _topic.max_members = int.Parse(ucTeacherEditTopic1.cbxNumber.SelectedItem.ToString());
                var teacher = _teacherAccountRepository.GetAll().FirstOrDefault(x => x.teacher_username == UserSessionHelper.Instance.UserName && x.teacher_password == UserSessionHelper.Instance.Password);
                _topic.teacher_id = teacher.teacher_id;
                _topicService = new TopicService(_topic);
                if (_topicService.AlreadyCreateTopic())
                {
                    _topicRepository.Update(_topic);
                    MessageBox.Show("Update Success");
                    this.Hide();
                }
                else MessageBox.Show("Error!!!");
            }
            else MessageBox.Show("Error!!!");
            //if (ucTeacherEditTopic1.txtTopicId.Text != "" && ucTeacherEditTopic1.txtTopicId.Text != "" && ucTeacherEditTopic1.txtTopicName.Text != "" && ucTeacherEditTopic1.txtTopicDescription.Text != "" && ucTeacherEditTopic1.cbxTopicCategory.SelectedItem.ToString() != "" && ucTeacherEditTopic1.cbxTopicTechnology.SelectedItem.ToString() != "" && ucTeacherEditTopic1.txtTopicRequirement.Text != "" && ucTeacherEditTopic1.cbxNumber.SelectedItem.ToString() != "")
            //{
            //    for (int i = 0; i <= ucTeacherEditTopic1.txtTopicId.Text.Length - 1; i++)
            //    {
            //        if (ucTeacherEditTopic1.txtTopicId.Text[i] > '9' || ucTeacherEditTopic1.txtTopicId.Text[i] < '0')
            //        {
            //            MessageBox.Show("Error!!!");
            //            return;
            //        }
            //    }
            //    Topic topic = new Topic(int.Parse(ucTeacherEditTopic1.txtTopicId.Text), ucTeacherEditTopic1.txtTopicName.Text, ucTeacherEditTopic1.txtTopicDescription.Text, ucTeacherEditTopic1.cbxTopicCategory.SelectedItem.ToString(), ucTeacherEditTopic1.cbxTopicTechnology.SelectedItem.ToString(), ucTeacherEditTopic1.txtTopicRequirement.Text, int.Parse(ucTeacherEditTopic1.cbxNumber.SelectedItem.ToString()));
            //    //TopicDAO topicDAO = new TopicDAO();
            //    if (topicDAO.CheckData(topic))
            //    {
            //        if (dbConnect.ExecuteSqlQuery(topicDAO.UpdateTopic(topic)))
            //        {
            //            MessageBox.Show("Update Success");
            //            this.Hide();
            //            //UcTeacherAllTopics ucTeacherAllTopics = new UcTeacherAllTopics();
            //            //UcTeacherAllTopics_Load(sender, e);
            //            //FTeacherDashboard fTeacherDashboard = new FTeacherDashboard();
            //            //fTeacherDashboard_Load(sender, e);
            //            //FTeacherCreateTopic_Load(sender, e);
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Error!!!");
            //}
        }
    }
}
