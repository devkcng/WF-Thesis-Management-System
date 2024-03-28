using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.DataAccess
{
    public class RegisterQueueDAO
    {
        DBConnect dbconnect = new DBConnect();
        DataTable dttable = new DataTable();
        TopicDAO topicDAO = new TopicDAO(); 
        public string GetDataFromTopicID(string topic_id)
        {
            return string.Format("SELECT * FROM RegisterQueue WHERE topic_id = {0}", topic_id);
        }

        public bool LoadGroupData(int topic_id, DataGridView dgv)
        {
            dttable = dbconnect.GetData(GetDataFromTopicID(topic_id.ToString()));
            if (dttable.Rows.Count > 0)
            {
                // xử lý group name = cột groupname trong datatable
                
                //xử lý datagridview = data table để load data
                LoadMembers(dttable, dgv);

                return true;
            }
            return false;
        }

        public void LoadMembers(DataTable dt, DataGridView dgvTopics)
        {
            dgvTopics.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                // Tạo một mảng các đối tượng để lưu trữ giá trị của mỗi cột trong dòng
                object[] rowData = new object[dt.Columns.Count];

                // Lặp qua từng cột trong DataTable
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    string columnName = dt.Columns[i].ColumnName;
                    if (dgvTopics.Columns.Contains(columnName))
                    {
                        // Lấy chỉ số của cột trong DataGridView
                        int columnIndex = dgvTopics.Columns[columnName].Index;

                        // Thêm giá trị của cột vào mảng dữ liệu nếu có cột tương ứng trong DataGridView
                        rowData[columnIndex] = row[i];
                    }
                }
                dgvTopics.Rows.Add(rowData);

               
            }
            foreach (DataGridViewRow row in dgvTopics.Rows)
            {
                StudentDAO studentDAO = new StudentDAO();
                if (!row.IsNewRow)
                {
                    row.Cells["student_name"].Value = studentDAO.GetStudentNameFromID(row.Cells["student_id"].Value.ToString());
                }
            }
        }

        public string AddRegisterQueueData(int student_id, int group_id, int topic_id)
        {
            return string.Format("INSERT INTO RegisterQueue (student_id , group_id, topic_id) " +
                                            "VALUES ('{0}', '{1}' ,'{2}')",
                                                       student_id.ToString(), group_id.ToString(), topic_id.ToString());
        }

        public string GetTopicIDFromStudentID(string student_id)
        {
            return string.Format("SELECT topic_id FROM RegisterQueue WHERE topic_id = '{0}'", student_id);
        }

        public string GetGroupIDFromTopicID(int topic_id)
        {
            return string.Format("SELECT group_id FROM RegisterQueue WHERE topic_id = '{0}'", topic_id);
        }
        public bool IsStudentAvailable(int student_id)
        {
            if (dbconnect.GetData(string.Format("SELECT * FROM RegisterQueue WHERE student_id = '{0}'", student_id)).Rows.Count > 0)
                return true;
            else return false;
        }
        public string GetGroupName(int topic_id)
        {
            return string.Format("SELECT sg.group_name FROM RegisterQueue rq INNER JOIN Student_Group sg ON rq.group_id = sg.group_id WHERE rq.topic_id = {0}", topic_id);
        }
    }
}
