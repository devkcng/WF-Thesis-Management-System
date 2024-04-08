using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Forms.UC
{
    public partial class FNotificationSendStudent : Form
    {
        private ThesisManagementContext _context;
        private int _notification_id;
        private NotificationRepository _notificationRepository;

        public FNotificationSendStudent(int notification_id , ThesisManagementContext context)
        {
            InitializeComponent();
            _notification_id = notification_id;
            _context = context;
            _notificationRepository = new NotificationRepository(_context);
            ucNotificationSendStudentAll1.btnBackToEdit.Click += Close;
            ucNotificationSendStudentAll1.btnSend.Click += Send;
        }
        private void Close(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Send(object sender, EventArgs e)
        {

        }
    }
}
