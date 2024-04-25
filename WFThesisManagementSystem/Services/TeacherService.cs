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
            _teacher = new Teacher();
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
        private int GetNumberStudentRegisterOfTeacher(int teacher_id)
        {
            int count = 0;
            var topicList = _topicRepository.GetAllByTeacherID(teacher_id);
            foreach (var topic in topicList)
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

        public List<Teacher> GetTeachersHasMostStudentRegist() 
        {
            var teacherList = _teacherRepository.GetAll();
            List<(int teacher_id, int numberStudentRegist)> teacherOrderingList = new List<(int, int)>();
            foreach(var teacher in teacherList)
            {
                teacherOrderingList.Add((teacher.teacher_id, GetNumberStudentRegisterOfTeacher(teacher.teacher_id)));
            }
            teacherOrderingList = teacherOrderingList.OrderByDescending(t => t.numberStudentRegist).ToList();
            teacherOrderingList = teacherOrderingList.Take(5).ToList();
            // Tạo danh sách giáo viên từ danh sách đã sắp xếp
            List<Teacher> teachers = new List<Teacher>();
            foreach (var tuple in teacherOrderingList)
            {
                Teacher teacher = _teacherRepository.GetById(tuple.teacher_id);
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}
