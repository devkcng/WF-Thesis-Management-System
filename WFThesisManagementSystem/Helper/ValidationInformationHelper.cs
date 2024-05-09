namespace WFThesisManagementSystem.Helper
{
    public class ValidationInformationHelper
    {
        //check if the string is a number
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

        //email validation, with popular regex
        public bool CheckEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        //check if all information of notification is filled

        public bool CheckNotification(string title, string content, string type)
        {
            if (title != "" && content != "" && type != "")
            {
                return true;
            }
            return false;
        }
        public int CheckMarkValid(string mark)
        {
            int count = 0;
            if (mark[0] == '.') return 0;
            for (int i = 0; i < mark.Length; i++)
            {
                if (mark[i] == '.') count++;
                else if (mark[i] < '0' || mark[i] > '9') return 0;
            }
            if (count == 0) return 1;
            if (count == 1) return 2;
            return 0;
        }
    }
}
