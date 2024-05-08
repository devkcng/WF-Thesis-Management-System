using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Database.Streaming;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using TaskOfGroup = WFThesisManagementSystem.Models.Task;
using Task = System.Threading.Tasks.Task;
using WFThesisManagementSystem.Forms.ChatApp;

namespace WFThesisManagementSystem.Services
{   
    public class Message
    {   
        public string UserId { get; set; }
        public string User { get; set; }
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class ChatService
    {
        private FirebaseClient _firebaseClient;
        private TaskOfGroup _task;

        public ChatService(TaskOfGroup task)
        {
            _task = task;
            _firebaseClient = new FirebaseClient("https://chatapp-wfthesismanagement-default-rtdb.firebaseio.com/");
        }

        public async Task LoadExistingMessages(Action<UserControl> displayMessage)
        {
            var existingMessages = await _firebaseClient
                .Child("Conversations")
                .Child(_task.task_id.ToString())
                .OnceAsync<Message>();

            var sortedMessages = existingMessages
                .Select(messageSnapshot => messageSnapshot.Object)
                .OrderBy(message => message.Timestamp);

            foreach (var message in sortedMessages)
            {
                var messageControl = CreateMessageControl(message);
                displayMessage(messageControl);
            }
        }

        public async Task SendMessage(string text, Action<UserControl> displaySentMessage)
        {
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter a message");
                return;
            }

            string customeKey = Guid.NewGuid().ToString();
            var messageRef = _firebaseClient.Child("Conversations").Child(_task.task_id.ToString()).Child(customeKey);

            var sentMessage = new Message
            {
                UserId = UserSessionHelper.Instance.UserID.ToString(),
                User = UserSessionHelper.Instance.Name,
                Text = text,
                Timestamp = DateTime.Now
            };

            await messageRef.PutAsync(sentMessage);

            // Display the sent message immediately
            var messageControl = CreateMessageControl(sentMessage);
            displaySentMessage(messageControl);
        }

        private UserControl CreateMessageControl(Message message)
        {
            UserControl messageControl;

            if (message.UserId == UserSessionHelper.Instance.UserID.ToString())
            {
                var ucOutgoingMessage = new UcOutgoingMessage();
                ucOutgoingMessage.UserName = message.User;
                ucOutgoingMessage.MessageText = message.Text;
                ucOutgoingMessage.Timestamp = message.Timestamp.ToString("HH:mm");
                messageControl = ucOutgoingMessage;
            }
            else
            {
                var ucIncomingMessage = new UcIncomingMessage();
                ucIncomingMessage.UserName = message.User;
                ucIncomingMessage.MessageText = message.Text;
                ucIncomingMessage.Timestamp = message.Timestamp.ToString("HH:mm");
                messageControl = ucIncomingMessage;
            }

            return messageControl;
        }
    }
}
