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
        public string GetTeacherNameFromTeacherID(string teacherID)
        {
            DBConnect dBConnect = new DBConnect();
            DataTable dataTable = new DataTable();
            dataTable = dBConnect.GetData(string.Format("SELECT teacher_name FROM Teacher WHERE teacher_id = {0}", teacherID));
            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0]["teacher_name"].ToString();
            }
            return null;
        }
    }
}
