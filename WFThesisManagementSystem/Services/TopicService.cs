using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Services
{
    public class TopicService
    {
        Topic _topic;
        public TopicService() { }
        public TopicService(Topic topic) {
            _topic = topic;
        }
        public bool CheckTopicId(string topicId) 
        {
            for (int i = 0; i <= topicId.Length - 1; i++)
            {
                if (topicId[i] > '9' || topicId[i] < '0')
                {
                    
                    return false;
                }
            }
            return true;
        }
        public bool CheckMaxMember(string max_member)
        {
            for (int i = 0; i <= max_member.Length - 1; i++)
            {
                if (max_member[i] > '9' || max_member[i] < '0')
                {

                    return false;
                }
            }
            return true;
        }
        public bool AlreadyCreateTopic()
        {
            if(_topic.topic_description!="" && _topic.topic_technology!=""&& _topic.topic_requirement!="" && _topic.topic_name!="" && _topic.topic_category!="")
            {
                return true;
            }
            return false;
        }
    }
}
