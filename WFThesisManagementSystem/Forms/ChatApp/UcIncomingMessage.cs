using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.ChatApp
{
    public partial class UcIncomingMessage : UserControl
    {
        public UcIncomingMessage()
        {
            InitializeComponent();
        }

        public string UserName
        {
            get { return lblUserName.Text; }
            set { lblUserName.Text = value; }
        }

        public string MessageText
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }

        public string Timestamp
        {
            get { return lblTimestamp.Text; }
            set { lblTimestamp.Text = value; }
        }

    }
}
