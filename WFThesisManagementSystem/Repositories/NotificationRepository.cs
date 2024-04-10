using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    internal class NotificationRepository : IRepository<Notification>
    {
        private ThesisManagementContext _context;
        public NotificationRepository(ThesisManagementContext context) 
        {
            _context = context;
        
        }
        public void Add(Notification entity)
        {
            _context.Notifications.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Notification entity)
        {
            _context.Notifications.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<Notification> GetAll()
        {
            return _context.Notifications;
        }

        public Notification GetById(int id)
        {
            return _context.Notifications.FirstOrDefault(x=>x.notification_id == id);
        }
        public Notification GetByIdRecipient(int id)
        {
            return _context.Notifications.FirstOrDefault(x=> x.recipient_id == id);
        }
        public void Update(Notification entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
