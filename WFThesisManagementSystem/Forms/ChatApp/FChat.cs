using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Database.Streaming;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Services;
using Message = WFThesisManagementSystem.Services.Message;
using TaskOfGroup = WFThesisManagementSystem.Models.Task;

namespace WFThesisManagementSystem.Forms.ChatApp
{
    public partial class FChat : Form
    {
        private ChatService _chatService;

        public FChat(TaskOfGroup task)
        {
            InitializeComponent();
            _chatService = new ChatService(task);
            lblTaskName.Text = task.task_name;

            CheckInternetConnection();

            // Load existing messages
            LoadExistingMessages();

            // Listen for new messages
            _chatService.NewMessageReceived += ChatService_NewMessageReceived;
            _chatService.ListenForNewMessages();

        }

        private async void ChatService_NewMessageReceived(Message message)
        {
            if (!IsDisposed && !Disposing)
            {
                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        DisplayMessage(_chatService.CreateMessageControl(message));
                    });
                }
                else
                {
                    DisplayMessage(_chatService.CreateMessageControl(message));
                }
            }
        }
        private void CheckInternetConnection()
        {
            if (_chatService.CheckInternetConnection())
            {
                return;
            }
            btnSend.Enabled = false;
            MessageBox.Show("No internet connection available.");
        }

        private async void LoadExistingMessages()
        {
            await _chatService.LoadExistingMessages(DisplayMessage);
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            await _chatService.SendMessage(txtMessage.Text, DisplaySentMessage);
            txtMessage.Text = "";
        }

        private void DisplayMessage(UserControl messageControl)
        {   
            if (messageControl == null) return;
            foreach (var uc in flpMessages.Controls)
            {
                if (uc is UcIncomingMessage)
                {
                    var incomingMessage = uc as UcIncomingMessage;
                    if (incomingMessage.MessageText == (messageControl as UcIncomingMessage)?.MessageText 
                        && incomingMessage.Timestamp ==(messageControl as UcIncomingMessage)?.Timestamp)
                    {
                        return;
                    }
                }

                if (uc is UcOutgoingMessage)
                {
                    var outgoingMessage = uc as UcOutgoingMessage;
                    if (outgoingMessage.MessageText == (messageControl as UcOutgoingMessage)?.MessageText 
                        && outgoingMessage.Timestamp == (messageControl as UcOutgoingMessage)?.Timestamp)
                    {
                        return;
                    }
                }
            }

            flpMessages.Controls.Add(messageControl);
            flpMessages.ScrollControlIntoView(messageControl);
        }

        private void DisplaySentMessage(UserControl messageControl)
        {
            flpMessages.Controls.Add(messageControl);
            flpMessages.ScrollControlIntoView(messageControl);
        }

        protected override void Dispose(bool disposing)
        {   
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (disposing)
            {
                _chatService.NewMessageReceived -= ChatService_NewMessageReceived;
                _chatService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
