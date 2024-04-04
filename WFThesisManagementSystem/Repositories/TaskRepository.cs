using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public Task GetById(int id)
        {
            return _context.Tasks.FirstOrDefault(x => x.task_id == id);
        }
        public IQueryable<Task> GetByGroupID(int groupID)
        {
            return _context.Tasks.Where(x => x.group_id == groupID);
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

        public IQueryable<Task> GetTaskByGroupId(int groupId)
        {
            return _context.Tasks.Where(x => x.group_id == groupId);
        }

        //get task by task name

        public Task GetTaskByTaskName(string taskName)
        {
            return _context.Tasks.FirstOrDefault(x => x.task_name == taskName);
        }


    }
}
