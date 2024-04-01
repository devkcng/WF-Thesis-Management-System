using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFThesisManagementSystem.Helper
{
    public class ValidationInformation
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
    }
}
