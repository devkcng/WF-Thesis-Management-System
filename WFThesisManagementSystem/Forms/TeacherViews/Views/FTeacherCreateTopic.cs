using System;
using System.Linq;
using System.Windows.Forms;

using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    public partial class FTeacherCreateTopic : Form
    {
        private Topic _topic;
        TopicRepository _topicRepository;
        TeacherAccountRepository _teacherAccountRepository;
        TopicService _topicService;



        //private readonly TopicDAO topicDAO = new TopicDAO();
        //private readonly DBConnect dbConnect = new DBConnect();
        public FTeacherCreateTopic()
        {
            InitializeComponent();
            var _context = new ThesisManagementContext();
            _topicRepository = new TopicRepository(_context);
            _topicService = new TopicService();
            _topic = new Topic();
            _teacherAccountRepository = new TeacherAccountRepository(_context);
            ucTeacherCreateTopic1.btnSave.Click += Save;
            ucTeacherCreateTopic1.btnClear.Click += Clear;
        }
        private void Save(object sender, EventArgs e)
        {
            if (_topicService.CheckTopicId(ucTeacherCreateTopic1.txtTopicId.Text) && _topicService.CheckMaxMember(ucTeacherCreateTopic1.cbxNumber.SelectedItem.ToString()))
            {
                _topic.topic_id = int.Parse(ucTeacherCreateTopic1.txtTopicId.Text);
                _topic.topic_name = ucTeacherCreateTopic1.txtTopicName.Text;
                _topic.topic_requirement = ucTeacherCreateTopic1.txtTopicRequirement.Text;
                _topic.topic_category = ucTeacherCreateTopic1.cbxTopicCategory.SelectedItem.ToString();
                _topic.topic_technology = ucTeacherCreateTopic1.cbxTopicTechnology.SelectedItem.ToString();
                _topic.topic_description = ucTeacherCreateTopic1.txtTopicDescription.Text;
                _topic.max_members = int.Parse(ucTeacherCreateTopic1.cbxNumber.SelectedItem.ToString());
                var teacher = _teacherAccountRepository.GetAll().FirstOrDefault(x => x.teacher_username == UserSessionHelper.Instance.UserName && x.teacher_password == UserSessionHelper.Instance.Password);
                _topic.teacher_id = teacher.teacher_id;
                _topicService = new TopicService(_topic);
                if (_topicService.AlreadyCreateTopic())
                {
                    _topicRepository.Add(_topic);
                    MessageBox.Show("Add Success");
                    this.Hide();
                }
                else MessageBox.Show("Error!!!");
            }
            else MessageBox.Show("Error!!!");


            //if (ucTeacherCreateTopic1.txtTopicId.Text!="" && ucTeacherCreateTopic1.txtTopicId.Text!=""&& ucTeacherCreateTopic1.txtTopicName.Text!=""&& ucTeacherCreateTopic1.txtTopicDescription.Text!=""&& ucTeacherCreateTopic1.cbxTopicCategory.SelectedItem.ToString()!=""&& ucTeacherCreateTopic1.cbxTopicTechnology.SelectedItem.ToString()!=""&&ucTeacherCreateTopic1.txtTopicRequirement.Text!=""&& ucTeacherCreateTopic1.cbxNumber.SelectedItem.ToString()!="")
            //{
            //    for (int i = 0; i <= ucTeacherCreateTopic1.txtTopicId.Text.Length - 1; i++)
            //    {
            //        if (ucTeacherCreateTopic1.txtTopicId.Text[i] > '9' || ucTeacherCreateTopic1.txtTopicId.Text[i] < '0')
            //        {
            //            MessageBox.Show("Error!!!");
            //            return;
            //        }
            //    }
            //     _topic = new Topic(int.Parse(ucTeacherCreateTopic1.txtTopicId.Text), ucTeacherCreateTopic1.txtTopicName.Text, ucTeacherCreateTopic1.txtTopicDescription.Text, ucTeacherCreateTopic1.cbxTopicCategory.SelectedItem.ToString(), ucTeacherCreateTopic1.cbxTopicTechnology.SelectedItem.ToString(), ucTeacherCreateTopic1.txtTopicRequirement.Text, int.Parse(ucTeacherCreateTopic1.cbxNumber.SelectedItem.ToString()));
            //    DBConnect dBConnect = new DBConnect();
            //    DataTable dataTable = dBConnect.LoadData("TeacherAccount");
            //    for(int i = 0; i < dataTable.Rows.Count; i++)
            //    {
            //        DataRow row = dataTable.Rows[i];
            //        if(UserSessionHelper.Instance.UserName == row["teacher_username"].ToString() && UserSessionHelper.Instance.Password == row["teacher_password"].ToString())
            //        {
            //            topic.teacher_id = int.Parse(row["teacher_id"].ToString());
            //            break;
            //        }    
            //    }    
            //    //TopicDAO topicDAO = new TopicDAO();
            //    if (topicDAO.CheckData(topic))
            //    {
            //        if (dbConnect.ExecuteSqlQuery(topicDAO.AddTopic(topic)))
            //        {
            //            //UcTeacherAllTopics ucTeacherAllTopics = new UcTeacherAllTopics();
            //            //ucTeacherAllTopics.UcTeacherAllTopics_Load(sender, e);
            //            MessageBox.Show("Add Success");
            //            this.Hide();


            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Error!!!");
            //} 


        }
        private void Clear(object sender, EventArgs e)
        {
            ucTeacherCreateTopic1.txtTopicRequirement.Clear();
            ucTeacherCreateTopic1.txtTopicDescription.Clear();
            ucTeacherCreateTopic1.txtTopicName.Clear();
            ucTeacherCreateTopic1.txtTopicId.Clear();
            //ucTeacherCreateTopic1.cbxNumber.

        }
        private void FTeacherCreateTopic_Load(object sender, EventArgs e)
        {

        }
    }
}
