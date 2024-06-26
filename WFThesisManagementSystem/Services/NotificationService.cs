﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        private Notification _notification;
        public NotificationService(ThesisManagementContext context)
        {
            _context = context;
            _notificationRepository = new NotificationRepository(_context);
            _notification = new Notification();

        }

        //this function is used to create a notification
        public Notification CreateNotification(NotificationMessage message)
        {
            var notification = new Notification();
            var idGenerator = new IdGeneratorHelper();
            notification.notification_id = idGenerator.GenerateNotificationId();
            notification.notification_title = message.Title;
            notification.notification_status = false;
            notification.notification_content = message.Message;
            notification.timestamp = DateTime.Now;
            notification.notification_type = message.Type;
            notification.sender_id = UserSessionHelper.Instance.UserID;
            return notification;
        }

        public void SendToStudents(List<Student> students, NotificationMessage message)
        {
            // students = new List<Student>();
            foreach (Student student in students)
            {
                var notification = CreateNotification(message);
                notification.recipient_id = student.student_id;
                _notificationRepository.Add(notification);
            }

        }
        public void SendToStudent(Student student, NotificationMessage message)
        { 
            var notification = CreateNotification(message);
            notification.recipient_id = student.student_id;
            _notificationRepository.Add(notification);
        }
        public bool CheckSendNotification(List<Student> students)
        {
            //students = new List<Student>();
            foreach (Student student in students)
            {
                var notification = _notificationRepository.GetByIdRecipient(student.student_id);
                if (notification == null)
                    return false;
            }
            return true;
        }
        public List<Notification> GetTypes(string type, int id)
        {
            List<Notification> result = new List<Notification>();
            result = _notificationRepository.GetAll().Where(x => x.notification_type == type && x.sender_id == id).ToList();
            return result;
        }

        public List<Notification> GetTypesStudents(string type, int id)
        {
            List<Notification> result = new List<Notification>();
            result = _notificationRepository.GetAll().Where(x => x.notification_type == type && x.recipient_id == id).ToList();
            return result;
        }

        public List<Notification> GetSend(int id)
        {
            List<Notification> result = new List<Notification>();
            result = _notificationRepository.GetAll().Where(x => x.sender_id == id).ToList();
            return result;
        }
    }
}
