﻿using System;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.UC
{
    public partial class UcNotification : UserControl
    {
        public event EventHandler CheckBox;
        public UcNotification()
        {
            InitializeComponent();
            icmCheckbox.Click += IcmCheckbox_Click;
        }
        #region Properties
        private string name;
        private string content;
        private string sendBy;
        private DateTime sendTime;
        public int Id { get; set; }
        public string Name
        {
            set { name = value; lblNotificationName.Text = value; }
            get { return name; }
        }
        public string Content
        {
            set { content = value; lblNotificationContent.Text = value; }
            get { return content; }
        }
        public string SendBy
        {
            set { sendBy = value; lblSendBy.Text = value; }
            get { return sendBy; }
        }
        public DateTime SendTime
        {
            set { sendTime = value; dtpSendTime.Value = value; }
            get { return sendTime; }
        }
        #endregion
        #region EventCheckBox
        private void IcmCheckbox_Click(object sender, EventArgs e)
        {
            OnCheckBoxClicked(EventArgs.Empty);
        }
        protected virtual void OnCheckBoxClicked(EventArgs e)
        {
            CheckBox?.Invoke(this, EventArgs.Empty);
        }

        #endregion
    }
}
