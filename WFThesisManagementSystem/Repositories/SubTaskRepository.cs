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

        public SubTaskRepository(ThesisManagementContext context)
        {
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
    }
}
