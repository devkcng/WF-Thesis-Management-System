using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.DataAccess
{
    internal class StudentGroupDAO
    {
        public string AddGroup(StudentGroup studentGroup)
        {
            return string.Format("INSERT INTO Student_Group (group_id , group_name, topic_id, number_of_students) " +
                                 "VALUES ('{0}', '{1}' ,'{2}','{3}')",
                                            studentGroup.Id, studentGroup.Name, studentGroup.TopicID, studentGroup.Size);
        }


    }
}
