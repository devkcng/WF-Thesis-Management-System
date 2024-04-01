using System.Linq;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    public class TeacherRepository : IRepository<Teacher>
    {
        private readonly ThesisManagementContext _context;

        public TeacherRepository(ThesisManagementContext context)
        {
            _context = context;
        }

        public IQueryable<Teacher> GetAll()
        {
            return _context.Teachers;
        }

        public Teacher GetById(int id)
        {
            return _context.Teachers.FirstOrDefault(t => t.teacher_id == id);
        }

        public void Add(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
        }

        public void Update(Teacher teacher)
        {
            _context.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Teacher teacher)
        {
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
        }
    }
}
