using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.UC;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Forms
{
    public partial class FNotification : Form
    {
        ThesisManagementContext _context;
        NotificationRepository _notificationRepository;
        TeacherRepository _teacherRepository;
        public FNotification(ThesisManagementContext context )
        {
            _context = context;
            _notificationRepository = new NotificationRepository( _context );
            _teacherRepository = new TeacherRepository( _context );
            InitializeComponent();
            ucAllNotifications1.Hide();
        }

        private void tsmiCompose_Click(object sender, EventArgs e)
        {
            FTeacherCreateNotification fTeacherCreateNotification = new FTeacherCreateNotification(_context);
            fTeacherCreateNotification.Show();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void tsmiInbox_Click(object sender, EventArgs e)
        {
            ucAllNotifications1.Show();
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications_UnRead = _notificationRepository.GetAll().Where(x=>x.notification_status == false);
            var Notification_Read = _notificationRepository.GetAll().Where(x=>x.notification_status==true);
            foreach ( var notification in Notifications_UnRead  ) 
            {
                UcNotification ucNotification = new UcNotification();
                if (notification.sender_id != null)
                {
                    var teacher = _teacherRepository.GetById(notification.sender_id.GetValueOrDefault());
                    ucNotification.Name = notification.notification_title;
                    ucNotification.Content = notification.notification_content;
                    ucNotification.SendBy = teacher.teacher_name;
                    ucNotification.SendTime = notification.timestamp.Value;
                    ucAllNotifications1.flpAllNotifications.Controls.Add(ucNotification);
                }
            }
            foreach (var notification in Notification_Read)
            {
                UcNotification ucNotification = new UcNotification();
                if (notification.sender_id != null)
                {
                    var teacher = _teacherRepository.GetById(notification.sender_id.GetValueOrDefault());
                    ucNotification.Name = notification.notification_title;
                    ucNotification.Content = notification.notification_content;
                    ucNotification.SendBy = teacher.teacher_name;
                    ucNotification.SendTime = notification.timestamp.Value;
                    ucNotification.icmCheckbox.Checked = true;
                    ucAllNotifications1.flpAllNotifications.Controls.Add(ucNotification);
                }
            }
        }

        private void tsmiRead_Click(object sender, EventArgs e)
        {
            ucAllNotifications1.Show();
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications = _notificationRepository.GetAll().Where(x=>x.notification_status == true);
            foreach (var notification in Notifications)
            {
                var teacher = _teacherRepository.GetById(notification.sender_id.GetValueOrDefault());
                UcNotification ucNotification = new UcNotification();
                ucNotification.Name = notification.notification_title;
                ucNotification.Content = notification.notification_content;
                ucNotification.SendBy = teacher.teacher_name;
                ucNotification.SendTime = notification.timestamp.Value;
                ucNotification.icmCheckbox.Checked = true;

                ucAllNotifications1.flpAllNotifications.Controls.Add(ucNotification);
            }
        }

     

        private void tsmiUnread_Click(object sender, EventArgs e)
        {
            ucAllNotifications1.Show();
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications = _notificationRepository.GetAll().Where(x => x.notification_status == false) ;
            foreach (var notification in Notifications)
            {
                var teacher = _teacherRepository.GetById(notification.sender_id.GetValueOrDefault());
                UcNotification ucNotification = new UcNotification();
                ucNotification.Name = notification.notification_title;
                ucNotification.Content = notification.notification_content;
                ucNotification.SendBy = teacher.teacher_name;
                ucNotification.SendTime = notification.timestamp.Value;
                ucNotification.Id = notification.notification_id;
                ucNotification.CheckBox += UcNotification_CheckBox;
                ucAllNotifications1.flpAllNotifications.Controls.Add(ucNotification);
            }
        }
        private void UcNotification_CheckBox(object sender, EventArgs e)
        {
            UcNotification ucNotification = sender as UcNotification;
            var notification = _notificationRepository.GetAll().FirstOrDefault(x => x.notification_id == ucNotification.Id);
            notification.notification_status = true;
            _notificationRepository.Update(notification);
            List_Load_UnRead();

        }
        private void List_Load_UnRead()
        {
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications = _notificationRepository.GetAll().Where(x => x.notification_status == false);
            foreach (var notification in Notifications)
            {
                var teacher = _teacherRepository.GetById(notification.sender_id.GetValueOrDefault());
                UcNotification ucNotification = new UcNotification();
                ucNotification.Name = notification.notification_title;
                ucNotification.Content = notification.notification_content;
                ucNotification.SendBy = teacher.teacher_name;
                ucNotification.SendTime = notification.timestamp.Value;
                ucAllNotifications1.flpAllNotifications.Controls.Add(ucNotification);
            }
        }
    }
}
