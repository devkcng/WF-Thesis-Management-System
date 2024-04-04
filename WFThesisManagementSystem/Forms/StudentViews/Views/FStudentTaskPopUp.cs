using System;
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
            public FStudentTaskPopUp(int subtaskID)
            {
                InitializeComponent();
                _subTaskService = new SubTaskService(subtaskID);
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
