using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFThesisManagementSystem.DataAccess
{
    internal class RegistDAO
    {
        public static string UpdateAccept(string id) => string.Format($"UPDATE RegisterQueue SET accepted = 1 WHERE student_id ={id} AND accepted = 0 ");
        public static string UpdateGroupid(string id,string group_id)
        {
            return string.Format($"UPDATE Student SET group_id = {group_id} WHERE student_id ={id} ");
        }
    }

}
