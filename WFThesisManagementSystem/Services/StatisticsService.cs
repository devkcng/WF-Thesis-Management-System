using System;
using System.Collections.Generic;
using System.Linq;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using Task = WFThesisManagementSystem.Models.Task;

namespace WFThesisManagementSystem.Services
{
    public class StatisticsService
    {
        ThesisManagementContext _context;
        TeacherRepository _teacherRepository;
        TopicRepository _topicRepository;
        StudentGroupRepository _studentGroupRepository;
        TaskRepository _taskRepository;
        SubTaskRepository _subTaskRepository;
        StudentPointRepository _studentPointRepository;
        StudentRepository _studentRepository;
        public StatisticsService(ThesisManagementContext context)
        {
            _context = context;
            _teacherRepository = new TeacherRepository(_context);
            _topicRepository = new TopicRepository(_context);
            _studentGroupRepository = new StudentGroupRepository(_context);
            _taskRepository = new TaskRepository(_context);
            _subTaskRepository = new SubTaskRepository(_context);
            _studentPointRepository = new StudentPointRepository(_context);
            _studentRepository = new StudentRepository(_context);
            
        }
        public int CountStudentsAveragePoint(int teacher_id, int condition)
        {
            try
            {
                var topics = _topicRepository.GetAll().Where(x => x.teacher_id == teacher_id);
                List<StudentGroup> result = new List<StudentGroup>();
                int countAverage = 0;
                int countGood = 0;
                int countExcellent = 0;
                foreach (var topic in topics)
                {
                    if (_studentGroupRepository.GetAll().Where(x => x.topic_id == topic.topic_id) != null)
                    {
                        var studentGroups = _studentGroupRepository.GetAll().Where(x => x.topic_id == topic.topic_id);
                        foreach (var studentGroup in studentGroups)
                        {
                            foreach (var student in _studentRepository.GetAll())
                            {
                                if (student.group_id == studentGroup.group_id)
                                {
                                    var studentpoint = _studentPointRepository.GetAll().FirstOrDefault(x=>x.student_id ==student.student_id);
                                    if (studentpoint != null)
                                    {
                                        if (studentpoint.student_point < 5) countAverage++;
                                        else if (studentpoint.student_point >= 5 && studentpoint.student_point < 8) countGood++;
                                        else if (studentpoint.student_point >= 8 && studentpoint.student_point <= 10) countExcellent++;
                                    }

                                }
                            }

                        }
                    }
                }
                if (condition == 0) return countAverage;
                else if (condition == 1) return countGood;
                return countExcellent;
            }catch(Exception e)
            {
                return 0;
            }
        }
        public int CountStudentComplete(int teacherId, int condition)
        {
            int countComplete = 0;
            int countNotComplete = 0;
            var topics = _topicRepository.GetAllByTeacherID(teacherId);
            var studentGroups = new List<StudentGroup>();
            var tasks = new List<Task>();
            foreach (var topic in topics)
            {
                foreach (var studentGroup in _studentGroupRepository.GetAll())
                {
                    if (topic.topic_id == studentGroup.topic_id)
                    {
                        studentGroups.Add(studentGroup);
                    }
                }
            }
            foreach (var studentGroup in studentGroups)
            {
                foreach (var task in _taskRepository.GetAll())
                {
                    if (studentGroup.group_id == task.group_id)
                    {
                        tasks.Add(task);
                    }
                }
            }
            foreach (var task in tasks)
            {
                foreach (var subTask in _subTaskRepository.GetAll())
                {
                    if (task.task_id == subTask.task_id && subTask.submit_day != null)
                    {
                        countComplete++;
                    }
                    if (task.task_id == subTask.task_id && subTask.submit_day == null)
                    {
                        countNotComplete++;
                    }

                }
            }
            if (condition == 0) return countNotComplete;
            return countComplete;
        }

    }
}
