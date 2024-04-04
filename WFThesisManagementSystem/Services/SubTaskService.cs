using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Services
{
    //
    internal class SubTaskService
    {
        SubTaskRepository _subTaskRepository;
        TaskRepository _taskRepository;
        ThesisManagementContext _context;
        private int _subtaskID;
        public SubTaskService(int subtaskID)
        {
            _context = new ThesisManagementContext();
            _subTaskRepository = new SubTaskRepository(_context);
            _taskRepository = new TaskRepository(_context);
            _subtaskID = subtaskID;
        }
        public void SubmitSubTask()
        {
            // update task status to submitted
            var subtask = _subTaskRepository.GetById(_subtaskID);
            subtask.submit_day = System.DateTime.Now;
            _subTaskRepository.Update(subtask);
            MessageBox.Show("Submit successfully");
            var subtaskList = _subTaskRepository.GetAllById(subtask.subtask_id);
            if (IsTaskDone(subtaskList))
            {
                var task =_taskRepository.GetById(subtask.task_id.Value);
                task.submit_day = DateTime.Now;
                _taskRepository.Update(task);
                MessageBox.Show("Your group task has been done");

            }
        }



        public bool IsTaskDone(IQueryable<SubTask> subTasks)
        {
            foreach (var subTask in subTasks)
            {
                if (subTask.submit_day == null)
                {
                    return false;
                }
            }
            return true;
        }

    }
}

