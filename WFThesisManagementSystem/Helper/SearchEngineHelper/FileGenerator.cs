using System.IO;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Helper.SearchEngineHelper
{
    public class FileGenerator
    {
        //private DBConnect _db = new DBConnect();
        //string directoryPath = @"TopicFiles\";

        //public void Generator()
        //{   
        //    if (!Directory.Exists(directoryPath))
        //    {
        //        Directory.CreateDirectory(directoryPath);
        //    }
        //    else
        //    {
        //        Directory.Delete(directoryPath, true);
        //        Directory.CreateDirectory(directoryPath);
        //    }

        //    using (SqlConnection connection = _db._conn)
        //    {
        //        string query =
        //            "SELECT T.topic_id, T.topic_name, T.topic_description, T.topic_requirement, T.topic_category, T.topic_technology, T.max_members ,S.teacher_name, T.teacher_id " +
        //            "FROM Topics T " +
        //            "JOIN Teachers S ON T.teacher_id = S.teacher_id";

        //        SqlCommand command = new SqlCommand(query, connection);

        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            string topicId = reader.GetInt32(0).ToString();
        //            string topicName = reader.GetString(1);
        //            string topicDescription = reader.GetString(2);
        //            string topicRequirement = reader.GetString(3);
        //            string topicCategory = reader.GetString(4);
        //            string topicTechnology = reader.GetString(5);
        //            string topicMaxMembers = reader.GetInt32(6).ToString();
        //            string teacherName = reader.GetString(7);
        //            string teacherId = reader.GetInt32(8).ToString();


        //            string filePath = Path.Combine(directoryPath, $"{topicId}.txt");

        //            using (StreamWriter writer = new StreamWriter(filePath))
        //            {   
        //                writer.WriteLine($"Topic Id: {topicId}");
        //                writer.WriteLine($"Teacher Name: {teacherName}");
        //                writer.WriteLine($"Teacher Id: {teacherId}");
        //                writer.WriteLine($"Topic Name: {topicName}");
        //                writer.WriteLine($"Topic Description: {topicDescription}");
        //                writer.WriteLine($"Topic Requirement: {topicRequirement}");
        //                writer.WriteLine($"Topic Category: {topicCategory}");
        //                writer.WriteLine($"Topic Technology: {topicTechnology}");
        //                writer.WriteLine($"Topic Max Members: {topicMaxMembers}");
        //            }
        //        }
        //        connection.Close();
        //}
        //}
        private ThesisManagementContext _context = new ThesisManagementContext();
        string directoryPath = @"TopicFiles\";
        public void Generator()
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            else
            {
                Directory.Delete(directoryPath, true);
                Directory.CreateDirectory(directoryPath);
            }
            TopicRepository topicRepository = new TopicRepository(_context);
            var topics = topicRepository.GetAll();
            foreach (var topic in topics)
            {
                string topicId = topic.topic_id.ToString();
                string topicName = topic.topic_name;
                string topicDescription = topic.topic_description;
                string topicRequirement = topic.topic_requirement;
                string topicCategory = topic.topic_category;
                string topicTechnology = topic.topic_technology;
                string topicMaxMembers = topic.max_members.ToString();
                string teacherName = topic.Teacher.teacher_name;
                string teacherId = topic.teacher_id.ToString();

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
        }
    }
}
