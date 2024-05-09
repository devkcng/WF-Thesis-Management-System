using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WFThesisManagementSystem.Forms.ChatApp;
using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    public partial class FStudentDashboard : KryptonForm
    {
        UserSessionHelper _userSessionHelper = UserSessionHelper.Instance;
        ThesisManagementContext _context;
        StudentRepository _studentRepository;
        TaskRepository _taskRepository;
        SubTaskRepository _subtaskRepository;
        StudentGroupRepository _studentgroupRepository;
        TopicRepository _topicRepository;
        TeacherRepository _teacherRepository;
        SubtaskPointRepository _subtaskPointRepository;
        StudentPointRepository _studentPointRepository;
        public FStudentDashboard()
        {
            _context = new ThesisManagementContext();
            _studentRepository = new StudentRepository(_context);
            _taskRepository = new TaskRepository(_context);
            _subtaskRepository = new SubTaskRepository(_context);
            _studentgroupRepository = new StudentGroupRepository(_context);
            _topicRepository = new TopicRepository(_context);
            _teacherRepository = new TeacherRepository(_context);
            _subtaskPointRepository= new SubtaskPointRepository(_context);
            _studentPointRepository = new StudentPointRepository(_context);
            InitializeComponent();
            btnNotification.Click += createNotification;
        }

        private void createNotification(object sender, EventArgs e)
        {
            if (!TopicRegisterReminder())
            {
                return;
            }
            FNotification fNotification = new FNotification(_context);
            fNotification.Show();
        }

        private void CbTaskDate_ValueChanged(object sender, EventArgs e)
        {
            if (!TopicRegisterReminder())
            {
                return;
            }
            UCStudentProject uCStudentProject = sender as UCStudentProject;
            uCStudentProject.flpTask.Controls.Clear();
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value);
            var filterHelper = new FilterByDayHelper(groupTaskList, _context);
            if (uCStudentProject.CbTaskDate.SelectedItem == "This week")
            {
                groupTaskList = filterHelper.FilterTaskByWeek();
            }
            else if (uCStudentProject.CbTaskDate.SelectedItem == "This month")
            {
                groupTaskList = filterHelper.FilterTaskByMonth();
            }
            else if (uCStudentProject.CbTaskDate.SelectedItem == "All")
            {
                groupTaskList = filterHelper.GetSortedTasks();
            }
            LoadTaskDashboard(groupTaskList, uCStudentProject.flpTask, new Size(380, 150), groupID.Value);
        }
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!TopicRegisterReminder())
            {
                return;
            }
            UCStudentTask uCStudentTask = sender as UCStudentTask;
            uCStudentTask.flpGroupTaskView.Controls.Clear();
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value);
            var filterHelper = new FilterByDayHelper(groupTaskList, _context);
            var taskListFiltered = filterHelper.FilterTasksByDay(uCStudentTask.dtpStartDay.Value, uCStudentTask.dtpEndDay.Value);
            foreach (var groupTask in taskListFiltered)
            {
                UCTask uCTask = new UCTask();
                uCTask.Name = groupTask.task_name;
                uCTask.Id = groupTask.task_id;
                uCTask.txtProjectDetail.Text = groupTask.task_description;
                uCTask.GroupID = groupID.Value;
                var openDay = groupTask.open_day.Value;
                var deadline = groupTask.due_date.Value;
                uCTask.lblOpenDay.Text = openDay.ToString("dd/MM/yyyy");
                uCTask.lblDeadline.Text = deadline.ToString("dd/MM/yyyy");
                if (groupTask.submit_day != null) { uCTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38__2_1; }
                else { uCTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38; }
                uCTask.Clicked += ucTask_Clicked;
                uCTask.ChatButtonClicked += btnChat_Clicked;
                uCStudentTask.flpGroupTaskView.Controls.Add(uCTask);
            }
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TopicRegisterReminder())
            {
                return;
            }
            panelContainer.Controls.Clear();
            UCStudentProject uCStudentProject = new UCStudentProject();
            uCStudentProject.Dock = DockStyle.Fill;
            uCStudentProject._cbDateChanged += CbTaskDate_ValueChanged;
            panelContainer.Controls.Add(uCStudentProject);
            ListUCStudentProjectComponent(uCStudentProject);
        }
        private void task_Click(object sender, EventArgs e)
        {
            if (!TopicRegisterReminder())
            {
                return;
            }
            panelContainer.Controls.Clear();
            UCStudentTask uCStudentTask = new UCStudentTask();
            uCStudentTask.Dock = DockStyle.Fill;
            uCStudentTask.dtpStartDay.Value = _taskRepository.GetFirstTask().open_day.Value;
            uCStudentTask.dtpEndDay.Value = DateTime.Now;
            UCStudentTask_Load(uCStudentTask);
            uCStudentTask.DateChanged += DateTimePicker_ValueChanged;
            panelContainer.Controls.Add(uCStudentTask);

        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            if (!TopicRegisterReminder())
            {
                return;
            }
            panelContainer.Controls.Clear();

            UCStudentCalendar uCStudentCalendar = new UCStudentCalendar();
            uCStudentCalendar.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uCStudentCalendar);
            ListCalendarComponent(uCStudentCalendar);
        }
        private void worklogs_Click(object sender, EventArgs e)
        {
            if (!TopicRegisterReminder())
            {
                return;
            }
            panelContainer.Controls.Clear();
            UCProgress uCProgress = new UCProgress();
            uCProgress.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uCProgress);
            ListUCProgressComponents(uCProgress);
        }



        private void logout_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            fLogin.Show();
            this.Hide();
        }

        private void performance_Click(object sender, EventArgs e)
        {
            if (!TopicRegisterReminder())
            {
                return;
            }
        }

        private void UCStudentTask_Load(UCStudentTask uCStudentTask)
        {
            ListTasks(uCStudentTask);
        }


        #region UCStudentProject-Components
        private void ListUCStudentProjectComponent(UCStudentProject uCStudentProject)
        {
            var student = _studentRepository.GetById(_userSessionHelper.UserID);
            var studentGroup = _studentgroupRepository.GetById(student.group_id.Value);
            var studentTopic = _topicRepository.GetById(studentGroup.topic_id.Value);
            var memberGroupList = _studentRepository.GetAllByGroupId(studentGroup.group_id);
            var taskLisk = _taskRepository.GetByGroupID(studentGroup.group_id);
            FilterByDayHelper filterByDayHelper = new FilterByDayHelper(taskLisk, _context);


            //Loadtopic
            LoadTopic(uCStudentProject, studentTopic);

            //Load Group member
            LoadGroupMember(uCStudentProject, memberGroupList.ToList());

            //Load task
            LoadTaskDashboard(filterByDayHelper.GetSortedTasks(), uCStudentProject.flpTask, new Size(380, 150), studentGroup.group_id);
        }
        private void LoadTopic(UCStudentProject uCStudentProject, Topic topic)
        {
            uCStudentProject.ucTopicDetail1.SetColors("#000000", "#FFFFFF");
            uCStudentProject.ucTopicDetail1.lblTopicName.Text = topic.topic_name;
            uCStudentProject.ucTopicDetail1.lblMaxMembers.Text = topic.max_members.ToString();
            uCStudentProject.ucTopicDetail1.txtTeacherName.Text = _teacherRepository.GetById(topic.teacher_id.Value).teacher_name;
            uCStudentProject.ucTopicDetail1.txtTechnology.Text = topic.topic_technology;
            uCStudentProject.ucTopicDetail1.txtCategory.Text = topic.topic_category;
            uCStudentProject.ucTopicDetail1.txtDescription.Text = topic.topic_description;
            uCStudentProject.ucTopicDetail1.txtRequirement.Text = topic.topic_requirement;
        }

        private void LoadGroupMember(UCStudentProject uCStudentProject, List<Student> memberGroup)
        {
            uCStudentProject.flpMember.Controls.Clear();
            foreach (var member in memberGroup)
            {
                UCStudentInformation uCStudentInformation = new UCStudentInformation();
                uCStudentInformation.lblName.Text = member.student_name;
                uCStudentProject.flpMember.Controls.Add(uCStudentInformation);
            }

        }
        private void LoadTaskDashboard(List<Task> Tasks, FlowLayoutPanel flp, Size size, int groupID)
        {
            var filterHelper = new FilterByDayHelper(Tasks, _context);

            flp.Visible = false;
            flp.Controls.Clear();
            foreach (var groupTask in Tasks)
            {

                UCTask uCTask = new UCTask();
                uCTask.Size = size;
                uCTask.Name = groupTask.task_name;
                uCTask.Id = groupTask.task_id;
                uCTask.txtProjectDetail.Text = groupTask.task_description;
                uCTask.txtProjectDetail.MaximumSize = new Size(350, 130);
                uCTask.GroupID = groupID;
                var openDay = groupTask.open_day.Value;
                var deadline = groupTask.due_date.Value;
                uCTask.lblOpenDay.Text = openDay.ToString("dd/MM/yyyy");
                uCTask.lblDeadline.Text = deadline.ToString("dd/MM/yyyy");
                int newSize = 8; // Kích thước font mới
                uCTask.lblOpenDay.Font = new Font(uCTask.lblOpenDay.Font.FontFamily, newSize);
                uCTask.lblOpenDate.Font = new Font(uCTask.lblOpenDate.Font.FontFamily, newSize);
                uCTask.lblDueDate.Font = new Font(uCTask.lblDueDate.Font.FontFamily, newSize);
                uCTask.lblDeadline.Font = new Font(uCTask.lblDeadline.Font.FontFamily, newSize);
                uCTask.lblStatus.Font = new Font(uCTask.lblDeadline.Font.FontFamily, newSize);


                if (groupTask.submit_day != null) { uCTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38__2_1; }
                else { uCTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38; }
                flp.Controls.Add(uCTask);
            }

            flp.Visible = true;
        }

        
        #endregion

        #region UCStudentCalendar-Components
        private void ListCalendarComponent(UCStudentCalendar ucStudentCalendar)
        {


            //load calendar
            ucStudentCalendar.ucCalendar1.previousPtbClicked += PreviousPtb_Clicked;
            ucStudentCalendar.ucCalendar1.nextPtbClicked += NextPtb_Clicked;
            LoadCalendar(ucStudentCalendar);
            LoadUpcomingEvents(ucStudentCalendar);
            ////load task 
            //ucDashBoard.flpGroupTask.Hide();
            //ucDashBoard.flpGroupTask.Controls.Clear();
            //var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            //var groupTaskList = _taskRepository.GetByGroupID(groupID.Value);
            //var filterHelper = new FilterByDayHelper(groupTaskList, _context);
            //groupTaskList = filterHelper.GetSortedTasks();
            //LoadTask(groupTaskList, ucDashBoard.flpGroupTask, new Size(465, 140), groupID.Value);


        }
        private void LoadUpcomingEvents(UCStudentCalendar ucStudentCalendar)
        {
            DateTime currentDate = DateTime.Today;
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value);
            var filteredDates = groupTaskList.Where(grouptask => (grouptask.due_date - currentDate).Value.Days <= 7 && grouptask.due_date > currentDate);
            foreach (var submitdates in filteredDates)
            {


                UCSingleEvent uCSingleEvent = new UCSingleEvent();
                uCSingleEvent.lbEventName.Text = submitdates.task_name;
                uCSingleEvent.lblDay.Text = (submitdates.due_date - currentDate).Value.Days + " days left";
                uCSingleEvent.Margin = new Padding(0, 0, 0, 20); // Adjust the last parameter to control vertical spacing

                ucStudentCalendar.flpSingleEvent.Controls.Add(uCSingleEvent);
            }
        }

        private void LoadCalendar(UCStudentCalendar ucStudentCalendar)
        {
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value);
            var taskSubmitDates = groupTaskList.Select(groupTask => groupTask.due_date);
            var subTaskList = _subtaskRepository.GetAllByStudentId(_userSessionHelper.UserID);
            var subTaskSubmitDates = subTaskList.Select(subtask => subtask.due_date);
            NotificationService notificationService = new NotificationService(_context);
            var onlineMeetings = notificationService.GetTypesStudents("Online Meeting", _userSessionHelper.UserID);
            var onlineMeetingDates = onlineMeetings.Select(onlineMeeting => onlineMeeting.timestamp);

            ucStudentCalendar.ucCalendar1.flpDayContainer.Visible = false;
            ucStudentCalendar.ucCalendar1.flpDayContainer.Controls.Clear();
            ucStudentCalendar.ucCalendar1.panelBottom.Visible = false;
            DateTime startOfTheMonth = new DateTime(ucStudentCalendar.ucCalendar1.year, ucStudentCalendar.ucCalendar1.month, 1);
            int days = DateTime.DaysInMonth(ucStudentCalendar.ucCalendar1.year, ucStudentCalendar.ucCalendar1.month);

            if (ucStudentCalendar.ucCalendar1.month == 9)
                ucStudentCalendar.ucCalendar1.lblMY.Font = new Font(ucStudentCalendar.ucCalendar1.lblMY.Font.FontFamily, 45, ucStudentCalendar.ucCalendar1.lblMY.Font.Style);
            ucStudentCalendar.ucCalendar1.lblMY.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(ucStudentCalendar.ucCalendar1.month) + " " + ucStudentCalendar.ucCalendar1.year;
            int dayoftheweek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 2; i < dayoftheweek; i++)
            {
                UCBlank uCBlank = new UCBlank();
                ucStudentCalendar.ucCalendar1.flpDayContainer.Controls.Add(uCBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UCDay uCDay = new UCDay();
                uCDay.days(i);

                DateTime currentDate = new DateTime(ucStudentCalendar.ucCalendar1.year, ucStudentCalendar.ucCalendar1.month, i);
                if (taskSubmitDates.Contains(currentDate))
                {
                    uCDay.ptb1.FillColor = Color.Red;
                    uCDay.ptb1.Visible = true;
                }
                if(subTaskSubmitDates.Contains(currentDate))
                {
                    uCDay.ptb2.FillColor = Color.Yellow;
                    uCDay.ptb2.Visible = true;
                }
                if (onlineMeetingDates.Contains(currentDate))
                {
                    uCDay.ptb3.FillColor = Color.Green;
                    uCDay.ptb3.Visible = true;
                }
                ucStudentCalendar.ucCalendar1.flpDayContainer.Controls.Add(uCDay);
            }
            ucStudentCalendar.ucCalendar1.flpDayContainer.Visible = true;
            ucStudentCalendar.ucCalendar1.panelBottom.Visible = true;

        }
        #endregion

        #region ucStudentCalendar-Events
        private void PreviousPtb_Clicked(object sender, EventArgs e)
        {
            UCCalendar uCCalendar = sender as UCCalendar;
            //MessageBox.Show(uCCalendar.Parent.Parent.ToString());
            UCStudentCalendar ucStudentCalendar = (UCStudentCalendar)uCCalendar.Parent.Parent; // Tìm UCDashBoard từ UCCalendar

            if (uCCalendar.month == 1)
            {
                uCCalendar.year--;
                uCCalendar.month = 12;
            }
            else
            {
                uCCalendar.month--;
            }
            LoadCalendar(ucStudentCalendar);
        }
        private void NextPtb_Clicked(object sender, EventArgs e)
        {
            UCCalendar uCCalendar = sender as UCCalendar;
            UCStudentCalendar ucStudentCalendar = (UCStudentCalendar)uCCalendar.Parent.Parent; // Tìm UCDashBoard từ UCCalendar
            if (uCCalendar.month == 12)
            {
                uCCalendar.year++;
                uCCalendar.month = 1;
            }
            else
            {
                uCCalendar.month++;
            }
            LoadCalendar(ucStudentCalendar);
        }
        #endregion


        #region ucStudentTask1-Components

        private void ListTasks(UCStudentTask uCStudentTask)
        {
            uCStudentTask.flpGroupTaskView.Controls.Clear();
            var studentGroup = _studentRepository.GetById(_userSessionHelper.UserID);
            var groupTaskList = _taskRepository.GetByGroupID(studentGroup.group_id.Value);
            LoadTask(groupTaskList, uCStudentTask.flpGroupTaskView, new Size(490, 150), studentGroup.group_id.Value);



            var subTaskList = _subtaskRepository.GetAllByStudentId(_userSessionHelper.UserID);
            LoadSubTasks(subTaskList.ToList(), uCStudentTask.flpAllInvidualTasksView, new Size(450, 150));
        }

        private void LoadTask(List<Task> Tasks, FlowLayoutPanel flp, Size size, int groupID)
        {
            var filterHelper = new FilterByDayHelper(Tasks, _context);

            flp.Visible = false;
            flp.Controls.Clear();
            foreach (var groupTask in Tasks)
            {

                UCTask uCTask = new UCTask();
                uCTask.Size = size;
                uCTask.Name = groupTask.task_name;
                uCTask.Id = groupTask.task_id;
                uCTask.txtProjectDetail.Text = groupTask.task_description;
                uCTask.GroupID = groupID;
                var openDay = groupTask.open_day.Value;
                var deadline = groupTask.due_date.Value;
                uCTask.lblOpenDay.Text = openDay.ToString("dd/MM/yyyy");
                uCTask.lblDeadline.Text = deadline.ToString("dd/MM/yyyy");
                if (groupTask.submit_day != null) { uCTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38__2_1; }
                else { uCTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38; }
                uCTask.Clicked += ucTask_Clicked;
                uCTask.ChatButtonClicked += btnChat_Clicked;
                uCTask.Size = new Size(490, 150);
                uCStudentTask.flpGroupTaskView.Controls.Add(uCTask);

            }



            var subTaskList = _subtaskRepository.GetAllByStudentId(_userSessionHelper.UserID);

            //add data to subtask flow layout panel
            uCStudentTask.flpAllInvidualTasksView.Controls.Clear();
            foreach (var subTask in subTaskList)
            {

                UCInvidualTask uCInvidualTask = new UCInvidualTask();
                uCInvidualTask.Size = new Size(450, 150);
                uCInvidualTask.lblName.Text = subTask.subtask_name;
                uCInvidualTask._id = subTask.subtask_id;
                uCInvidualTask.txtProjectDetail.Text = subTask.subtask_description;
                var deadline = subTask.due_date.Value;
                uCInvidualTask.lblDeadline.Text = deadline.ToString("dd/MM/yyyy");
                if (subTask.submit_day != null) { uCInvidualTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38__2_; }
                else { uCInvidualTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38; }
                uCInvidualTask.Clicked += ucInvidual_Clicked;
                uCStudentTask.flpAllInvidualTasksView.Controls.Add(uCInvidualTask);
            }
        }

                flp.Controls.Add(uCTask);
            }

            flp.Visible = true;
        }

        private void LoadSubTasks(List<SubTask> subTaskList, FlowLayoutPanel flp, Size size)
        {
            flp.Controls.Clear();

            if (subTaskList.Count > 0)
            {
                flp.Visible = false;
                var filterHelper = new FilterByDayHelper(subTaskList, _context);
                foreach (var subTask in subTaskList)
                {

                    UCSubTasks uCSubTask = new UCSubTasks();
                    uCSubTask.Size = size;
                    uCSubTask.lblMember.Text = _studentRepository.GetById(subTask.student_id.Value).student_name;
                    uCSubTask.lblName.Text = subTask.subtask_name;
                    uCSubTask._id = subTask.subtask_id;
                    uCSubTask.txtProjectDetail.Text = subTask.subtask_description;
                    uCSubTask.txtProjectDetail.Width = size.Width-30;
                    var deadline = subTask.due_date.Value;
                    uCSubTask.lblDeadline.Text = deadline.ToString("dd/MM/yyyy");
                    if (subTask.submit_day != null)
                    {
                        uCSubTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38__2_;
                        uCSubTask.btnSubmit.Text = "EDIT";
                    }
                    else { uCSubTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38; }
                    uCSubTask.submitTaskBtnClicked += SubmitSubTask_Clicked;
                    flp.Controls.Add(uCSubTask);
                }
                flp.Visible = true;
            }
        }

        #endregion

        #region ucTask-Events

        // when click on a Group task -> show subtask 

        private void ucTask_Clicked(object sender, EventArgs e)
        {
            UCTask uCTask = sender as UCTask;
            var taskID = uCTask.Id;
            var groupID = uCTask.GroupID;

            uCTask.Parent.Parent.Hide();

            UCSTudentSubTasks ucsTudentSubTasks2 = new UCSTudentSubTasks();
            ucsTudentSubTasks2._taskID = uCTask.Id;
            var subTaskList = _subtaskRepository.GetAllByTaskId(taskID);
            ucsTudentSubTasks2.previousPtbClicked += task_Click;
            ucsTudentSubTasks2.AssignTaskBtnClicked += AssignTaskBtn_Clicked;
            LoadSubTasks(subTaskList.ToList(), ucsTudentSubTasks2.flpAllTasks, new Size(600, 150));
            foreach (Control control in ucsTudentSubTasks2.flpAllTasks.Controls)
            {
                if (control is UCSubTasks)
                {
                    UCSubTasks subTask = (UCSubTasks)control;
                    subTask.btnSubmit.Visible = false;
                }
            }

            //add data student member group
            ucsTudentSubTasks2.flpAllMemberView.Controls.Clear();
            var memberList = _studentRepository.GetAllByGroupId(groupID);
            foreach (var member in memberList)
            {
                UCStudentInformation uCStudentInformation = new UCStudentInformation();
                uCStudentInformation._id = member.student_id;
                uCStudentInformation.Clicked += ucStudentInformation_Clicked;
                uCStudentInformation.lblName.Text = member.student_name;
                ucsTudentSubTasks2.flpAllMemberView.Controls.Add(uCStudentInformation);
            }
            panelContainer.Controls.Clear();
            ucsTudentSubTasks2.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucsTudentSubTasks2);
        }

        private void btnChat_Clicked(object sender, EventArgs e)
        {
            UCTask uCTask = sender as UCTask;
            var task = _taskRepository.GetById(uCTask.Id);
            FChat fChat = new FChat(task);
            fChat.Show();
        }

        #endregion

        #region ucStudentSubTask-Events
        private void AssignTaskBtn_Clicked(object sender, int id)
        {
            FStudentCreateSubTask fStudentCreateSubTask = new FStudentCreateSubTask(id, _context);
            fStudentCreateSubTask.Show();
        }
        #endregion

        #region ucStudentInformation-Events
        private void ucStudentInformation_Clicked(object sender, EventArgs e)
        {
            UCStudentInformation uCStudentInformation = sender as UCStudentInformation;
            UCSTudentSubTasks uCSTudentSubTasks = (UCSTudentSubTasks)uCStudentInformation.Parent.Parent.Parent;
            uCSTudentSubTasks.flpAllTasks.Controls.Clear();
            var subTask = _subtaskRepository.GetByStudentIdAndTaskId(uCStudentInformation._id, uCSTudentSubTasks._taskID);
            List<SubTask> subTaskList = new List<SubTask>();
            if (subTask != null) subTaskList.Add(subTask);
            LoadSubTasks(subTaskList, uCSTudentSubTasks.flpAllTasks, new Size(600, 150));
        }
        #endregion

        #region uCInvidualTask-Events
        //when click on a submit button --> show a submit form
        private void SubmitSubTask_Clicked(object sender, EventArgs e)
        {

            UCSubTasks uCSubTasks = sender as UCSubTasks;
            var subTask = _subtaskRepository.GetById(uCSubTasks._id);
            FStudentTaskPopUp fStudentTaskPopUp = new FStudentTaskPopUp(subTask, _context);
            fStudentTaskPopUp.ShowDialog();
        }
 

        #endregion

        #region uCProgress-Events
        private void ListUCProgressComponents(UCProgress uCProgress)
        {
            uCProgress.cbxGroupCategory.Visible = false;
            uCProgress.cbxMemberCategory.Visible = false;
            uCProgress.lblgroup.Visible = false;

            uCProgress._cbDateTimeChanged += CbDateTime_ValueChanged;
            //load data to datagridview
            var subTaskList = _subtaskRepository.GetAllByStudentId(_userSessionHelper.UserID);
            LoadPointDataGridView(uCProgress.dgvPoint, subTaskList.ToList());

            //load data to subtask chart


            LoadSubTaskProgressChart(uCProgress.SubTaskProgessChart, subTaskList.ToList());

            //
            var student = _studentRepository.GetById(_userSessionHelper.UserID);
            var groupTaskList = _taskRepository.GetByGroupID(student.group_id.Value);
            LoadGroupTaskProgressChart(uCProgress.GroupTaskProgessChart, groupTaskList.ToList());
        }
        private void CbDateTime_ValueChanged(object sender, EventArgs e)
        {
            UCProgress uCProgress = sender as UCProgress;
            string selectedValue = uCProgress.cbxDateTime.SelectedItem.ToString();
            var subTaskList = _subtaskRepository.GetAllByStudentId(_userSessionHelper.UserID).ToList();
            var filterHelper = new FilterByDayHelper(subTaskList, _context);
            if (selectedValue == "Final Point")
            {
                var studentPoint = _studentPointRepository.GetByStudentId(_userSessionHelper.UserID);
                if (studentPoint != null)
                {
                    List<StudentPoint> studentPointList = new List<StudentPoint>();
                    studentPointList.Add(studentPoint);
                    LoadFinalPointDataGridView(uCProgress.dgvPoint, studentPointList);
                }
            }
            else
            {
                if (selectedValue == "This Week")
                {
                    subTaskList = filterHelper.FilterSubTaskByWeek();
                }
                else if (selectedValue == "This Month")
                {
                    subTaskList = filterHelper.FilterSubTaskByMonth();
                }
                else if (selectedValue == "Last Month")
                {
                    subTaskList = filterHelper.FilterSubTaskByLastMonth();
                }
                else if (selectedValue == "All")
                {

                }
                LoadPointDataGridView(uCProgress.dgvPoint, subTaskList);
            }
        }
        private void LoadPointDataGridView(DataGridView pointDataGridView, List<SubTask> subTaskList)
        {
            // Xóa các cột hiện tại của DataGridView
            pointDataGridView.Columns.Clear();

            // Tạo một DataTable mới
            DataTable dataTable = new DataTable();

            // Thêm các cột vào DataTable
            dataTable.Columns.Add("SubTaskName", typeof(string));
            dataTable.Columns.Add("SubTaskPoint", typeof(float));
            // Thêm dữ liệu vào DataTable
            foreach (var subTask in subTaskList)
            {
                var subTaskPoint = _subtaskPointRepository.GetBySubtaskId(subTask.subtask_id);
                dataTable.Rows.Add(subTask.subtask_name, subTaskPoint);
            }

            // Gán DataTable cho DataGridView
            pointDataGridView.DataSource = dataTable;
        }

        private void LoadFinalPointDataGridView(DataGridView pointDataGridView, List<StudentPoint> studentPointList)
        {
            // Xóa các cột hiện tại của DataGridView
            pointDataGridView.Columns.Clear();

            // Tạo một DataTable mới
            DataTable dataTable = new DataTable();

            // Thêm các cột vào DataTable
            dataTable.Columns.Add("Student Name", typeof(string));
            dataTable.Columns.Add("Student Point", typeof(float));
            // Thêm dữ liệu vào DataTable
            foreach (var studentPoint in studentPointList)
            {
                var student = _studentRepository.GetById(_userSessionHelper.UserID);
                dataTable.Rows.Add(student.student_name, studentPoint.student_point);
            }

            // Gán DataTable cho DataGridView
            pointDataGridView.DataSource = dataTable;
        }

        private void LoadSubTaskProgressChart(Chart subTaskChart, List<SubTask> subTaskList)
        {
            SubTask subTask = subTaskList.FirstOrDefault(subtask => subtask != null);
            if (subTask != null)
            {
                var completedSubTasks = _subtaskRepository.GetNumberOfCompletedSubTaskOfStudents(_userSessionHelper.UserID);
                var uncompletedSubTasks = _subtaskRepository.GetNumberOfUncompletedSubTaskOfStudents(_userSessionHelper.UserID);
                var lateSubmittedSubTasks = _subtaskRepository.GetNumberOfLateSubmittedSubTasksOfStudents(_userSessionHelper.UserID);

                subTaskChart.Series["s1"].Points.Clear();
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
                //MessageBox.Show(completedSubTasks + " " + uncompletedSubTasks + " " + lateSubmittedSubTasks);
            }

        }
        private void LoadGroupTaskProgressChart(Chart groupTaskChart, List<Task> groupTaskList)
        {
            Task groupTask = groupTaskList.FirstOrDefault(task => task != null);
            if (groupTask != null)
            {
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
        }

        #endregion
        private bool TopicRegisterReminder()
        {
            var student = _studentRepository.GetById(_userSessionHelper.UserID);
            var registrationService = new RegistrationService(student, _context);
            if (registrationService.AlreadyRegistered())
            {
                return true;
            }

            string message = "You have not registered topic. Do you want to register one?";
            string title = "Topic Reminder";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                FStudentRegisterTopic fStudentRegisterTopic = new FStudentRegisterTopic(_context);
                fStudentRegisterTopic.Show();
                this.Hide();
                return false;
            }
            else
            {
                return false;
            }
        }

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
    }
}
