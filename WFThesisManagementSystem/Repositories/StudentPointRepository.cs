﻿using System.Linq;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    public class StudentPointRepository : IRepository<StudentPoint>
    {
        ThesisManagementContext _context;
        public StudentPointRepository(ThesisManagementContext context)
        {
            _context = context;
        }

        public void Add(StudentPoint entity)
        {
            _context.StudentPoints.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(StudentPoint entity)
        {
            _context.StudentPoints.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<StudentPoint> GetAll()
        {
            return _context.StudentPoints;
        }

        public StudentPoint GetById(int id)
        {
            return _context.StudentPoints.FirstOrDefault(x => x.studentpoint_id == id);
        }

        public void Update(StudentPoint entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
        public StudentPoint GetByStudentId(int studentID)
        {
            return _context.StudentPoints.FirstOrDefault(x => x.student_id == studentID);
        }

    }
}
