using System.Collections.Generic;
using System.Linq;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    public class TaskRepository : IRepository<Task>
    {
        //
        private ThesisManagementContext _context;

        public TaskRepository(ThesisManagementContext context)
        {
            _context = context;
        }

        public IQueryable<Task> GetAll()
        {
            return _context.Tasks;
        }
        public List<Task> GetAllUncompletedTask(int groupID)
        {
            return _context.Tasks.Where(x => x.submit_day == null).ToList();
        }
        public Task GetById(int id)
        {
            return _context.Tasks.FirstOrDefault(x => x.task_id == id);
        }
        public List<Task> GetByGroupID(int groupID)
        {
            return _context.Tasks.Where(x => x.group_id == groupID).ToList();
        }


        public void Add(Task entity)
        {
            _context.Tasks.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Task entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Task entity)
        {
            //delete task by _context
            _context.Tasks.Attach(entity);
            _context.Tasks.Remove(entity);
            _context.SaveChanges();
        }
        //get task by group id

        public List<Task> GetTaskByGroupId(int groupId)
        {
            return _context.Tasks.Where(x => x.group_id == groupId).ToList();
        }

        //get task by task name

        public Task GetTaskByTaskName(string taskName)
        {
            return _context.Tasks.FirstOrDefault(x => x.task_name == taskName);
        }

        public Task GetFirstTask()
        {
            return _context.Tasks.OrderBy(x => x.open_day).FirstOrDefault();
        }

        public int GetNumberOfCompletedTaskOfGroup(int groupID)
        {
            return _context.Tasks.Count(x => x.submit_day != null && x.group_id == groupID);
        }
        public int GetNumberOfUncompletedTaskOfGroup(int groupID)
        {
            return _context.Tasks.Count(subTask => subTask.submit_day == null && subTask.group_id == groupID);
        }
        public int GetNumberOfLateSubmittedTasksOfGroup(int groupID)
        {
            return _context.Tasks.Count(subTask => subTask.submit_day > subTask.due_date && subTask.group_id == groupID);
        }
    }
}
