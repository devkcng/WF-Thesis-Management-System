using System.Linq;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    public class SubtaskPointRepository : IRepository<SubtaskPoint>
    {
        ThesisManagementContext _context;

        public SubtaskPointRepository(ThesisManagementContext context)
        {
            _context = context;
        }

        public void Add(SubtaskPoint entity)
        {
            _context.SubtaskPoints.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(SubtaskPoint entity)
        {
            _context.SubtaskPoints.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<SubtaskPoint> GetAll()
        {
            return _context.SubtaskPoints;
        }

        public SubtaskPoint GetById(int id)
        {
            return _context.SubtaskPoints.FirstOrDefault(x => x.subtaskpoint_id == id);
        }

        public void Update(SubtaskPoint entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
