using System.Collections.Generic;
using System.Windows.Forms;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Services
{
    internal class TaskService
    {
        TaskRepository _taskRepository;
        public Task _task;
        ThesisManagementContext _context;
        Dictionary<int, int> _numberTask = new Dictionary<int, int>();
        public TaskService(Task task, ThesisManagementContext context)
        {
            _context = context;
            _taskRepository = new TaskRepository(_context);
            _task = task;
        }
        public TaskService(ThesisManagementContext context)
        {
            _context = context;
            _taskRepository = new TaskRepository(_context);
        }

        public void CreateTask()
        {
            var idGeneratorHelper = new IdGeneratorHelper();
            //_task.task_id = idGeneratorHelper.GenerateTaskId();
            //_task.open_day = System.DateTime.Now;
            //_taskRepository.Add(_task);

            var task = new Task
            {
                task_id = idGeneratorHelper.GenerateTaskId(),
                task_name = _task.task_name,
                task_description = _task.task_description,
                due_date = _task.due_date,
                group_id = _task.group_id,
                open_day = System.DateTime.Now
            };

            _taskRepository.Add(task);


            MessageBox.Show("Task Created");
        }
        // handle logic of updating a task by teacher
        public void UpdateTask()
        {
            _taskRepository.Update(_task);
            MessageBox.Show("Updated");
        }

        // handle logic of deleting a task by teacher
        public void DeleteTask()
        {
            _taskRepository.Delete(_task);
            MessageBox.Show("Deleted");
        }

        // handle logic of submiiing a task by student
        public void SubmitTask()
        {
            // update task status to submitted
            _task.submit_day = System.DateTime.Now;
            _taskRepository.Update(_task);
        }
        public int NumberTask(int groupid)
        {
            foreach (var task in _taskRepository.GetAll())
            {
                _numberTask[task.group_id.Value] = 0;
            }
            foreach (var task in _taskRepository.GetAll())
            {
                _numberTask[task.group_id.Value]++;
            }
            return _numberTask[groupid];
        }
    }
}
