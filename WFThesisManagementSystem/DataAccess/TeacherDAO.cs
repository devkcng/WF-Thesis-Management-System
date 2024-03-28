using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WFThesisManagementSystem.DataAccess
{
    public class TeacherDAO
    {
        // (nhả dữ liệu để dán dữ liệu lên cột teacher name bên FStudentRegisterTopic)
        public string GetTeacherNameFromTeacherID(string teacherID, DataTable dtbTeacherName)
        {

            if (dtbTeacherName.Rows.Count > 0)
            {
                return dtbTeacherName.Rows[0]["teacher_name"].ToString();
            }
            return null;
        }
    }
}
