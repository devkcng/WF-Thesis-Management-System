using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.DataAccess
{
    internal class TopicDAO
    {
        public string AddTopic(Topic topic)
        {
            return string.Format("INSERT INTO Topics (topic_id , topic_name, topic_description, topic_technology, topic_requirement, topic_category, max_members) " +
                                 "VALUES ('{0}', '{1}' ,'{2}','{3}','{4}','{5}','{6}')",
                                            topic.Id, topic.Name, topic.Description, topic.Technology, topic.Requirement, topic.Category, topic.MaxMember);
        }
        public string DeleteTopic(Topic topic)
        {
            return string.Format("DELETE FROM Topics WHERE topic_id = '{0}'", topic.Id);
        }
        public string UpdateTopic(Topic topic)
        {
            return string.Format("UPDATE Topics SET topic_name = '{0}', topic_description ='{1}', topic_technology = '{2}', topic_requirement= '{3}', topic_category = '{4}', max_members = '{5}' WHERE topic_id = '{6}' ",
                                    topic.Name, topic.Description, topic.Technology, topic.Requirement, topic.Category, topic.MaxMember, topic.Id);
        }
    }
}
