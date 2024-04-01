﻿using System.Linq;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    public class StudentGroupRepository : IRepository<StudentGroup>
    {
        private readonly ThesisManagementContext _context;

        public StudentGroupRepository(ThesisManagementContext context)
        {
            _context = context;
        }

        public IQueryable<StudentGroup> GetAll()
        {
            return _context.StudentGroups;
        }

        public StudentGroup GetById(int id)
        {
            return _context.StudentGroups.FirstOrDefault(sg => sg.group_id == id);
        }

        public void Add(StudentGroup studentGroup)
        {
            _context.StudentGroups.Add(studentGroup);
            _context.SaveChanges();
        }

        public void Update(StudentGroup studentGroup)
        {
            _context.Entry(studentGroup).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(StudentGroup studentGroup)
        {
            _context.StudentGroups.Remove(studentGroup);
            _context.SaveChanges();
        }

        public StudentGroup GetByTopicId(int topicId)
        {
            return _context.StudentGroups.FirstOrDefault(sg => sg.topic_id == topicId);
        }
    }
}
