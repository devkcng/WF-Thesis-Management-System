using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    public class TeacherAccountRepository : IRepository<TeacherAccount>
    {
        private readonly ThesisManagementContext _context;

        public TeacherAccountRepository(ThesisManagementContext context)
        {
            _context = context;
        }

        public IQueryable<TeacherAccount> GetAll()
        {
            return _context.TeacherAccounts;
        }

        public TeacherAccount GetById(int id)
        {
            return _context.TeacherAccounts.FirstOrDefault(x => x.teacher_id == id);
        }

        public void Add(TeacherAccount entity)
        {
            _context.TeacherAccounts.Add(entity);
            _context.SaveChanges();
        }

        public void Update(TeacherAccount entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(TeacherAccount entity)
        {
            _context.TeacherAccounts.Remove(entity);
            _context.SaveChanges();
        }
    }
}
