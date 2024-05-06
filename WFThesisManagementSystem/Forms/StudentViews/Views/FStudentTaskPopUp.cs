using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;

namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    public partial class FStudentTaskPopUp : Form
    {
        SubTaskService _subTaskService;
        ThesisManagementContext _context;
        public FStudentTaskPopUp(SubTask subTask, ThesisManagementContext context)
        {
            InitializeComponent();
            this.Size = new Size(500, 600);
            _context=context;
            _subTaskService = new SubTaskService(subTask, _context);
        }


        private void lblSubTaskName_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _subTaskService.SubmitSubTask();
        }
    }
}
