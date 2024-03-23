using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFThesisManagementSystem.Models;
using Task = WFThesisManagementSystem.Models.Task;

namespace WFThesisManagementSystem.DataAccess
{
    internal class TaskDAO
    {
        public string AddTask(Task task)
        {
            return string.Format("INSERT INTO Tasks (topic_id , topic_name, topic_description, topic_technology, topic_requirement, topic_category, max_members) " +
                                 "VALUES ('{0}', '{1}' ,'{2}','{3}','{4}','{5}','{6}')",
                                            task.Id, task.TopicId,task.NameTeacher,task.NameTopic);
        }
        public string DeleteTask(Task task)
        {
            return string.Format("DELETE FROM Tasks WHERE topic_id = '{0}'", task.Id);
        }
        public string UpdateTask(Task task)
        {
            return string.Format("UPDATE Tasks SET topic_name = '{0}', topic_description ='{1}', topic_technology = '{2}', topic_requirement= '{3}', topic_category = '{4}', max_members = '{5}' WHERE topic_id = '{6}' ",
                                     task.Id, task.TopicId, task.NameTeacher, task.NameTopic);
        }
    }
}
