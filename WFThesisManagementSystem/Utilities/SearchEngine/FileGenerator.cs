using System.Data.SqlClient;
using System.IO;
using WFThesisManagementSystem.DataAccess;
namespace WFThesisManagementSystem.Utilities.SearchEngine
{
    public class FileGenerator
    {
        private DBConnect _db = new DBConnect();
        string directoryPath = @"TopicFiles\";

        public void Generator()
        {   
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            using (SqlConnection connection = _db._conn)
            {
                string query =
                    "SELECT T.topic_id, T.topic_name, T.topic_description, T.topic_requirement, T.topic_category, T.topic_technology, T.max_members ,S.teacher_name, T.teacher_id " +
                    "FROM Topics T " +
                    "JOIN Teacher S ON T.teacher_id = S.teacher_id";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string topicId = reader.GetInt32(0).ToString();
                    string topicName = reader.GetString(1);
                    string topicDescription = reader.GetString(2);
                    string topicRequirement = reader.GetString(3);
                    string topicCategory = reader.GetString(4);
                    string topicTechnology = reader.GetString(5);
                    string topicMaxMembers = reader.GetInt32(6).ToString();
                    string teacherName = reader.GetString(7);
                    string teacherId = reader.GetInt32(8).ToString();
                    

                    string filePath = Path.Combine(directoryPath, $"{topicId}.txt");

                    using (StreamWriter writer = new StreamWriter(filePath))
                    {   
                        writer.WriteLine($"Topic Id: {topicId}");
                        writer.WriteLine($"Teacher Name: {teacherName}");
                        writer.WriteLine($"Teacher Id: {teacherId}");
                        writer.WriteLine($"Topic Name: {topicName}");
                        writer.WriteLine($"Topic Description: {topicDescription}");
                        writer.WriteLine($"Topic Requirement: {topicRequirement}");
                        writer.WriteLine($"Topic Category: {topicCategory}");
                        writer.WriteLine($"Topic Technology: {topicTechnology}");
                        writer.WriteLine($"Topic Max Members: {topicMaxMembers}");
                    }
                }
                connection.Close();
            }
        }
    }
}
