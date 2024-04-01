using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    public class RegistRepository : IRepository<Student>
    {
        private readonly ThesisManagementContext _context;
        public RegistRepository(ThesisManagementContext context)
        { 
            _context = context; 
        }
        public void Add(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateAccept(string id)
        {
            var student_group = _context.RegisterQueues.FirstOrDefault(x => (x.student_id == int.Parse(id) && x.accepted == false));
            student_group.accepted = true;
            _context.Entry(student_group).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
        public void UpdateGroupid(string id, string group_id)
        {
            var student_group = _context.RegisterQueues.FirstOrDefault(x => x.student_id == int.Parse(id));
            student_group.group_id = int.Parse(group_id);
            _context.Entry(student_group).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteStudentQueue(string id)
        {
            var student = _context.RegisterQueues.FirstOrDefault(x => x.student_id == int.Parse(id));
            _context.RegisterQueues.Remove(student);
            _context.SaveChanges();
        }
    }
}
