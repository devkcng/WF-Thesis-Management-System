using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Services
{
    public class NotificationMessage
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
    }
    public class NotificationService
    {
        private NotificationRepository _notificationRepository;
        private ThesisManagementContext _context;
        private Notification notification;
        public NotificationService( ThesisManagementContext context)
        {
            _context = context;
            _notificationRepository = new NotificationRepository(_context);
            
            
        }
        public void SendToStudent(List<Student> students,NotificationMessage message)
        {
           // students = new List<Student>();
            foreach (Student student in students) 
            {
                IdGeneratorHelper idGeneratorHelper = new IdGeneratorHelper();

                notification = new Notification();
                notification.sender_id = UserSessionHelper.Instance.UserID;
                notification.recipient_id = student.student_id;
                notification.notification_id = idGeneratorHelper.GenerateNotificationId();
                notification.notification_content = message.Message;
                notification.notification_title = message.Title;
                notification.notification_type = message.Type;
                notification.timestamp = DateTime.Now;
                _notificationRepository.Add(notification);
            }
            
        }
        public bool CheckSendNotification(List<Student> students)
        {
            //students = new List<Student>();
            foreach (Student student in students) 
            {
                var notification = _notificationRepository.GetByIdRecipient(student.student_id);
                if(notification == null)
                    return false;
            }
            return true;
        }
    }
}
