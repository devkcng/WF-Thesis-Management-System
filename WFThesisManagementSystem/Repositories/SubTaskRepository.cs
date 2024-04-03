using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    public class SubTaskRepository : IRepository<SubTask>
    {   
        private ThesisManagementContext _context;
        private TaskRepository _taskRepository;
        public SubTaskRepository(ThesisManagementContext context)
        {
            _taskRepository = new TaskRepository(context);
            _context = context;
        }

        public IQueryable<SubTask> GetAll()
        {
            return _context.SubTasks;
        }

        public SubTask GetById(int id)
        {
            return _context.SubTasks.FirstOrDefault(x => x.subtask_id == id);
        }

        public void Add(SubTask entity)
        {
            _context.SubTasks.Add(entity);
            _context.SaveChanges();
            var subtaskList = GetAll().Where(s => s.task_id == entity.task_id);
            if(IsTaskDone(subtaskList))
            {
                _taskRepository.GetById(entity.task_id.Value).submit_day = DateTime.Now;
            }
        }

        public void Update(SubTask entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(SubTask entity)
        {
            _context.SubTasks.Remove(entity);
            _context.SaveChanges();
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
