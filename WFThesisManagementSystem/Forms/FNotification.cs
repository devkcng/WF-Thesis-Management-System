using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.UC;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using WFThesisManagementSystem.Services;

namespace WFThesisManagementSystem.Forms
{
    public partial class FNotification : Form
    {
        ThesisManagementContext _context;
        NotificationRepository _notificationRepository;
        TeacherRepository _teacherRepository;
        StudentRepository _studentRepository;
        UserSessionHelper _userSessionHelper = UserSessionHelper.Instance;
        NotificationService _notificationService;

        public FNotification(ThesisManagementContext context)
        {
            _context = context;
            _notificationRepository = new NotificationRepository(_context);
            _teacherRepository = new TeacherRepository(_context);
            _studentRepository = new StudentRepository(_context);
            _notificationService = new NotificationService(_context);
            InitializeComponent();
            ucAllNotifications1.Hide();
            tsmiInbox.Visible = false;
            if (_studentRepository.GetById(_userSessionHelper.UserID) != null)
            {
                this.tsmiCompose.Visible = false;

                typesToolStripMenuItem.DropDownItems.Clear();

                var Notification_Read = _notificationRepository.GetAll().Where(x => x.recipient_id == _userSessionHelper.UserID);

                foreach (var notification in Notification_Read)
                {
                    bool exists = false;

                    // Kiểm tra xem mục đã tồn tại trong DropDownItems chưa
                    foreach (ToolStripMenuItem item in typesToolStripMenuItem.DropDownItems)
                    {
                        if (item is ToolStripItem && ((ToolStripItem)item).Text == notification.notification_type)
                        {
                            exists = true;
                            break;
                        }
                    }

                    // Nếu mục không tồn tại, thêm vào DropDownItems
                    if (!exists)
                    {
                        typesToolStripMenuItem.DropDownItems.Add(notification.notification_type);
                    }
                }
                foreach (ToolStripMenuItem item in typesToolStripMenuItem.DropDownItems)
                {
                    item.Click += typesToolStripMenuItem_DropDownItemClicked;
                }

                this.tsmiSend.Visible = false;
                //contextMenuStrip1.Items["tsmiExit"].Bounds = tsmiSend.Bounds;
            }
        }


        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void tsmiInbox_Click(object sender, EventArgs e)
        {
            ucAllNotifications1.Show();
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications_UnRead = _notificationRepository.GetAll().Where(x => x.notification_status == false && (x.recipient_id == _userSessionHelper.UserID));
            var Notification_Read = _notificationRepository.GetAll().Where(x => x.notification_status == true && (x.recipient_id == _userSessionHelper.UserID ));
            if (Notifications_UnRead.Count() > 0)
            {
                LoadNotification(Notifications_UnRead.ToList());

            }

            if (Notification_Read.Count() > 0)
            {
                LoadNotification(Notification_Read.ToList());
            }
        }

        private void tsmiRead_Click(object sender, EventArgs e)
        {
            ucAllNotifications1.Show();
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications = _notificationRepository.GetAll().Where(x => x.notification_status == true && (x.recipient_id == _userSessionHelper.UserID || x.sender_id == _userSessionHelper.UserID));
            LoadNotification(Notifications.ToList());
        }



        private void tsmiUnread_Click(object sender, EventArgs e)
        {
            ucAllNotifications1.Show();
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications = _notificationRepository.GetAll().Where(x => x.notification_status == false && (x.recipient_id == _userSessionHelper.UserID || x.sender_id == _userSessionHelper.UserID));
            LoadNotification(Notifications.ToList());
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
            var Notifications = _notificationRepository.GetAll().Where(x => x.notification_status == false && (x.recipient_id == _userSessionHelper.UserID || x.sender_id == _userSessionHelper.UserID));
            LoadNotification(Notifications.ToList());
        }

        private void tsmiCompose_Click(object sender, EventArgs e)
        {
            FTeacherCreateNotification fTeacherCreateNotification = new FTeacherCreateNotification(_context);
            fTeacherCreateNotification.Show();
        }

        private void tsmiSend_Click(object sender, EventArgs e)
        {
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications = _notificationService.GetSend(_userSessionHelper.UserID);
            LoadNotification(Notifications);
        }

        private void tsmitaskAssignment_Click(object sender, EventArgs e)
        {
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications = _notificationService.GetTypes("Task Assignment", _userSessionHelper.UserID);
            LoadNotification(Notifications);
        }

        private void tsmigroupAcceptance_Click(object sender, EventArgs e)
        {
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications = _notificationService.GetTypes("Topic Registration Accepted", _userSessionHelper.UserID);
            LoadNotification(Notifications);
        }

        private void tsmionlineMeeting_Click(object sender, EventArgs e)
        {
            var Notifications = _notificationService.GetTypes("Online Meeting", _userSessionHelper.UserID);
            LoadNotification(Notifications);
        }
        private void LoadNotification(List<Notification> notificationList)
        {
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            foreach (var notification in notificationList)
            {
                var teacher = _teacherRepository.GetById(notification.sender_id.GetValueOrDefault());
                UcNotification ucNotification = new UcNotification();
                ucNotification.Name = notification.notification_title;
                ucNotification.Content = notification.notification_content;
                ucNotification.Id = notification.notification_id;
                ucNotification.CheckBox += UcNotification_CheckBox;
                if (teacher != null)
                {
                    ucNotification.SendBy = teacher.teacher_name;
                }
                else
                {
                    var student = _studentRepository.GetById(notification.sender_id.GetValueOrDefault());
                    ucNotification.SendBy = student.student_name;

                }
                ucNotification.SendTime = notification.timestamp.Value;
                if (notification.notification_status == true)
                {
                    ucNotification.icmCheckbox.Checked = true;
                }
                ucNotification.Width = 945;
                ucAllNotifications1.flpAllNotifications.Controls.Add(ucNotification);
            }
            ucAllNotifications1.Show();
        }
        private void typesToolStripMenuItem_DropDownItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem selectedItem = (ToolStripMenuItem)sender;
            string notificationType = selectedItem.Text;
            var Notifications = _notificationService.GetTypesStudents(notificationType, _userSessionHelper.UserID);
            //MessageBox.Show(Notifications.Count().ToString());
            //MessageBox.Show(notificationType);

            LoadNotification(Notifications);
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var notifications = _notificationRepository.GetAll().ToList();
            LoadNotification(notifications);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadNotification(SearchNotification(txtSearch.Text));
        }

        public List<Notification> SearchNotification(string searchValue)
        {
            var notifications = _notificationRepository.GetAll().Where(
                x => x.notification_title.Contains(searchValue)
                     || x.notification_content.Contains(searchValue)).ToList();
                
            return notifications;
        }
    }
}
