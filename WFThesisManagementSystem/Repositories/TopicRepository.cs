using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    public class TopicRepository : IRepository<Topic>
    {
        private readonly ThesisManagementContext _context;

        public TopicRepository(ThesisManagementContext context)
        {
            _context = context;
        }

        public IQueryable<Topic> GetAll()
        {
            return _context.Topics;
        }

        public Topic GetById(int id)
        {
            return _context.Topics.FirstOrDefault(t => t.topic_id == id);
        }

        public void Add(Topic topic)
        {
            _context.Topics.Add(topic);
            _context.SaveChanges();
        }

        public void Update(Topic topic)
        {
            _context.Entry(topic).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Topic topic)
        {
            _context.Topics.Remove(topic);
            _context.SaveChanges();
        }
    }
}
