using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void UpdateAccept(int id)
        {
            var student_group = _context.RegisterQueues.FirstOrDefault(x => (x.student_id == id && x.accepted == false));
            student_group.accepted = true;
            RegisterQueueRepository _registerQueueRepository = new RegisterQueueRepository(_context);
            _registerQueueRepository.Update(student_group);
            //_context.Entry(student_group).State = System.Data.Entity.EntityState.Modified;
            //_context.SaveChanges();
        }
        public void DeleteStudentQueue(int id)
        {
            var student = _context.RegisterQueues.FirstOrDefault(x => x.student_id ==id);
            RegisterQueueRepository _registerQueueRepository = new RegisterQueueRepository(_context);
            _registerQueueRepository.Delete(student);
            //_context.RegisterQueues.Remove(student);
            //_context.SaveChanges();
        }
    }

}
