using System.Data.Entity;
using System.Linq;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly ThesisManagementContext _context;
        public StudentRepository(ThesisManagementContext context)
        {
            _context = context;
        }

        public IQueryable<Student> GetAll()
        {
            return _context.Students;
        }

        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.student_id == id);
        }

        public IQueryable<Student> GetAllByGroupId(int id)
        {
            return _context.Students.Where(t => t.group_id == id);
        }
        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Update(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
        public void UpdateGroupid(int id, int group_id)
        {
            var student_group = _context.Students.FirstOrDefault(x => x.student_id == id);
            student_group.group_id = group_id;
            StudentRepository studentRepository = new StudentRepository(_context);
            studentRepository.Update(student_group);
            //_context.Entry(student_group).State = System.Data.Entity.EntityState.Modified;
            //_context.SaveChanges();
        }
    }
}
