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
        DBConnect dBConnect = new DBConnect();
        public string AddGroup(StudentGroup studentGroup)
        {
            return string.Format("INSERT INTO Student_Group (group_id , group_name, topic_id, number_of_students) " +
                                 "VALUES ('{0}', '{1}' ,'{2}','{3}')",
                                            studentGroup.group_id, studentGroup.group_name, studentGroup.topic_id, studentGroup.number_of_students);
        }


    }
}
