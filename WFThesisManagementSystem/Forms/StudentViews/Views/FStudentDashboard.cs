using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl;
using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Forms.UC;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using System.Collections.Generic;

using UserControl = System.Windows.Forms.UserControl;
using WFThesisManagementSystem.Services;
using System.Web.UI.WebControls;
using System.Reflection.Emit;
using WFThesisManagementSystem.Forms.TeacherViews.Views;
using System.Security.Cryptography;

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
        public FStudentDashboard()
        {
            _context = new ThesisManagementContext();
            _studentRepository = new StudentRepository(_context);
            _taskRepository = new TaskRepository(_context);
            _subtaskRepository = new SubTaskRepository(_context);
            _studentgroupRepository = new StudentGroupRepository(_context);
            _topicRepository = new TopicRepository(_context);
            _teacherRepository = new TeacherRepository(_context);
            InitializeComponent();
            btnNotification.Click += createNotification;
        }

        private void createNotification(object sender, EventArgs e)
        {   
            if(!TopicRegisterReminder())
            {
                return;
            }
            FNotification fNotification = new FNotification(_context);
            fNotification.Show();
        }

        private void CbTaskDate_ValueChanged(object sender, EventArgs e)
        {
            if(!TopicRegisterReminder())
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
                groupTaskList = filterHelper.FilterByWeek();
            }
            else if (uCStudentProject.CbTaskDate.SelectedItem == "This month")
            {
                groupTaskList = filterHelper.FilterByMonth();
            }
            else if (uCStudentProject.CbTaskDate.SelectedItem == "All")
            {
                groupTaskList = filterHelper.GetSortedTasks();
            }
            LoadTask(groupTaskList, uCStudentProject.flpTask, new Size(380, 150), groupID.Value);
        }
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(!TopicRegisterReminder())
            {
                return;
            }
            UCStudentTask uCStudentTask = sender as UCStudentTask;
            uCStudentTask.flpGroupTaskView.Controls.Clear();
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value);
            var filterHelper = new FilterByDayHelper(groupTaskList, _context);
            var taskListFiltered = filterHelper.FilterByDay(uCStudentTask.dtpStartDay.Value, uCStudentTask.dtpEndDay.Value);
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
                uCStudentTask.flpGroupTaskView.Controls.Add(uCTask);
            }
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            if(!TopicRegisterReminder())
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
            if(!TopicRegisterReminder())
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
            UCStudentWorkLogs uCStudentWorkLogs = new UCStudentWorkLogs();
            uCStudentWorkLogs.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uCStudentWorkLogs);
        }



        private void logout_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            fLogin.Show();
            this.Hide();
        }

        private void performance_Click(object sender, EventArgs e)
        {
            if(!TopicRegisterReminder())
            {
                return;
            }
        }

        private void UCStudentTask_Load(UCStudentTask uCStudentTask)
        {
            ListTasks(uCStudentTask);
        }
        private void UCDashBoard_Load(UCDashBoard ucDashBoard)
        {
            //ListDashboardComponent(ucDashBoard);
        }

        #region UCStudentProject-Components
        private void ListUCStudentProjectComponent(UCStudentProject uCStudentProject)
        {
            var student = _studentRepository.GetById(_userSessionHelper.UserID);
            var studentGroup = _studentgroupRepository.GetById(student.group_id.Value);
            var studentTopic = _topicRepository.GetById(studentGroup.topic_id.Value);
            var memberGroupList = _studentRepository.GetAllByGroupId(studentGroup.group_id);
            var taskLisk = _taskRepository.GetByGroupID(studentGroup.group_id);
            FilterByDayHelper filterByDayHelper = new FilterByDayHelper(taskLisk,_context);


            //Loadtopic
            LoadTopic(uCStudentProject, studentTopic);

            //Load Group member
            LoadGroupMember(uCStudentProject, memberGroupList.ToList());

            //Load task
            LoadTask(filterByDayHelper.GetSortedTasks(), uCStudentProject.flpTask, new Size(380, 150), studentGroup.group_id);
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

        private void LoadGroupMember (UCStudentProject uCStudentProject, List<Student> memberGroup)
        {
            uCStudentProject.flpMember.Controls.Clear();
            foreach (var member in memberGroup)
            {
                UCStudentInformation uCStudentInformation = new UCStudentInformation();
                uCStudentInformation.lblName.Text = member.student_name;
                uCStudentProject.flpMember.Controls.Add(uCStudentInformation);
            }

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
            var filteredDates = groupTaskList.Where(grouptask => (grouptask.due_date - currentDate).Value.Days <= 7 && grouptask.due_date> currentDate);
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
            var submitDates = groupTaskList.Select(groupTask => groupTask.due_date);

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
                if (submitDates.Contains(currentDate))
                {
                    uCDay.ptb1.FillColor = Color.Red;
                    uCDay.ptb1.Visible = true;
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
            UCStudentCalendar  ucStudentCalendar  = (UCStudentCalendar)uCCalendar.Parent.Parent; // Tìm UCDashBoard từ UCCalendar

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
            var groupID = _studentRepository.GetById(_userSessionHelper.UserID).group_id;
            var groupTaskList = _taskRepository.GetByGroupID(groupID.Value);
            var filterHelper = new FilterByDayHelper(groupTaskList, _context);
            groupTaskList = filterHelper.GetSortedTasks();
            foreach (var groupTask in groupTaskList)
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
            //add data to subtask flow layout panel
            ucsTudentSubTasks2.flpAllTasks.Controls.Clear();
            foreach (var subTask in subTaskList)
            {
                UCSubTasks uCSubTask = new UCSubTasks();
                uCSubTask.lblName.Text = subTask.subtask_name;
                uCSubTask.txtProjectDetail.Text = subTask.subtask_description;
                var openDay = subTask.open_day.Value;
                var deadline = subTask.due_date.Value;
                uCSubTask.lblOpenDay.Text = openDay.ToString("dd/MM/yyyy");
                uCSubTask.lblDeadline.Text = deadline.ToString("dd/MM/yyyy");
                uCSubTask.lblMember.Text = _studentRepository.GetById(subTask.student_id.Value).student_name;
                if (subTask.submit_day != null) { uCSubTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38__2_1; }
                else { uCSubTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38; }
                ucsTudentSubTasks2.flpAllTasks.Controls.Add(uCSubTask);
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
            var taskList = _subtaskRepository.GetAllByStudentIdAndTaskId(uCStudentInformation._id, uCSTudentSubTasks._taskID);
            foreach(var subTask in taskList)
            {
                UCSubTasks uCSubTask = new UCSubTasks();
                uCSubTask.lblName.Text = subTask.subtask_name;
                uCSubTask.txtProjectDetail.Text = subTask.subtask_description;
                var openDay = subTask.open_day.Value;
                var deadline = subTask.due_date.Value;
                uCSubTask.lblOpenDay.Text = openDay.ToString("dd/MM/yyyy");
                uCSubTask.lblDeadline.Text = deadline.ToString("dd/MM/yyyy");
                uCSubTask.lblMember.Text = _studentRepository.GetById(subTask.student_id.Value).student_name;
                if (subTask.submit_day != null) { uCSubTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38__2_1; }
                else { uCSubTask.ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38; }
                uCSTudentSubTasks.flpAllTasks.Controls.Add(uCSubTask);
            }
        }
        #endregion

        #region uCInvidualTask-Events
        //when click on a submit button --> show a submit form
        private void ucInvidual_Clicked(object sender, EventArgs e)
        {

            UCInvidualTask uCInvidualTask = sender as UCInvidualTask;
            var subTask = _subtaskRepository.GetById(uCInvidualTask._id);
            if (subTask.submit_day != null)
            {
                MessageBox.Show("This task has been submitted");
            }
            else
            {

                FStudentTaskPopUp fStudentTaskPopUp = new FStudentTaskPopUp(subTask,_context);
                fStudentTaskPopUp.lblSubTaskName.Text = uCInvidualTask.lblName.Text;
                fStudentTaskPopUp.lblStudentname.Text = _studentRepository.GetById(subTask.student_id.Value).student_name;
                fStudentTaskPopUp.lblSubmitDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                fStudentTaskPopUp.ShowDialog();
            }
        }


        #endregion

        private void ucStudentProject1_Load(object sender, EventArgs e)
        {
            
        }

        private void ucStudentTask1_Load(object sender, EventArgs e)
        {
            
        }

        private bool TopicRegisterReminder()
        {   
            var student = _studentRepository.GetById(_userSessionHelper.UserID);
            var registrationService = new RegistrationService(student,_context);
            if (registrationService.AlreadyRegistered())
            {
                return true;
            }

            string message = "You have not registered topic. Do you want to register one?";
            string title = "Topic Reminder";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) {
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
