using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Forms.UC
{
    public partial class FTeacherCreateNotification : Form
    {
        private Notification _notification;
        private NotificationRepository _notificationRepository;
        private ThesisManagementContext _context;
        private TeacherRepository _teacherRepository;
        public FTeacherCreateNotification(ThesisManagementContext context)
        {
            InitializeComponent();
            ucCreateNotification1.btnClear.Click += Clear;
            ucCreateNotification1.btnDone.Click += Save;
            ucCreateNotification1.btnClose.Click += Close;
            _context = context;
            _notificationRepository = new NotificationRepository(_context);
            _teacherRepository = new TeacherRepository(_context);
            _notification = new Notification();
        }
        private void Clear(object sender, EventArgs e)
        {
            ucCreateNotification1.txtNotificationContent.Clear();
            ucCreateNotification1.txtNotificationTitle.Clear();
            ucCreateNotification1.cbxNotificationType.Items.Clear();
        }
        private void Save(object sender, EventArgs e) 
        {
            if (ucCreateNotification1.cbxNotificationType.Items.ToString() != "" && ucCreateNotification1.txtNotificationContent.Text != "" && ucCreateNotification1.txtNotificationTitle.Text != "")
            {
                _notification.notification_title = ucCreateNotification1.txtNotificationTitle.Text;
                _notification.notification_status = false;
                _notification.notification_content = ucCreateNotification1.txtNotificationContent.Text;
                _notification.timestamp = DateTime.Now;
                _notification.notification_type = ucCreateNotification1.cbxNotificationType.Items.ToString();
                _notification.sender_id = UserSessionHelper.Instance.UserID;
                _notificationRepository.Add(_notification);
                MessageBox.Show("Add Successly");
                this.Hide();
                FNotificationSendStudent fNotificationSendStudent = new FNotificationSendStudent(1,_context);
                fNotificationSendStudent.Show();
            }
            else MessageBox.Show("Add Failly");
        }
        private void Close(object sender, EventArgs e) 
        {
            this.Hide();
        }
    }
}
