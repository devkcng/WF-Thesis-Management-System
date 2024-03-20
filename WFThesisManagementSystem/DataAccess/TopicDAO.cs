using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.DataAccess
{
    internal class TopicDAO
    {
        public bool Add(Topic topic, string Tablename)
        {
            DBConnect dbconnection = new DBConnect();
            string SQL = string.Format("INSERT INTO {7}(topic_id , topic_name, topic_description,technology,requirement,category,number) VALUES ('{0}', '{1}' ,'{2}','{3}','{4}','{5}','{6}')", topic.Id, topic.Name, topic.Description, topic.Technology, topic.Requirement, topic.Category, topic.Number, Tablename);
            return dbconnection.ExecuteSqlQuery(SQL);
        }
        public bool Delect(string id, string Tablename)
        {
            DBConnect dbconnection = new DBConnect();
            string SQL = string.Format("DELETE FROM {1} WHERE topic_id = '{0}'", id, Tablename);
            return dbconnection.ExecuteSqlQuery(SQL);
        }
        public bool Fix(Topic topic, string Tablename)
        {
            DBConnect dbconnection = new DBConnect();
            string SQL = string.Format("UPDATE {7} SET topic_name = '{0}', topic_description ='{1}', technology = '{2}', requirement= '{3}',category = '{4}',number = '{5}' WHERE topic_id = '{6}' ", topic.Name, topic.Description, topic.Technology, topic.Requirement, topic.Category, topic.Number, topic.Id, Tablename);
            return dbconnection.ExecuteSqlQuery(SQL);
        }
    }
}
