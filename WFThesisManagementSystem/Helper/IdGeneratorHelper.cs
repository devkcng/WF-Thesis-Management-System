using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Helper
{
    public class IdGeneratorHelper
    {
        //private List<int> _ids = new List<int>();

        //int _numberOfDigits;

        //public IdGeneratorHelper(int numberOfDigits)
        //{   
        //    _numberOfDigits = numberOfDigits;
        //    if (_numberOfDigits < 1)
        //    {
        //        MessageBox.Show("Number of digits must be greater than 0");
        //        return;
        //    }

        //    for (int i = 1 * (int)Math.Pow(10, _numberOfDigits - 1); i < _numberOfDigits; i++)
        //    {
        //        _ids.Add(i);
        //    }
        //}

        //public int GenerateId()
        //{
        //    Random random = new Random();
        //    int index = random.Next(_ids.Count);
        //    int id = _ids[index];
        //    _ids.RemoveAt(index);
        //    return id;
        //}
        readonly ThesisManagementContext _context;

        public IdGeneratorHelper()
        {
            _context = new ThesisManagementContext();
        }

        public int GenerateStudentId()
        {
            var studentRepository = new StudentRepository(_context);
            var students = studentRepository.GetAll();
            int id = 0;
            foreach (var student in students)
            {
                if (student.student_id > id)
                {
                    id = student.student_id;
                }
            }
            return id + 1;
        }

        public int GenerateGroupId()
        {
            var studentGroupRepository = new StudentGroupRepository(_context);
            var studentGroups = studentGroupRepository.GetAll();
            int id = 0;
            foreach (var studentGroup in studentGroups)
            {
                if (studentGroup.group_id > id)
                {
                    id = studentGroup.group_id;
                }
            }
            return id + 1;
        }

        public int GenerateTopicId()
        {
            var topicRepository = new TopicRepository(_context);
            var topics = topicRepository.GetAll();
            int id = 0;
            foreach (var topic in topics)
            {
                if (topic.topic_id > id)
                {
                    id = topic.topic_id;
                }
            }
            return id + 1;
        }
        // id generator for task

        public int GenerateTaskId()
        {
            var taskRepository = new TaskRepository(_context);
            var tasks = taskRepository.GetAll();
            int id = 0;
            foreach (var task in tasks)
            {
                if (task.task_id > id)
                {
                    id = task.task_id;
                }
            }
            return id + 1;
        }
        public int GenerateNotificationId()
        {
            var notificationRepository = new NotificationRepository(_context);
            var notificationIds = notificationRepository.GetAll();
            int id = 0;
            foreach(var notification in notificationIds)
            {
                if(notification.notification_id > id)
                {
                    id = notification.notification_id;
                }
            }
            return id + 1;
        }

        public int GenerateRejectListId()
        {
            var rejectListRepository = new RejectListRepository(_context);
            var rejectLists = rejectListRepository.GetAll();
            int id = 0;
            foreach (var rejectList in rejectLists)
            {
                if (rejectList.list_id > id)
                {
                    id = rejectList.list_id;
                }
            }
            return id + 1;
        }
    }
}
