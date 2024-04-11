using System.Windows.Forms;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Services
{
    //this is logic for registering a student to a topic
    public class RegistrationService
    {
        Student _student;
        Topic _topic;
        RegisterQueueRepository _registerQueueRepository;
        StudentGroupRepository _studentGroupRepository;
        private ThesisManagementContext _context;
        string _groupName;
        public RegistrationService(Student student, Topic topic, string groupName)
        {
            _student = student;
            _topic = topic;
            _groupName = groupName;
            var context = new ThesisManagementContext();
            _registerQueueRepository = new RegisterQueueRepository(context);
            _studentGroupRepository = new StudentGroupRepository(context);
        }

        public RegistrationService(Student student, ThesisManagementContext context)
        {
            _student = student;
             _context = context;
            _registerQueueRepository = new RegisterQueueRepository(_context);
            _studentGroupRepository = new StudentGroupRepository(_context);
        }

        public bool Register()
        {
            if (AlreadyRegistered())
            {
                MessageBox.Show("You have already registered");
                return false;
            }
            if (Unregistered())
            {
                if (!GroupExists())
                {
                    StudentGroup studentGroup = CreateGroup();
                    _studentGroupRepository.Add(studentGroup);
                    RegisterQueue registerQueue = new RegisterQueue();
                    registerQueue.student_id = _student.student_id;
                    registerQueue.topic_id = _topic.topic_id;
                    registerQueue.group_id = studentGroup.group_id;
                    registerQueue.accepted = false;
                    _registerQueueRepository.Add(registerQueue);
                    return true;
                }
                else
                {
                    var studentGroup = _studentGroupRepository.GetByTopicId(_topic.topic_id);
                    RegisterQueue registerQueue = new RegisterQueue();
                    registerQueue.student_id = _student.student_id;
                    registerQueue.topic_id = _topic.topic_id;
                    registerQueue.group_id = studentGroup.group_id;
                    registerQueue.accepted = false;
                    _registerQueueRepository.Add(registerQueue);
                    return true;
                }
            }

            if (InQueue())
            {
                MessageBox.Show("You are already in queue");
                return false;
            }
            return false;
        }

        public bool AlreadyRegistered()
        {
            //check if student is already registered to a topic
            if (_student.group_id != null)
            {
                return true;
            }
            return false;
        }

        public bool Unregistered()
        {
            //check if student is unregistered from a topic
            var registerQueue = _registerQueueRepository.GetById(_student.student_id);
            if (_student.group_id == null && registerQueue == null)
            {
                return true;
            }
            return false;
        }

        public bool InQueue()
        {
            var registerQueue = _registerQueueRepository.GetById(_student.student_id);
            if (_student.group_id == null && registerQueue != null)
            {
                return true;
            }
            return false;
        }

        public bool GroupExists()
        {
            var studentGroupList = _studentGroupRepository.GetAll();
            foreach (var studentGroup in studentGroupList)
            {
                if (studentGroup.topic_id == _topic.topic_id)
                {
                    return true;
                }
            }
            return false;
        }

        public StudentGroup CreateGroup()
        {
            StudentGroup studentGroup = new StudentGroup();
            IdGeneratorHelper idGeneratorHelper = new IdGeneratorHelper();
            studentGroup.group_id = idGeneratorHelper.GenerateGroupId();
            studentGroup.group_name = _groupName;
            studentGroup.number_of_students = 0;
            studentGroup.topic_id = _topic.topic_id;
            studentGroup.group_points = 0;
            return studentGroup;
        }
    }
}
