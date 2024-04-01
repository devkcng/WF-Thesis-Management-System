using System.Linq;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    public class StudentAccountRepository : IRepository<StudentAccount>
    {
        private readonly ThesisManagementContext _context;

        public StudentAccountRepository(ThesisManagementContext context)
        {
            _context = context;
        }

        public IQueryable<StudentAccount> GetAll()
        {
            return _context.StudentAccounts;
        }

        public StudentAccount GetById(int id)
        {
            return _context.StudentAccounts.FirstOrDefault(x => x.student_id == id);
        }

        public void Add(StudentAccount entity)
        {
            _context.StudentAccounts.Add(entity);
            _context.SaveChanges();
        }

        public void Update(StudentAccount entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(StudentAccount entity)
        {
            _context.StudentAccounts.Remove(entity);
            _context.SaveChanges();
        }

        public StudentAccount GetByUsername(string username)
        {
            return _context.StudentAccounts.FirstOrDefault(x => x.student_username == username);
        }
    }
}
