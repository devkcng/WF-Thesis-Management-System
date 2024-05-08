using System;
using System.Data;
using System.Linq;
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
            if (_studentRepository.GetById(_userSessionHelper.UserID) != null)
            {
                this.tsmiCompose.Visible = false;

                typesToolStripMenuItem.DropDownItems.Clear();

                var Notification_Read = _notificationRepository.GetAll().Where(x => x.recipient_id == _userSessionHelper.UserID);

                foreach (var notification in Notification_Read)
                {
                    bool exists = false;

                    // Kiểm tra xem mục đã tồn tại trong DropDownItems chưa
                    foreach (var item in typesToolStripMenuItem.DropDownItems)
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
            var Notifications_UnRead = _notificationRepository.GetAll().Where(x => x.notification_status == false && (x.recipient_id == _userSessionHelper.UserID || x.sender_id == _userSessionHelper.UserID));
            var Notification_Read = _notificationRepository.GetAll().Where(x => x.notification_status == true && (x.recipient_id == _userSessionHelper.UserID || x.sender_id == _userSessionHelper.UserID));

            foreach (var notification in Notifications_UnRead)
            {
                UcNotification ucNotification = new UcNotification();
                if (notification.sender_id != null)
                {
                    var teacher = _teacherRepository.GetById(notification.sender_id.GetValueOrDefault());
                    ucNotification.Name = notification.notification_title;
                    ucNotification.Content = notification.notification_content;
                    ucNotification.SendBy = teacher.teacher_name;
                    ucNotification.SendTime = notification.timestamp.Value;
                    ucNotification.Width = ucAllNotifications1.flpAllNotifications.Width - 5;
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
                    ucNotification.Width = ucAllNotifications1.flpAllNotifications.Width - 5;
                    ucAllNotifications1.flpAllNotifications.Controls.Add(ucNotification);

                }
            }
        }

        private void tsmiRead_Click(object sender, EventArgs e)
        {
            ucAllNotifications1.Show();
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications = _notificationRepository.GetAll().Where(x => x.notification_status == true && (x.recipient_id == _userSessionHelper.UserID || x.sender_id == _userSessionHelper.UserID));
            foreach (var notification in Notifications)
            {
                var teacher = _teacherRepository.GetById(notification.sender_id.GetValueOrDefault());
                UcNotification ucNotification = new UcNotification();
                ucNotification.Name = notification.notification_title;
                ucNotification.Content = notification.notification_content;
                ucNotification.SendBy = teacher.teacher_name;
                ucNotification.SendTime = notification.timestamp.Value;
                ucNotification.icmCheckbox.Checked = true;
                ucNotification.Width = ucAllNotifications1.flpAllNotifications.Width - 5;

                ucAllNotifications1.flpAllNotifications.Controls.Add(ucNotification);
            }
        }



        private void tsmiUnread_Click(object sender, EventArgs e)
        {
            ucAllNotifications1.Show();
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications = _notificationRepository.GetAll().Where(x => x.notification_status == false && (x.recipient_id == _userSessionHelper.UserID || x.sender_id == _userSessionHelper.UserID));
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
                ucNotification.Width = ucAllNotifications1.flpAllNotifications.Width - 5;
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
            var Notifications = _notificationRepository.GetAll().Where(x => x.notification_status == false && (x.recipient_id == _userSessionHelper.UserID || x.sender_id == _userSessionHelper.UserID));
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

        private void tsmiCompose_Click(object sender, EventArgs e)
        {
            FTeacherCreateNotification fTeacherCreateNotification = new FTeacherCreateNotification(_context);
            fTeacherCreateNotification.Show();
        }

        private void tsmiSend_Click(object sender, EventArgs e)
        {
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications = _notificationService.GetSend(_userSessionHelper.UserID);
            foreach (var notification in Notifications)
            {
                var teacher = _teacherRepository.GetById(notification.sender_id.GetValueOrDefault());
                UcNotification ucNotification = new UcNotification();
                ucNotification.Name = notification.notification_title;
                ucNotification.Content = notification.notification_content;
                ucNotification.SendBy = teacher.teacher_name;
                ucNotification.SendTime = notification.timestamp.Value;
                if (notification.notification_status == true)
                {
                    ucNotification.icmCheckbox.Checked = true;
                }
                ucAllNotifications1.flpAllNotifications.Controls.Add(ucNotification);
            }
            ucAllNotifications1.Show();
        }

        private void tsmitaskAssignment_Click(object sender, EventArgs e)
        {
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications = _notificationService.GetTypes("Task Assignment", _userSessionHelper.UserID);
            foreach (var notification in Notifications)
            {
                var teacher = _teacherRepository.GetById(notification.sender_id.GetValueOrDefault());
                UcNotification ucNotification = new UcNotification();
                ucNotification.Name = notification.notification_title;
                ucNotification.Content = notification.notification_content;
                ucNotification.SendBy = teacher.teacher_name;
                ucNotification.SendTime = notification.timestamp.Value;
                if (notification.notification_status == true)
                {
                    ucNotification.icmCheckbox.Checked = true;
                }
                ucAllNotifications1.flpAllNotifications.Controls.Add(ucNotification);
            }
            ucAllNotifications1.Show();
        }

        private void tsmigroupAcceptance_Click(object sender, EventArgs e)
        {
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications = _notificationService.GetTypes("Group Acceptance", _userSessionHelper.UserID);
            foreach (var notification in Notifications)
            {
                var teacher = _teacherRepository.GetById(notification.sender_id.GetValueOrDefault());
                UcNotification ucNotification = new UcNotification();
                ucNotification.Name = notification.notification_title;
                ucNotification.Content = notification.notification_content;
                ucNotification.SendBy = teacher.teacher_name;
                ucNotification.SendTime = notification.timestamp.Value;
                if (notification.notification_status == true)
                {
                    ucNotification.icmCheckbox.Checked = true;
                }
                ucAllNotifications1.flpAllNotifications.Controls.Add(ucNotification);
            }
            ucAllNotifications1.Show();
        }

        private void tsmionlineMeeting_Click(object sender, EventArgs e)
        {
            ucAllNotifications1.flpAllNotifications.Controls.Clear();
            var Notifications = _notificationService.GetTypes("Online Meeting", _userSessionHelper.UserID);
            foreach (var notification in Notifications)
            {
                var teacher = _teacherRepository.GetById(notification.sender_id.GetValueOrDefault());
                UcNotification ucNotification = new UcNotification();
                ucNotification.Name = notification.notification_title;
                ucNotification.Content = notification.notification_content;
                ucNotification.SendBy = teacher.teacher_name;
                ucNotification.SendTime = notification.timestamp.Value;
                if (notification.notification_status == true)
                {
                    ucNotification.icmCheckbox.Checked = true;
                }
                ucAllNotifications1.flpAllNotifications.Controls.Add(ucNotification);
            }
            ucAllNotifications1.Show();
        }
    }
}
