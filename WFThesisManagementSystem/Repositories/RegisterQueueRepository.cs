using System.Collections.Generic;
using System.Linq;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    public class RegisterQueueRepository : IRepository<RegisterQueue>
    {
        private ThesisManagementContext _context;

        public RegisterQueueRepository(ThesisManagementContext context)
        {
            _context = context;
        }

        public IQueryable<RegisterQueue> GetAll()
        {
            return _context.RegisterQueues;
        }


        //get the register queue by student id
        public RegisterQueue GetById(int id)
        {
            return _context.RegisterQueues.FirstOrDefault(x => x.student_id == id);
        }

        public void Add(RegisterQueue entity)
        {
            _context.RegisterQueues.Add(entity);
            _context.SaveChanges();
        }

        public void Update(RegisterQueue entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(RegisterQueue entity)
        {
            _context.RegisterQueues.Remove(entity);
            _context.SaveChanges();
        }

        public RegisterQueue GetByGroupId(int id)
        {
            return _context.RegisterQueues.FirstOrDefault(x => x.group_id == id);
        }

        public RegisterQueue GetByTopicId(int id)
        {
            return _context.RegisterQueues.FirstOrDefault(x => x.topic_id == id);
        }
        
        public int GetNumberUnacceptedStudentInqueue (int topicID)
        {
            return _context.RegisterQueues.Where(t => t.topic_id  == topicID && t.accepted == false).Count();
        }
        public List<int> GetAllInqueueTopic()
        {
            return GetAll().Where(r=>r.accepted == false).Select(r => r.topic_id.Value).ToList();
        }


    }

}
