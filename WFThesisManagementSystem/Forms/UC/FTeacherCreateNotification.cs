using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.UC
{
    public partial class FTeacherCreateNotification : Form
    {
        public FTeacherCreateNotification()
        {
            InitializeComponent();
            ucCreateNotification1.btnClear.Click += Clear;
            ucCreateNotification1.btnSave.Click += Save;
            ucCreateNotification1.btnClose.Click += Close;
        }
        private void Clear(object sender, EventArgs e)
        {
            ucCreateNotification1.txtNotificationContent.Clear();
            ucCreateNotification1.txtNotificationTitle.Clear();
            ucCreateNotification1.cbxNotificationType.Items.Clear();
        }
        private void Save(object sender, EventArgs e) 
        {
            
        }
        private void Close(object sender, EventArgs e) 
        {
            this.Hide();
        }
    }
}
