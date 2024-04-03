using ComponentFactory.Krypton.Toolkit;
using System;
using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    public partial class FTeacherDashboard : KryptonForm
    {
        ThesisManagementContext _context;
        StudentGroupRepository _studentGroupRepository;
        TaskRepository _taskRepository;
        int GroupIdCreate;
        public FTeacherDashboard()
        {
            _context = new ThesisManagementContext();
            _studentGroupRepository = new StudentGroupRepository(_context);
            _taskRepository = new TaskRepository(_context);
            InitializeComponent();
            ucTeacherAllTopics1.Hide();
            ucTeacherAllTask1.Hide();
            ucTeacherInfor1.Hide();
            ucTeacherEditInfor1.Hide();

            ucTeacherAllTopics1.btnCreate.Click += createTopic;
            ucTeacherAllTask1.btnCreate.Click += createTask;
        }
        private void createTopic(object sender, EventArgs e)
        {
            ucTeacherAllTopics1.Hide();
            FTeacherCreateTopic fTeacherCreateTopic = new FTeacherCreateTopic();
            fTeacherCreateTopic.Show();

        }
        private void createTask(object sender, EventArgs e)
        {
            ucTeacherAllTask1.Hide();
            FTeacherCreateTask fTeacherCreateTask = new FTeacherCreateTask(GroupIdCreate);
            fTeacherCreateTask.Show();
        }

        private void ucAllTopics1_Load(object sender, EventArgs e)
        {

        }

        private void task_Click(object sender, EventArgs e)
        {
            
            ucTeacherAllTopics1.Hide();
            ucTeacherAllTask1.Show();
            ucTeacherEditInfor1.Hide();
            ucTeacherInfor1.Hide();
            ucTeacherAllTask1_Load(sender, e);

        }

        private void logout_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            this.Close();
            fLogin.Show();
        }

        private void Project_Click(object sender, EventArgs e)
        {
            ucTeacherAllTopics1.UcTeacherAllTopics_Load(sender, e);
            ucTeacherAllTopics1.Show();
            ucTeacherAllTask1.Hide();
            ucTeacherEditInfor1.Hide();
            ucTeacherInfor1.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ucTeacherAllTopics1.Hide();
            ucTeacherAllTask1.Hide();
            ucTeacherInfor1.Show();
            ucTeacherEditInfor1.Hide();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucTeacherAllTopics1.Hide();
            ucTeacherAllTask1.Hide();
            ucTeacherInfor1.Show();
            ucTeacherEditInfor1.Show();
        }
        private void ucTeacherAllTask1_Load(object sender, EventArgs e)
        {
            ListGroup();
        }
        #region ucTeacherAllTask1-Components

        private void ListGroup()
        {
            ucTeacherAllTask1.flpAllGroupView.Controls.Clear();
            var studentGroupList = _studentGroupRepository.GetAll();
            foreach (var studentGroup in studentGroupList)
            {
                UcTeacherSingleGroup ucTeacherSingleGroup = new UcTeacherSingleGroup();
                ucTeacherSingleGroup.Name = studentGroup.group_name;
                ucTeacherSingleGroup.Id = studentGroup.group_id;
                ucTeacherSingleGroup.Clicked += ucTeacherSingleGroup_Clicked;
                ucTeacherAllTask1.flpAllGroupView.Controls.Add(ucTeacherSingleGroup);
            }
        }
        #endregion

        #region ucTeacherSingleGroup-Events

        // when click on a group user control -> show tasks of that group

        private void ucTeacherSingleGroup_Clicked(object sender, EventArgs e)
        {
            UcTeacherSingleGroup ucTeacherSingleGroup = sender as UcTeacherSingleGroup;
            int groupId = GroupIdCreate = ucTeacherSingleGroup.Id;
            var taskList = _taskRepository.GetTaskByGroupId(groupId);
            ucTeacherAllTask1.flpAllTasks.Controls.Clear();
            foreach (var task in taskList)
            {
                UcTeacherSingleTask ucTeacherSingleTask = new UcTeacherSingleTask();
                ucTeacherSingleTask.Name = task.task_name;
                ucTeacherSingleTask.TimeOpen = task.open_day.Value;
                ucTeacherSingleTask.TimeEnd = task.due_date.Value;
                ucTeacherSingleTask.EditButtonClicked += ucTeacherSingleTask_EditButton_Click;
                ucTeacherSingleTask.SubmitButtonClicked += ucTeacherSingleTask_SubmitTask_Click;
                ucTeacherAllTask1.flpAllTasks.Controls.Add(ucTeacherSingleTask);
            }
        }

        #endregion

        #region UcTeacherSingleTask-Events

        private void ucTeacherSingleTask_EditButton_Click(object sender, EventArgs e)
        {
            UcTeacherSingleTask ucTeacherSingleTask = sender as UcTeacherSingleTask;
            var taskName = ucTeacherSingleTask.Name;
            var task = _taskRepository.GetTaskByTaskName(taskName);
            FTeacherEditTask fTeacherEditTask = new FTeacherEditTask(task);
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
       
    }
}
