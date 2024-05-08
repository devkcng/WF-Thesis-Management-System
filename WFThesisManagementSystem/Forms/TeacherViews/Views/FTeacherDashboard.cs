using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl;
using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    public partial class FTeacherDashboard : KryptonForm
    {
        ThesisManagementContext _context;
        StudentGroupRepository _studentGroupRepository;
        TaskRepository _taskRepository;
        TopicRepository _topicRepository;
        RegisterQueueRepository _registerQueue;
        StudentRepository _studentRepository;
        TeacherService _teacherService;
        UserSessionHelper _userSessionHelper = UserSessionHelper.Instance;

        int GroupIdCreate;

        public FTeacherDashboard()
        {
            _context = new ThesisManagementContext();
            _studentGroupRepository = new StudentGroupRepository(_context);
            _taskRepository = new TaskRepository(_context);
            _topicRepository = new TopicRepository(_context);
            _registerQueue = new RegisterQueueRepository(_context);
            _studentRepository = new StudentRepository(_context);
            _teacherService = new TeacherService(_userSessionHelper.UserID);
            InitializeComponent();
            btnNotification.Click += createNotification;
           
            
        }
        private void createNotification(object sender, EventArgs e)
        {
            FNotification fNotification = new FNotification(_context);
            fNotification.Show();

        }
        private void createTopic(object sender, EventArgs e)
        {
            FTeacherCreateTopic fTeacherCreateTopic = new FTeacherCreateTopic(_context);
            fTeacherCreateTopic.Show();

        }
        private void createTask(object sender, EventArgs e)
        {
            FTeacherCreateTask fTeacherCreateTask = new FTeacherCreateTask(GroupIdCreate, _context);
            fTeacherCreateTask.Show();
        }

        private void ucAllTopics1_Load(object sender, EventArgs e)
        {

        }

        private void task_Click(object sender, EventArgs e)
        {

            panelContainer.Controls.Clear();
            UcTeacherAllTask ucTeacherAllTask = new UcTeacherAllTask();
            ucTeacherAllTask.Dock = DockStyle.Fill;
            ucTeacherAllTask.btnCreate.Click += createTask;
            ucTeacherAllTask.DateChanged += DateTimePicker_ValueChanged;
            panelContainer.Controls.Add(ucTeacherAllTask);
            ucTeacherAllTask1_Load(ucTeacherAllTask);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            this.Hide();
            fLogin.Show();
        }

        private void Project_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UcTeacherAllTopics ucTeacherAllTopics = new UcTeacherAllTopics();
            ucTeacherAllTopics.Dock = DockStyle.Fill;
            ucTeacherAllTopics.btnCreate.Click += createTopic;
            ucTeacherAllTopics._cbTopicTypeChanged += CbTopicType_ValueChanged;
            ucTeacherAllTopics_Load(ucTeacherAllTopics);
            panelContainer.Controls.Add(ucTeacherAllTopics);
        }
        private void ucTeacherAllTopics_Load(UcTeacherAllTopics ucTeacherAllTopics)
        {
            ListTopic(ucTeacherAllTopics, _topicRepository.GetAll().ToList());
        }
        private void ucTeacherAllTask1_Load(UcTeacherAllTask ucTeacherAllTask)
        {
            //dtpStartDay is 7 days before today
            ucTeacherAllTask.dtpStartDay.Value = DateTime.Now.AddDays(-7);
            ucTeacherAllTask.dtpEndDay.Value = DateTime.Now;
            ListGroup(ucTeacherAllTask);
            
        }
        #region ucTeacherAllTask1-Components

        private void ListGroup(UcTeacherAllTask ucTeacherAllTask)
        {
            ucTeacherAllTask.flpAllGroupView.Controls.Clear();
            var studentGroupList = _studentGroupRepository.GetAll();
            foreach (var studentGroup in studentGroupList)
            {
                UcTeacherSingleGroup ucTeacherSingleGroup = new UcTeacherSingleGroup();
                ucTeacherSingleGroup.NameGroup = studentGroup.group_name;
                var topic = _topicRepository.GetById((int)studentGroup.topic_id);
                ucTeacherSingleGroup.NameTopic = topic.topic_name;
                ucTeacherSingleGroup.Id = studentGroup.group_id;
                ucTeacherSingleGroup.Clicked += ucTeacherSingleGroup_Clicked;
                ucTeacherAllTask.flpAllGroupView.Controls.Add(ucTeacherSingleGroup);
            }
        }

        // add button edit event to each task in flpAllTasks
        private void AddEditButtonToTask(UcTeacherAllTask ucTeacherAllTask)
        {
            foreach (UcTeacherSingleTask ucTeacherSingleTask in ucTeacherAllTask.flpAllTasks.Controls)
            {
                ucTeacherSingleTask.EditButtonClicked += ucTeacherSingleTask_EditButton_Click;
            }
        }


        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UcTeacherAllTask ucTeacherAllTask = sender as UcTeacherAllTask;
            ucTeacherAllTask.flpAllTasks.Controls.Clear();
            var taskList = _taskRepository.GetAll().ToList();
            var filterHelper = new FilterByDayHelper(taskList, _context);
            var taskListFiltered = filterHelper.FilterByDay(ucTeacherAllTask.dtpStartDay.Value, ucTeacherAllTask.dtpEndDay.Value);
            foreach (var task in taskListFiltered)
            {
                UcTeacherSingleTask ucTeacherSingleTask = new UcTeacherSingleTask();
                ucTeacherSingleTask.Name = task.task_name;
                ucTeacherSingleTask.TimeOpen = task.open_day.Value;
                ucTeacherSingleTask.TimeEnd = task.due_date.Value;
                ucTeacherSingleTask.Content = task.task_description;
                ucTeacherSingleTask.TaskId = task.task_id;
                ucTeacherSingleTask.EditButtonClicked += ucTeacherSingleTask_EditButton_Click;
                ucTeacherSingleTask.SubmitButtonClicked += ucTeacherSingleTask_SubmitTask_Click;
                ucTeacherSingleTask.PointButtonClicked += UcTeacherSingleTask_PointButtonClicked;
                ucTeacherAllTask.flpAllTasks.Controls.Add(ucTeacherSingleTask);
            }
        }

        private void UcTeacherSingleTask_PointButtonClicked(object sender, EventArgs e)
        {
            UcTeacherSingleTask ucTeacherSingleTask = sender as UcTeacherSingleTask;
            FTeacherMark fTeacherMark = new FTeacherMark(_context,ucTeacherSingleTask.TaskId);
            fTeacherMark.Show();
        }

        #endregion

        #region ucTeacherSingleGroup-Events

        // when click on a group user control -> show tasks of that group

        private void ucTeacherSingleGroup_Clicked(object sender, EventArgs e)
        {
            UcTeacherSingleGroup ucTeacherSingleGroup = sender as UcTeacherSingleGroup;
            UcTeacherAllTask ucTeacherAllTask =  (UcTeacherAllTask)ucTeacherSingleGroup.Parent.Parent.Parent;
            int groupId = GroupIdCreate = ucTeacherSingleGroup.Id;
            var taskList = _taskRepository.GetTaskByGroupId(groupId);
            ucTeacherAllTask.flpAllTasks.Controls.Clear();

            var filterHelper = new FilterByDayHelper(taskList.ToList(), _context);
            var taskListFiltered = filterHelper.FilterByDay(ucTeacherAllTask.dtpStartDay.Value, ucTeacherAllTask.dtpEndDay.Value);

            if (taskListFiltered.Count == 0)
            {
                ucTeacherAllTask.flpAllTasks.Controls.Clear();
                MessageBox.Show($"No task created between {ucTeacherAllTask.dtpStartDay.Value} and {ucTeacherAllTask.dtpEndDay.Value} ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var task in taskList)
            {
                foreach (var taskFiltered in taskListFiltered)
                {
                    if (task.task_id == taskFiltered.task_id)
                    {
                        UcTeacherSingleTask ucTeacherSingleTask = new UcTeacherSingleTask();
                        ucTeacherSingleTask.Name = task.task_name;
                        ucTeacherSingleTask.TimeOpen = task.open_day.Value;
                        ucTeacherSingleTask.TimeEnd = task.due_date.Value;
                        ucTeacherSingleTask.Content = task.task_description;
                        ucTeacherSingleTask.TaskId = task.task_id;
                        ucTeacherSingleTask.EditButtonClicked += ucTeacherSingleTask_EditButton_Click;
                        ucTeacherSingleTask.SubmitButtonClicked += ucTeacherSingleTask_SubmitTask_Click;
                        ucTeacherSingleTask.PointButtonClicked += UcTeacherSingleTask_PointButtonClicked;
                        ucTeacherAllTask.flpAllTasks.Controls.Add(ucTeacherSingleTask);
                    }
                }
            }
        }

        #endregion

        #region UcTeacherSingleTask-Events

        private void ucTeacherSingleTask_EditButton_Click(object sender, EventArgs e)
        {
            UcTeacherSingleTask ucTeacherSingleTask = sender as UcTeacherSingleTask;
            var taskName = ucTeacherSingleTask.Name;
            var task = _taskRepository.GetTaskByTaskName(taskName);
            FTeacherEditTask fTeacherEditTask = new FTeacherEditTask(task, _context);
            fTeacherEditTask.Show();
        }
        private void ucTeacherSingleTask_SubmitTask_Click(object sender, EventArgs e) 
        {
            UcTeacherSingleTask ucTeacherSingleTask = sender as UcTeacherSingleTask;
            var taskName = ucTeacherSingleTask.Name;
            var task = _taskRepository.GetTaskByTaskName(taskName);
            //task. = 
        }

        #endregion

        #region ucTeacherAllTopics-Components
        private void ListTopic(UcTeacherAllTopics ucTeacherAllTopics, List<Topic> topicList)
        {
            ucTeacherAllTopics.flpTopicView.Controls.Clear();
            foreach (var topic in topicList)
            {
                Topic topic1 = new Topic();
                UcTeacherSingleTopic singletopic = new UcTeacherSingleTopic(_context);
                int numberStudentInqueue = _registerQueue.GetNumberUnacceptedStudentInqueue(topic.topic_id);
                if (numberStudentInqueue > 0)
                {
                    singletopic.lblStudentInqueue.Visible = true;
                    singletopic.lblStudentInqueue.Text = "There are " + numberStudentInqueue + " students in queue";
                }
                topic1.topic_name = topic.topic_name;
                topic1.topic_description = topic.topic_description;
                singletopic.SetTopic(topic1);
                ucTeacherAllTopics.flpTopicView.Controls.Add(singletopic);
            }
        }

        private void CbTopicType_ValueChanged(object sender, EventArgs e)
        {
            UcTeacherAllTopics ucTeacherAllTopics = sender as UcTeacherAllTopics;
            ucTeacherAllTopics.flpTopicView.Controls.Clear();
            var topicList = _topicRepository.GetAll().ToList();
            if (ucTeacherAllTopics.CbTopicType.SelectedItem == "Inqueue Topic")
            {
                var inqueueTopics = _registerQueue.GetAllInqueueTopic();
                topicList = _topicRepository.GetByListOfTopic(inqueueTopics);
            }
            else if (ucTeacherAllTopics.CbTopicType.SelectedItem == "Accepted Topic")
            {
                var groupIDList = _studentRepository.GetAllGroupID();
                var topicIDList = _studentGroupRepository.GetListOfTopic(groupIDList);
                topicList = _topicRepository.GetByListOfTopic(topicIDList);
            }
            else if (ucTeacherAllTopics.CbTopicType.SelectedItem == "Unaccepted Topic")
            {
                var groupIDList = _studentRepository.GetAllGroupID();
                var topicIDList = _studentGroupRepository.GetListOfTopic(groupIDList);
                var unregisterTopicIDList = _topicRepository.GetAllTopicID().Except(topicIDList).ToList();
                topicList = _topicRepository.GetByListOfTopic(unregisterTopicIDList);
            }
            ListTopic(ucTeacherAllTopics, topicList);
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
                }
                Application.Exit();
            }
        }

        private void analytics_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UcTeacherAnalytic ucTeacherAnalytic = new UcTeacherAnalytic();
            ucTeacherAnalytic.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucTeacherAnalytic);
        }
    }
}
