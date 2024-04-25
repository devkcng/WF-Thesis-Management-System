using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Services
{
    internal class TeacherService
    {
        Teacher _teacher;
        TeacherRepository _teacherRepository;
        TopicRepository _topicRepository;
        StudentGroupRepository _studentGroupRepository;
        ThesisManagementContext _context;

        public TeacherService(int teacherID)
        {
            _context = new ThesisManagementContext();
            _topicRepository = new TopicRepository(_context);
            _studentGroupRepository = new StudentGroupRepository(_context);
            _teacherRepository = new TeacherRepository(_context);
            _teacher= new Teacher();
            _teacher = _teacherRepository.GetById(teacherID);
        }
        public int GetNumberStudentRegisterOfTeacher()
        {
            int count=0;
            var topicList = _topicRepository.GetAllByTeacherID(_teacher.teacher_id);
            foreach(var topic in topicList)
            {
                var studentGroupList = _studentGroupRepository.GetAllByTopicID(topic.topic_id);
                foreach (var studentGroup in studentGroupList)
                {
                    if (studentGroup != null)
                    {
                        count += studentGroup.number_of_students.Value;
                    }
                }
            }
            return count;
        }
    }
}
