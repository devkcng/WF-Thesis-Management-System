using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
        SubTaskRepository _subtaskRepository;
        UserSessionHelper _userSessionHelper = UserSessionHelper.Instance;
        TeacherRepository _teacherRepository;
        StatisticsService _statisticsService;

        int GroupIdCreate;

        public FTeacherDashboard()
        {
            _context = new ThesisManagementContext();
            _studentGroupRepository = new StudentGroupRepository(_context);
            _taskRepository = new TaskRepository(_context);
            _topicRepository = new TopicRepository(_context);
            _registerQueue = new RegisterQueueRepository(_context);
            _studentRepository = new StudentRepository(_context);
            _subtaskRepository = new SubTaskRepository(_context);
            _teacherService = new TeacherService(_userSessionHelper.UserID);
            _teacherRepository = new TeacherRepository(_context);
            _statisticsService = new StatisticsService(_context);
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
        private void worklogs_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UCProgress uCProgress = new UCProgress();
            uCProgress.Dock = DockStyle.Fill;
            uCProgress._cbGroupCategoryChanged += CbGroupCategory_ValueChanged;
            uCProgress._cbMemberCategoryChanged += CbMemberCategory_ValueChanged;
            ListUCProgressComponents(uCProgress);
            panelContainer.Controls.Add(uCProgress);
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
            var taskListFiltered = filterHelper.FilterTasksByDay(ucTeacherAllTask.dtpStartDay.Value, ucTeacherAllTask.dtpEndDay.Value);
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
            FTeacherMark fTeacherMark = new FTeacherMark(_context, ucTeacherSingleTask.TaskId);
            fTeacherMark.Show();
        }

        #endregion

        #region ucTeacherSingleGroup-Events

        // when click on a group user control -> show tasks of that group

        private void ucTeacherSingleGroup_Clicked(object sender, EventArgs e)
        {
            UcTeacherSingleGroup ucTeacherSingleGroup = sender as UcTeacherSingleGroup;
            UcTeacherAllTask ucTeacherAllTask = (UcTeacherAllTask)ucTeacherSingleGroup.Parent.Parent.Parent;
            int groupId = GroupIdCreate = ucTeacherSingleGroup.Id;
            var taskList = _taskRepository.GetTaskByGroupId(groupId);
            ucTeacherAllTask.flpAllTasks.Controls.Clear();

            var filterHelper = new FilterByDayHelper(taskList.ToList(), _context);
            var taskListFiltered = filterHelper.FilterTasksByDay(ucTeacherAllTask.dtpStartDay.Value, ucTeacherAllTask.dtpEndDay.Value);

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

        #region uCProgress-Events
        private void ListUCProgressComponents(UCProgress uCProgress)
        {
            //load data to cbxGroupCategory
            // Tạo một danh sách dữ liệu mẫu
            List<dynamic> dataList = new List<dynamic>();
            var studentGroupList = _studentGroupRepository.GetAll();
            foreach (var studentGroup in studentGroupList)
            {
                dataList.Add(studentGroup.group_name);
            }


            // Xóa các mục đã tồn tại trong ComboBox (nếu có)
            uCProgress.cbxGroupCategory.Items.Clear();

            // Thêm dữ liệu vào ComboBox
            foreach (var item in dataList)
            {
                uCProgress.cbxGroupCategory.Items.Add(item);
            }


        }
        private void CbGroupCategory_ValueChanged(object sender, EventArgs e)
        {
            UCProgress uCProgress = sender as UCProgress;
            if (uCProgress.cbxGroupCategory.SelectedItem != null)
            {
                uCProgress.SubTaskProgessChart.Series["s1"].Points.Clear();
                uCProgress.GroupTaskProgessChart.Series["s1"].Points.Clear();
                dynamic selectedValue = uCProgress.cbxGroupCategory.SelectedItem;
                // Gán giá trị được chọn vào biến
                var groupName = selectedValue;
                var studentGroup = (StudentGroup)_studentGroupRepository.GetByGroupName(groupName);
                var taskGroupList = _taskRepository.GetByGroupID(studentGroup.group_id);
                List<SubTask> subTaskList = new List<SubTask>();
                foreach (var task in taskGroupList)
                {
                    var subTasks = _subtaskRepository.GetAllByTaskId(task.task_id);
                    subTaskList.AddRange(subTasks);
                }
                LoadPointDataGridView(uCProgress.dgvPoint, subTaskList);

                //load data to cbxMemberCategory
                // Tạo một danh sách dữ liệu mẫu
                List<dynamic> dataList = new List<dynamic>();
                var studentList = _studentRepository.GetAllByGroupId(studentGroup.group_id);
                foreach (var student in studentList)
                {
                    dataList.Add(student.student_name);
                }


                // Xóa các mục đã tồn tại trong ComboBox (nếu có)
                uCProgress.cbxMemberCategory.Items.Clear();

                // Thêm dữ liệu vào ComboBox
                foreach (var item in dataList)
                {
                    uCProgress.cbxMemberCategory.Items.Add(item);
                }


                LoadGroupTaskProgressChart(uCProgress.GroupTaskProgessChart, taskGroupList);

            }
        }
        private void CbMemberCategory_ValueChanged(object sender, EventArgs e)
        {
            UCProgress uCProgress = sender as UCProgress;

            if (uCProgress.cbxMemberCategory.SelectedItem != null)
            {
                dynamic selectedValue = uCProgress.cbxMemberCategory.SelectedItem;
                // Gán giá trị được chọn vào biến
                var student = (Student)_studentRepository.GetByStudentName(selectedValue);
                var subTaskList = _subtaskRepository.GetAllByStudentId(student.student_id);
                LoadSubTaskProgressChart(uCProgress.SubTaskProgessChart, subTaskList.ToList());
            }
        }
        //private void CbDateTimeCategory_ValueChanged(object sender, EventArgs e)
        //{
        //    UCProgress uCProgress = sender as UCProgress;
        //    uCProgress.dgvPoint.Controls.Clear();
        //    dynamic selectedValue = uCProgress.cbxGroupCategory.SelectedItem;
        //    var groupName = (string)selectedValue;
        //    var studentGroup= _studentGroupRepository.GetByGroupName(groupName);
        //    var groupTaskList = _taskRepository.GetByGroupID(studentGroup.group_id);
        //    List<SubTask> subTaskList = new List<SubTask>();
        //    foreach (var task in groupTaskList)
        //    {
        //        var subTasks = _subtaskRepository.GetAllByTaskId(task.task_id);
        //        subTaskList.AddRange(subTasks);
        //    }


        //    var filterHelper = new FilterByDayHelper(subTaskList, _context);
        //    if (uCProgress.cbxDateTime.SelectedItem == "This week")
        //    {
        //        groupTaskList = filterHelper.FilterByWeek();
        //    }
        //    else if (uCStudentProject.CbTaskDate.SelectedItem == "This month")
        //    {
        //        groupTaskList = filterHelper.FilterByMonth();
        //    }
        //    else if (uCStudentProject.CbTaskDate.SelectedItem == "All")
        //    {
        //        groupTaskList = filterHelper.GetSortedTasks();
        //    }
        //}
        private void LoadPointDataGridView(DataGridView pointDataGridView, List<SubTask> subTaskList)
        {
            // Xóa các cột hiện tại của DataGridView
            pointDataGridView.Columns.Clear();

            // Tạo một DataTable mới
            DataTable dataTable = new DataTable();

            // Thêm các cột vào DataTable
            dataTable.Columns.Add("SubTaskName", typeof(string));
            dataTable.Columns.Add("StudentName", typeof(string));
            dataTable.Columns.Add("GroupName", typeof(string));
            dataTable.Columns.Add("SubTaskPoint", typeof(float));

            // Thêm dữ liệu vào DataTable
            foreach (var subTask in subTaskList)
            {
                var student = _studentRepository.GetById(subTask.student_id.Value);
                var studentGroup = _studentGroupRepository.GetById(student.group_id.Value);

                dataTable.Rows.Add(subTask.subtask_name, student.student_name, studentGroup.group_name, 10);
            }

            // Gán DataTable cho DataGridView
            pointDataGridView.DataSource = dataTable;
        }

        private void LoadSubTaskProgressChart(Chart subTaskChart, List<SubTask> subTaskList)
        {
            SubTask subTask = subTaskList.FirstOrDefault(subtask => subtask != null);
            if (subTask != null)
            {
                subTaskChart.Series["s1"].Points.Clear();


                var completedSubTasks = _subtaskRepository.GetNumberOfCompletedSubTaskOfStudents(subTask.student_id.Value);
                var uncompletedSubTasks = _subtaskRepository.GetNumberOfUncompletedSubTaskOfStudents(subTask.student_id.Value);
                var lateSubmittedSubTasks = _subtaskRepository.GetNumberOfLateSubmittedSubTasksOfStudents(subTask.student_id.Value);

                int n = 0;
                if (completedSubTasks > 0)
                {
                    subTaskChart.Series["s1"].Points.AddXY(completedSubTasks.ToString(), completedSubTasks);
                    subTaskChart.Series["s1"].Points[n++].LegendText = "Submitted SubTask";
                }
                if (uncompletedSubTasks > 0)
                {
                    subTaskChart.Series["s1"].Points.AddXY(uncompletedSubTasks.ToString(), uncompletedSubTasks);
                    subTaskChart.Series["s1"].Points[n++].LegendText = "Unsubmitted SubTask";
                }
                if (lateSubmittedSubTasks > 0)
                {
                    subTaskChart.Series["s1"].Points.AddXY(lateSubmittedSubTasks.ToString(), lateSubmittedSubTasks);
                    subTaskChart.Series["s1"].Points[n++].LegendText = "Late Submitted SubTask";
                }
            }
            else MessageBox.Show("This student has no subtask");
        }
        private void LoadGroupTaskProgressChart(Chart groupTaskChart, List<Task> groupTaskList)
        {
            Task groupTask = groupTaskList.FirstOrDefault(task => task != null);

            var student = _studentRepository.GetById(_userSessionHelper.UserID);
            var completedTasks = _taskRepository.GetNumberOfCompletedTaskOfGroup(groupTask.group_id.Value);
            var uncompletedTasks = _taskRepository.GetNumberOfUncompletedTaskOfGroup(groupTask.group_id.Value);
            var lateSubmittedTasks = _taskRepository.GetNumberOfLateSubmittedTasksOfGroup(groupTask.group_id.Value);

            int n = 0;
            if (completedTasks > 0)
            {
                groupTaskChart.Series["s1"].Points.AddXY(completedTasks.ToString(), completedTasks);
                groupTaskChart.Series["s1"].Points[n++].LegendText = "Submitted Task";
            }
            if (uncompletedTasks > 0)
            {
                groupTaskChart.Series["s1"].Points.AddXY(uncompletedTasks.ToString(), uncompletedTasks);
                groupTaskChart.Series["s1"].Points[n++].LegendText = "Unsubmitted Task";
            }
            if (lateSubmittedTasks > 0)
            {
                groupTaskChart.Series["s1"].Points.AddXY(lateSubmittedTasks.ToString(), lateSubmittedTasks);
                groupTaskChart.Series["s1"].Points[n++].LegendText = "Late Submitted Task";
            }
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
            foreach (var teacher in _teacherRepository.GetAll())
            {
                string Comment;

                double Point = 10 - 0.5 * _statisticsService.CountStudentComplete(teacher.teacher_id, 0)- 0.25*_statisticsService.CountStudentsAveragePoint(teacher.teacher_id,0);
                if (Point >= 9 && Point <= 10) Comment = "Excellent";
                else if (Point >= 7.5 && Point < 9) Comment = "Very good";
                else if (Point >= 6.5 && Point < 7.5) Comment = "Good";
                else Comment = "Average";
                ucTeacherAnalytic.dgvTeacherRanking.Rows.Add($"{teacher.teacher_name}", $"{teacher.subject_taught}", $"{_statisticsService.CountStudentsAveragePoint(teacher.teacher_id, 0)}",$"{_statisticsService.CountStudentsAveragePoint(teacher.teacher_id, 1)}", $"{_statisticsService.CountStudentsAveragePoint(teacher.teacher_id, 2)}", $"{_statisticsService.CountStudentComplete(teacher.teacher_id,1)}",Comment);
            }
            //ucTeacherAnalytic.dgvTeacherRanking.DataSource
            panelContainer.Controls.Add(ucTeacherAnalytic);
        }


    }
}
