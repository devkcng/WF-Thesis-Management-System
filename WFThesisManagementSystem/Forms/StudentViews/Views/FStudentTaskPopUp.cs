using System;
using System.Drawing;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;

namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    public partial class FStudentTaskPopUp : Form
    {
        StudentRepository _studentRepository;
        SubTaskService _subTaskService;
        ThesisManagementContext _context;
        SubTask _subTask;
        public FStudentTaskPopUp(SubTask subTask, ThesisManagementContext context)
        {
            InitializeComponent();
            this.Size = new Size(500, 600);
            _context = context;
            _studentRepository = new StudentRepository(_context);
            _subTask = subTask;
        }


        private void lblSubTaskName_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _subTask.document_link = txtDocumentLink.Text;
            _subTaskService = new SubTaskService(_subTask, _context);
            _subTaskService.SubmitSubTask();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _subTask.document_link = txtDocumentLink.Text;
            _subTaskService = new SubTaskService(_subTask, _context);
            _subTaskService.UpdateSubTask();
            this.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            txtDocumentLink.Enabled = true;
            saveBtn.Enabled = true;
        }

        private void FStudentTaskPopUp_Load(object sender, EventArgs e)
        {
            lblSubTaskName.Text = _subTask.subtask_name;
            lblStudentname.Text = _studentRepository.GetById(_subTask.student_id.Value).student_name;
            lblSubmitDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if (_subTask.submit_day != null)
            {
                ptbStatus.Image = Properties.Resources.photo_2024_04_02_16_52_38;
                txtDocumentLink.Enabled = false;
                btnSubmit.Hide();
                editBtn.Show();
                saveBtn.Show();
                saveBtn.Enabled = false;
            }
        }
    }
}
