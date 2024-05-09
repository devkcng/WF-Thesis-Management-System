using System;
using System.Linq;
using System.Windows.Forms;
using WFThesisManagementSystem.Helper;
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
        public SubTask _subTask;

        public SubTaskService(SubTask subTask, ThesisManagementContext context)
        {
            _context = context;
            _subTask = subTask;
            _subTaskRepository = new SubTaskRepository(_context);
            _taskRepository = new TaskRepository(_context);
        }


        public void SubmitSubTask()
        {
            // update task status to submitted
            var subtask = _subTaskRepository.GetById(_subTask.subtask_id);
            subtask.submit_day = System.DateTime.Now;
            _subTaskRepository.Update(subtask);
            MessageBox.Show("Submit successfully");
            var subtaskList = _subTaskRepository.GetAllByTaskId(subtask.task_id.Value);
            if (IsTaskDone(subtaskList))
            {
                var task = _taskRepository.GetById(subtask.task_id.Value);
                task.submit_day = DateTime.Now;
                _taskRepository.Update(task);
                MessageBox.Show("Task " + task.task_name + " has been done");

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

        public void CreateSubTask()
        {
            var idGeneratorHelper = new IdGeneratorHelper();
            var subTask = new SubTask
            {
                subtask_id = idGeneratorHelper.GenerateSubTaskId(),
                subtask_name = _subTask.subtask_name,
                subtask_description = _subTask.subtask_description,
                task_id = _subTask.task_id,
                due_date = _subTask.due_date,
                student_id = _subTask.student_id,
                open_day = System.DateTime.Now
            };

            _subTaskRepository.Add(subTask);

            MessageBox.Show("Created");
        }
        // handle logic of updating a task by teacher
        public void UpdateSubTask()
        {
            _subTaskRepository.Update(_subTask);
            MessageBox.Show("Updated Subtask Successfully");
        }

        // handle logic of deleting a task by teacher
        public void DeleteSubTask()
        {
            _subTaskRepository.Delete(_subTask);
            MessageBox.Show("Deleted Subtask Successfully");
        }

    }
}

