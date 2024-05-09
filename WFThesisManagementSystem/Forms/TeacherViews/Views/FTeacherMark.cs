using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    public partial class FTeacherMark : Form
    {
        ThesisManagementContext _context;
        TaskRepository _taskRepository;
        StudentGroupRepository _studentGroupRepository;
        ValidationInformationHelper _validationInformationHelper;
        SubTaskRepository _subTaskRepository;
        TaskService _taskService;
        StudentRepository _studentRepository;
        SubtaskPointRepository _subtaskPointRepository;
        StudentPointRepository _studentPointRepository;
        Dictionary<int, double> mark = new Dictionary<int, double>();
        int TaskId;
        string studentName;
        IdGeneratorHelper IdGeneratorHelper;

        public FTeacherMark(ThesisManagementContext context, int task_id)
        {
            _context = context;
            _taskRepository = new TaskRepository(_context);
            _studentGroupRepository = new StudentGroupRepository(_context);
            _validationInformationHelper = new ValidationInformationHelper();
            _taskService = new TaskService(_context);
            _subTaskRepository = new SubTaskRepository(_context);
            _studentRepository = new StudentRepository(_context);
            _subtaskPointRepository = new SubtaskPointRepository(_context);
            _studentPointRepository = new StudentPointRepository(_context);
            IdGeneratorHelper = new IdGeneratorHelper();
            TaskId = task_id;
            InitializeComponent();
            ucTeacherAllMark1.btnClose.Click += Close;
            ucTeacherAllMark1.btnSave.Click += Save;
        }
        private void Close(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void ShowGroup()
        {
            var task = _taskRepository.GetAll().FirstOrDefault(x => x.task_id == TaskId);
            var students = _studentRepository.GetAll().Where(x => x.group_id == task.group_id);
            ucTeacherAllMark1.lblTaskName.Text = task.task_name;
            foreach (var student in students)
            {
                ucTeacherAllMark1.cbxStudent.Items.Add(student.student_name);
            }
            ucTeacherAllMark1.ucTeacherSubTaskSmall2.ClickLink += UcTeacherSubTaskSmall2_ClickLink;
            ucTeacherAllMark1.cbxStudent.SelectedIndexChanged += Value_change;


        }

        private void UcTeacherSubTaskSmall2_ClickLink(object sender, EventArgs e)
        {
            UcTeacherSubTaskSmall ucTeacherSubTaskSmall = (UcTeacherSubTaskSmall)sender;
            Process.Start($"{ucTeacherSubTaskSmall.lblLinkDocument.Text}");
        }

        private void Value_change(object sender, EventArgs e)
        {
            try
            {
                ComboBox comboBox = (ComboBox)sender;
                var student = _studentRepository.GetAll().FirstOrDefault(x => x.student_name == comboBox.SelectedItem.ToString());
                var subtask = _subTaskRepository.GetAll().FirstOrDefault(x => x.student_id == student.student_id && x.task_id == TaskId);
                studentName = comboBox.SelectedItem.ToString();

                ucTeacherAllMark1.ucTeacherSubTaskSmall2.lblSubTaskName.Text = subtask.subtask_name;
                if (subtask.submit_day != null)
                {
                    ucTeacherAllMark1.ucTeacherSubTaskSmall2.icmCheckbox.Checked = true;
                }
                ucTeacherAllMark1.ucTeacherSubTaskSmall2.txtDescription.Text = subtask.subtask_description;
                ucTeacherAllMark1.ucTeacherSubTaskSmall2.lblLinkDocument.Text = subtask.document_link;
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show("There is no subtask for this student", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK) this.Hide();

            }
        }

        private void TaskLoad()
        {


            //ucTeacherAllMark1.flpAllStudentMark.Controls.Clear();
            //foreach (var task in _taskRepository.GetAll())
            //{
            //    UcTeacherSingleMark ucTeacherSingleMark = new UcTeacherSingleMark();
            //    ucTeacherSingleMark.NameTask = task.task_name;
            //    ucTeacherSingleMark.DescriptionTask = task.task_description;
            //    ucTeacherSingleMark.NameStudent = _studentGroupRepository.GetById(task.group_id.Value).group_name.ToString();
            //    ucTeacherSingleMark.lblCheck.ForeColor = Color.Black;
            //    ucTeacherSingleMark.lblCheck.Text = "UnCompletely";
            //    ucTeacherAllMark1.flpAllStudentMark.Controls.Add(ucTeacherSingleMark);
            //}
            //ucTeacherAllMark1.flpAllStudentMark.Show();
        }
        private void LoadSave()
        {
            try
            {
                var student = _studentRepository.GetAll().FirstOrDefault(x => x.student_name == studentName);
                var subtask = _subTaskRepository.GetAll().FirstOrDefault(x => x.student_id == student.student_id && x.task_id == TaskId);
                var Subtaskpoint = _subtaskPointRepository.GetAll().FirstOrDefault(x => x.subtask_id == subtask.subtask_id);
                if (Subtaskpoint == null)
                {
                    if (!string.IsNullOrEmpty(ucTeacherAllMark1.ucTeacherSingleMark1.txtPoint.Text))
                    {
                        bool check = false;
                        var subtaskpoint = new SubtaskPoint();
                        subtaskpoint.subtask_id = subtask.subtask_id;
                        subtaskpoint.student_id = student.student_id;
                        if (_validationInformationHelper.CheckMarkValid(ucTeacherAllMark1.ucTeacherSingleMark1.txtPoint.Text) == 1)
                        {
                            subtaskpoint.subtask_point = int.Parse(ucTeacherAllMark1.ucTeacherSingleMark1.txtPoint.Text);
                            check = true;
                        }
                        else if (_validationInformationHelper.CheckMarkValid(ucTeacherAllMark1.ucTeacherSingleMark1.txtPoint.Text) == 2)
                        {
                            subtaskpoint.subtask_point = double.Parse(ucTeacherAllMark1.ucTeacherSingleMark1.txtPoint.Text);
                            check = true;

                        }
                        subtaskpoint.subtaskpoint_id = IdGeneratorHelper.GenerateSubtaskPointId();
                        if (check)
                        {
                            MessageBox.Show("Save Mark Completely");
                            _subtaskPointRepository.Add(subtaskpoint);
                        }
                        else MessageBox.Show("Mark Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("This subtask has been graded", "Notification", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                    if (result == DialogResult.OK) { this.Hide(); }
                }
                if (_studentPointRepository.GetAll().FirstOrDefault(x => x.student_id == student.student_id) == null)
                {
                    var SubTaskAllStudent = _subTaskRepository.GetAll().Where(x => x.student_id == student.student_id);
                    bool checkSubtaskPoint = true;
                    double Point = 0;
                    int CountSubtask = 0;
                    foreach (var Subtask in SubTaskAllStudent)
                    {
                        var SubTaskPoint = _subtaskPointRepository.GetAll().FirstOrDefault(x => x.subtask_id == Subtask.subtask_id);
                        if (SubTaskPoint == null)
                        {
                            DialogResult result = MessageBox.Show("The subtask is not finished yet so the score can be updated", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (result == DialogResult.OK) { this.Hide(); }
                            checkSubtaskPoint = false;
                        }
                        else
                        {
                            Point += SubTaskPoint.subtask_point.Value;
                        }
                        CountSubtask++;

                    }
                    if (checkSubtaskPoint)
                    {
                        var studentPoint = new StudentPoint();
                        studentPoint.student_id = student.student_id;
                        studentPoint.studentpoint_id = IdGeneratorHelper.GenerateStudentPointId();
                        studentPoint.student_point = Point / CountSubtask;
                        _studentPointRepository.Add(studentPoint);
                        DialogResult result = MessageBox.Show("Students have been graded", "Notification", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                        if (result == DialogResult.OK) { this.Hide(); }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Students have been graded", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK) { this.Hide(); }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Students have not been selected yet", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
                

            //foreach (var studentGroup in _studentGroupRepository.GetAll())
            //{
            //    mark[studentGroup.group_id] = 0;
            //}
            //bool check = false;
            //foreach (var item in ucTeacherAllMark1.flpAllStudentMark.Controls)
            //{
            //    if (item is UserControl)
            //    {
            //        UcTeacherSingleMark ucTeacherSingleMark = (UcTeacherSingleMark)item;
            //        ucTeacherSingleMark.lblCheck.ForeColor = Color.Red;
            //        ucTeacherSingleMark.lblCheck.Text = "Completely";
            //        ucTeacherSingleMark.EditButton += EventEditButton;
            //        var task = _taskRepository.GetTaskByTaskName(ucTeacherSingleMark.NameTask);

            //        if (!string.IsNullOrEmpty(ucTeacherSingleMark.txtpoint.Text))
            //        {
            //            if (_validationInformationHelper.CheckMarkValid(ucTeacherSingleMark.txtpoint.Text) == 1)
            //            {
            //                mark[task.group_id.Value] += int.Parse(ucTeacherSingleMark.txtpoint.Text);
            //                check = true;
            //            }
            //            else if (_validationInformationHelper.CheckMarkValid(ucTeacherSingleMark.txtpoint.Text) == 2)
            //            {
            //                mark[task.group_id.Value] += double.Parse(ucTeacherSingleMark.txtpoint.Text);
            //                check = true;

            //            }

            //        }
            //        ucTeacherSingleMark.txtpoint.Enabled = false;
            //    }

            //}
            //if (check) { MessageBox.Show("Save Mark Completely"); }
            //else MessageBox.Show("Mark Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //foreach (var key in mark.Keys)
            //{
            //    var studentgroup = _studentGroupRepository.GetById(key);
            //    studentgroup.group_points = mark[key] / _taskService.NumberTask(key);
            //    _studentGroupRepository.Update(studentgroup);
            //}
        }
        private void EventEditButton(object sender, EventArgs e)
        {
            UcTeacherSingleMark ucTeacherSingleMark = sender as UcTeacherSingleMark;
            ucTeacherSingleMark.txtPoint.Enabled = true;
        }
        private void Save(object sender, EventArgs e)
        {
            LoadSave();
        }
        private void FTeacherMark_Load(object sender, EventArgs e)
        {
            ShowGroup();

        }
    }
}
