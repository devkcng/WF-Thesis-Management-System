using System.Linq;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    public class RejectListRepository : IRepository<RejectList>
    {
        private ThesisManagementContext _context;

        public RejectListRepository(ThesisManagementContext context)
        {
            _context = context;
        }

        public IQueryable<RejectList> GetAll()
        {
            return _context.RejectLists;
        }

        public RejectList GetById(int id)
        {
            return _context.RejectLists.FirstOrDefault(x => x.list_id == id);
        }

        public void Add(RejectList entity)
        {
            _context.RejectLists.Add(entity);
            _context.SaveChanges();
        }

        public void Update(RejectList entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(RejectList entity)
        {
            _context.RejectLists.Remove(entity);
            _context.SaveChanges();
        }
    }
}
