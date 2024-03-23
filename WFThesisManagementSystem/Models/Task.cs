using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFThesisManagementSystem.Models
{
    internal class Task
    {
        public int Id { get; set; }
        public string NameTeacher { get; set; }

        public string NameTopic { get; set; }
        public string TopicId { get; set; } 

        public Task() {  }

        public Task(int id, string nameTeacher, string nameTopic, string topicId)
        {
            Id = id;
            NameTeacher = nameTeacher;
            NameTopic = nameTopic;
            TopicId = topicId;
        }
    }
}
