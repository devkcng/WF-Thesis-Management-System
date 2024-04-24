﻿using ComponentFactory.Krypton.Toolkit;
using System;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl;
using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    public partial class FTeacherDashboard : KryptonForm
    {
        ThesisManagementContext _context;
        StudentGroupRepository _studentGroupRepository;
        TaskRepository _taskRepository;
        TopicRepository _topicRepository;
        int GroupIdCreate;

        public FTeacherDashboard()
        {
            _context = new ThesisManagementContext();
            _studentGroupRepository = new StudentGroupRepository(_context);
            _taskRepository = new TaskRepository(_context);
            _topicRepository = new TopicRepository(_context);
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
            this.Close();
            fLogin.Show();
        }

        private void Project_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UcTeacherAllTopics ucTeacherAllTopics = new UcTeacherAllTopics();
            ucTeacherAllTopics.Dock = DockStyle.Fill;
            ucTeacherAllTopics.btnCreate.Click += createTopic;
            ucTeacherAllTopics_Load(ucTeacherAllTopics);
            panelContainer.Controls.Add(ucTeacherAllTopics);
        }
        private void ucTeacherAllTopics_Load(UcTeacherAllTopics ucTeacherAllTopics)
        {
            ListTopic(ucTeacherAllTopics);
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
                ucTeacherSingleTask.EditButtonClicked += ucTeacherSingleTask_EditButton_Click;
                ucTeacherSingleTask.SubmitButtonClicked += ucTeacherSingleTask_SubmitTask_Click;
                ucTeacherAllTask.flpAllTasks.Controls.Add(ucTeacherSingleTask);
            }
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
                        ucTeacherSingleTask.EditButtonClicked += ucTeacherSingleTask_EditButton_Click;
                        ucTeacherSingleTask.SubmitButtonClicked += ucTeacherSingleTask_SubmitTask_Click;
                        ucTeacherAllTask.flpAllTasks.Controls.Add(ucTeacherSingleTask);
                    }
                }
            }
            MessageBox.Show(taskList.Count().ToString());
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
        private void ListTopic(UcTeacherAllTopics ucTeacherAllTopics)
        {
            var Table = _topicRepository.GetAll();
            ucTeacherAllTopics.flpTopicView.Controls.Clear();
            foreach (var topic in Table)
            {
                Topic topic1 = new Topic();
                UcTeacherSingleTopic singletopic = new UcTeacherSingleTopic(_context);
                topic1.topic_name = topic.topic_name;
                topic1.topic_description = topic.topic_description;
                singletopic.SetTopic(topic1);
                ucTeacherAllTopics.flpTopicView.Controls.Add(singletopic);
            }
        }
        #endregion

    }
}
