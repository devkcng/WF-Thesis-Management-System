namespace WFThesisManagementSystem.Helper.SearchEngineHelper
{
    public class Document
    {
        public string TopicId { get; set; }
        public string TeacherName { get; set; }

        public string TeacherId { get; set; }

        public string TopicName { get; set; }
        public string TopicDescription { get; set; }
        public string TopicRequirement { get; set; }
        public string TopicCategory { get; set; }
        public string TopicTechnology { get; set; }

        public string TopicMaxMembers { get; set; }

        // Constructor to initialize properties
        public Document() { }

        public Document(string topicId, string teacherName, string teacherId, string topicName, string topicDescription, string topicRequirement, string topicCategory, string topicTechnology, string topicMaxMembers)
        {
            TopicId = topicId;
            TeacherName = teacherName;
            TeacherId = teacherId;
            TopicName = topicName;
            TopicDescription = topicDescription;
            TopicRequirement = topicRequirement;
            TopicCategory = topicCategory;
            TopicTechnology = topicTechnology;
            TopicMaxMembers = topicMaxMembers;
        }
    }
}
