using System.Collections.Generic;
using System.Linq;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    internal class PointSheetRecordRepository : IRepository<PointSheetRecord>
    {
        private ThesisManagementContext _context;

        public PointSheetRecordRepository(ThesisManagementContext context)
        {
            _context = context;
        }

        public void Add(PointSheetRecord entity)
        {
            _context.PointSheetRecords.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(PointSheetRecord entity)
        {
            _context.PointSheetRecords.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<PointSheetRecord> GetAll()
        {
            return _context.PointSheetRecords;
        }

        public PointSheetRecord GetById(int id)
        {
            return _context.PointSheetRecords.FirstOrDefault(x => x.student_id == id);
        }

        public void Update(PointSheetRecord entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
        public List<PointSheetRecord> GetAllByStudentID(int studentID)
        {
            return _context.PointSheetRecords.Where(p => p.student_id == studentID).ToList();
        }
    }
}
