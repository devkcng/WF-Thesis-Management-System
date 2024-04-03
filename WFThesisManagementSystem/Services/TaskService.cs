using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Services
{
    internal class TaskService
    {
        TaskRepository _taskRepository;
        Task _task;

        public TaskService(Task task)
        {
            var _context = new ThesisManagementContext();
            _taskRepository = new TaskRepository(_context);
            _task = task;
        }

        public void CreateTask()
        {
            var idGeneratorHelper = new IdGeneratorHelper();
            _task.task_id = idGeneratorHelper.GenerateTaskId();
            _task.open_day = System.DateTime.Now;
            _taskRepository.Add(_task);
        }
        // handle logic of updating a task by teacher
        public void UpdateTask()
        {
            _taskRepository.Update(_task);
        }

        // handle logic of deleting a task by teacher
        public void DeleteTask()
        {
            _taskRepository.Delete(_task);
        }

        // handle logic of submiiing a task by student
        public void SubmitTask()
        {
            // update task status to submitted
            _task.submit_day = System.DateTime.Now;
            _taskRepository.Update(_task);
        }
    }
}
