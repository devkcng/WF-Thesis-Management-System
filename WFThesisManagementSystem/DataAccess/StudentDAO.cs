using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.DataAccess
{
    public class StudentDAO
    {
        
        // Update student group khi đăng kí nhóm thành công
        public string UpdateStudentGroup(int group_id, int student_id)
        {
            return string.Format("UPDATE Student SET group_id = {0} WHERE student_id = {1}", group_id, student_id);
        }

        // load những topic của từng student vào form studentProject
        public string Student_LoadTopics(Student student)
        {
            return string.Format("SELECT t.* FROM Student s JOIN Student_Group g ON s.group_id = g.group_id  JOIN Topics t ON g.topic_id = t.topic_id WHERE s.student_id = {0}", student.Id);
        }

        //Get student id từ username để truyền student id vào class FstudentDashboard
        public string GetStudentIDFromUsername(string username)
        {
            DBConnect dBConnect = new DBConnect();
            DataTable dataTable = new DataTable();
            string query = "SELECT student_id FROM StudentAccount WHERE student_username = @Username";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Username", username);
            dataTable = dBConnect.GetData(command); 
            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0]["student_id"].ToString(); 
            }
            return null;
        }

        //public bool IsStudent(string username)
        //{
        //    DBConnect dBConnect = new DBConnect();
        //    DataTable dataTable = new DataTable();
        //    dataTable = dBConnect.GetData(string.Format("SELECT student_id FROM StudentAccount WHERE student_username = {0}", username));
        //    return dataTable.Rows[0].ToString();
        //}
    }
}
