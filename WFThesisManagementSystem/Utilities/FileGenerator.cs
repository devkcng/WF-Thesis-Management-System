using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using WFThesisManagementSystem.DataAccess;

namespace WFThesisManagementSystem.Utilities
{
    public class FileGenerator
    {
        private DBConnect _db = new DBConnect();
        string directoryPath = @"E:\TopicFiles\";

        public void Generator()
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            using (SqlConnection connection = _db._conn)
            {
                string query =
                    "SELECT T.topic_id, T.topic_name, T.topic_description, T.topic_requirement, T.topic_category, T.topic_technology, S.teacher_name " +
                    "FROM Topics T " +
                    "JOIN Teacher S ON T.teacher_id = S.teacher_id";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int topicId = reader.GetInt32(0);
                    string topicName = reader.GetString(1);
                    string topicDescription = reader.GetString(2);
                    string topicRequirement = reader.GetString(3);
                    string topicCategory = reader.GetString(4);
                    string topicTechnology = reader.GetString(5);
                    string teacherName = reader.GetString(6);

                    string filePath = Path.Combine(directoryPath, $"{topicId}.txt");

                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine($"Teacher Name: {teacherName}");
                        writer.WriteLine($"Topic Name: {topicName}");
                        writer.WriteLine($"Topic Description: {topicDescription}");
                        writer.WriteLine($"Topic Requirement: {topicRequirement}");
                        writer.WriteLine($"Topic Category: {topicCategory}");
                        writer.WriteLine($"Topic Technology: {topicTechnology}");
                    }
                }
            }
        }
    }
}
