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

            // Load existing messages
            LoadExistingMessages();
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
            flpMessages.Controls.Add(messageControl);
            flpMessages.ScrollControlIntoView(messageControl);
        }

        private void DisplaySentMessage(UserControl messageControl)
        {
            flpMessages.Controls.Add(messageControl);
            flpMessages.ScrollControlIntoView(messageControl);
        }
    }
}
