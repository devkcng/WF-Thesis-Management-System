using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    public partial class FTeacherMark : Form
    {
        ThesisManagementContext _context;
        TaskRepository _taskRepository;
        StudentGroupRepository _studentGroupRepository;
        ValidationInformationHelper _validationInformationHelper;
        TaskService _taskService;
        Dictionary<int, double> mark = new Dictionary<int, double>();

        public FTeacherMark(ThesisManagementContext context)
        {
            _context = context;
            _taskRepository = new TaskRepository(_context);
            _studentGroupRepository = new StudentGroupRepository(_context);
            _validationInformationHelper = new ValidationInformationHelper();
            _taskService = new TaskService(_context);
            InitializeComponent();
            ucTeacherAllMark1.btnClose.Click += Close;
            ucTeacherAllMark1.btnSave.Click += Save;
        }
        private void Close(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void TaskLoad()
        {
            ucTeacherAllMark1.flpAllStudentMark.Controls.Clear();
            foreach (var task in _taskRepository.GetAll())
            {
                UcTeacherSingleMark ucTeacherSingleMark = new UcTeacherSingleMark();
                ucTeacherSingleMark.NameTask = task.task_name;
                ucTeacherSingleMark.DescriptionTask = task.task_description;
                ucTeacherSingleMark.NameStudent = _studentGroupRepository.GetById(task.group_id.Value).group_name.ToString();
                ucTeacherSingleMark.lblCheck.ForeColor = Color.Black;
                ucTeacherSingleMark.lblCheck.Text = "UnCompletely";
                ucTeacherAllMark1.flpAllStudentMark.Controls.Add(ucTeacherSingleMark);
            }
            ucTeacherAllMark1.flpAllStudentMark.Show();
        }
        private void LoadSave()
        {
            foreach (var studentGroup in _studentGroupRepository.GetAll())
            {
                mark[studentGroup.group_id] = 0;
            }
            bool check = false;
            foreach (var item in ucTeacherAllMark1.flpAllStudentMark.Controls)
            {
                if (item is UserControl)
                {
                    UcTeacherSingleMark ucTeacherSingleMark = (UcTeacherSingleMark)item;
                    ucTeacherSingleMark.lblCheck.ForeColor = Color.Red;
                    ucTeacherSingleMark.lblCheck.Text = "Completely";
                    ucTeacherSingleMark.EditButton += EventEditButton;
                    var task = _taskRepository.GetTaskByTaskName(ucTeacherSingleMark.NameTask);

                    if (!string.IsNullOrEmpty(ucTeacherSingleMark.txtMark.Text))
                    {
                        if (_validationInformationHelper.CheckMarkValid(ucTeacherSingleMark.txtMark.Text) == 1)
                        {
                            mark[task.group_id.Value] += int.Parse(ucTeacherSingleMark.txtMark.Text);
                            check = true;
                        }
                        else if (_validationInformationHelper.CheckMarkValid(ucTeacherSingleMark.txtMark.Text) == 2)
                        {
                            mark[task.group_id.Value] += double.Parse(ucTeacherSingleMark.txtMark.Text);
                            check = true;
                            
                        }

                    }
                    ucTeacherSingleMark.txtMark.Enabled = false;
                }

            }
            if (check) { MessageBox.Show("Save Mark Completely"); }
            else MessageBox.Show("Mark Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            foreach (var key in mark.Keys)
            {
                var studentgroup = _studentGroupRepository.GetById(key);
                studentgroup.group_points = mark[key] / _taskService.NumberTask(key);
                _studentGroupRepository.Update(studentgroup);
            }
        }
        private void EventEditButton(object sender, EventArgs e)
        {
            UcTeacherSingleMark ucTeacherSingleMark = sender as UcTeacherSingleMark;
            ucTeacherSingleMark.txtMark.Enabled = true;
        }
        private void Save(object sender, EventArgs e)
        {
            LoadSave();
        }
        private void FTeacherMark_Load(object sender, EventArgs e)
        {
            TaskLoad();
            foreach (var studentGroup in _studentGroupRepository.GetAll())
            {
                mark[studentGroup.group_id] = 0;
            }
        }
    }
}
