﻿using System;
using System.Windows.Forms;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Services;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    public partial class FTeacherEditTask : Form
    {
        private Task _task;
        private ThesisManagementContext _context;
        public FTeacherEditTask(Task task, ThesisManagementContext context)
        {
            InitializeComponent();
            _context = context;
            _task = task;
            ucTeacherEditTask1.DeleteButtonClicked += Delete;
            ucTeacherEditTask1.UpdateButtonClicked += Update;
            ucTeacherEditTask1.CloseButtonClicked += Close;
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Update(object sender, EventArgs e)
        {
            try
            {

                var task = new Task
                {
                    task_id = _task.task_id,
                    task_name = ucTeacherEditTask1.txtTaskName.Text,
                    task_description = ucTeacherEditTask1.txtTaskDescription.Text,
                    open_day = _task.open_day,
                    due_date = ucTeacherEditTask1.dtpDueDate.Value,
                    submit_day = _task.submit_day,
                    group_id = _task.group_id
                };

                var taskService = new TaskService(task, _context);

                taskService.UpdateTask();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Delete(object sender, EventArgs e)
        {
            var taskService = new TaskService(_task, _context);
            taskService.DeleteTask();
            this.Close();
        }

        private void FTeacherEditTask_Load_1(object sender, EventArgs e)
        {   
            ucTeacherEditTask1.txtTaskDescription.Text = _task.task_description;
            ucTeacherEditTask1.txtTaskName.Text = _task.task_name;
            ucTeacherEditTask1.dtpDueDate.Value = _task.due_date.Value;
        }
    }
}
