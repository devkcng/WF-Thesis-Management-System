using System;
using System.Linq;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.StudentViews.StudentUserControl;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Forms.StudentViews.Views
{
    public partial class FStudentTaskPopUp : Form
    {
        SubTask subTask = new SubTask();
        SubTaskRepository _subTaskRepository;
        ThesisManagementContext _context;

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public FStudentTaskPopUp()
        {
            InitializeComponent();
            _context = new ThesisManagementContext();
            _subTaskRepository = new SubTaskRepository(_context);
        }


        private void lblSubTaskName_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var subTask = _subTaskRepository.GetById(Id);
            subTask.submit_day = DateTime.Now;
            _subTaskRepository.Update(subTask);
            MessageBox.Show("Added Successfully");
        }
    }
}
