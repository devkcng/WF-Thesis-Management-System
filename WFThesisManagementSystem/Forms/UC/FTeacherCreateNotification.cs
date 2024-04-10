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
using WFThesisManagementSystem.Services;

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
            //if (ucCreateNotification1.cbxNotificationType.Items.ToString() != "" && ucCreateNotification1.txtNotificationContent.Text != "" && ucCreateNotification1.txtNotificationTitle.Text != "")
            //{
            //    IdGeneratorHelper idGeneratorHelper = new IdGeneratorHelper();
            //    _notification.notification_title = ucCreateNotification1.txtNotificationTitle.Text;
            //    _notification.notification_status = false;
            //    _notification.notification_content = ucCreateNotification1.txtNotificationContent.Text;
            //    _notification.timestamp = DateTime.Now;
            //    _notification.notification_type = ucCreateNotification1.cbxNotificationType.SelectedItem.ToString();
            //    _notification.sender_id = UserSessionHelper.Instance.UserID;
            //    _notification.notification_id = idGeneratorHelper.GenerateNotificationId();
            //    _notificationRepository.Add(_notification);
            //    MessageBox.Show("Add Successly");
            //    this.Hide();
            //    FNotificationSendStudent fNotificationSendStudent = new FNotificationSendStudent(_notification.notification_id,_context);
            //    fNotificationSendStudent.Show();
            //}
            //else MessageBox.Show("Add Failly");

            var validationInfor = new ValidationInformationHelper();
            if (!validationInfor.CheckNotification(ucCreateNotification1.txtNotificationTitle.Text,
                    ucCreateNotification1.txtNotificationContent.Text
                    , ucCreateNotification1.cbxNotificationType.Items.ToString()))
            {
                MessageBox.Show("Please fill all information");
                return;
            }
            else
            {
                var message = new NotificationMessage
                {
                    Title = ucCreateNotification1.txtNotificationTitle.Text,
                    Message = ucCreateNotification1.txtNotificationContent.Text,
                    Type = ucCreateNotification1.cbxNotificationType.SelectedItem.ToString()
                };

                var notificationService = new NotificationService(_context);
                FNotificationSendStudent fNotificationSendStudent = new FNotificationSendStudent(message, _context);
                fNotificationSendStudent.Show();
            }


        }
        private void Close(object sender, EventArgs e) 
        {
            this.Hide();
        }
    }
}
