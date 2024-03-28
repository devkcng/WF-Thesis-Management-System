﻿using System;
using System.Data;
using System.Windows.Forms;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.DataAccess
{
    internal class TopicDAO
    {
        DBConnect dBConnect = new DBConnect();
        DataTable dataTable = new DataTable();
        TeacherDAO teacherDAO = new TeacherDAO();

        public bool CheckData(Topic topic)
        {
            if (topic.Category == "" || topic.Name == "" || topic.Requirement == "" || topic.Technology == "" || topic.Description == "" || (topic.MaxMember <= 0 || topic.MaxMember > 6)) return false;
            return true;
        }
        public string AddTopic(Topic topic)
        {
            return string.Format("INSERT INTO Topics (topic_id , topic_name, topic_description, topic_technology, topic_requirement, topic_category, max_members , teacher_id) " +
                                 "VALUES ('{0}', '{1}' ,'{2}','{3}','{4}','{5}','{6}','{7}')",
                                            topic.Id, topic.Name, topic.Description, topic.Technology, topic.Requirement, topic.Category, topic.MaxMember, topic.Teacher_id);
        }
        public string DeleteTopic(Topic topic)
        {
            return string.Format("DELETE FROM Topics WHERE topic_id = '{0}'", topic.Id);
        }
        public string UpdateTopic(Topic topic)
        {
            return string.Format("UPDATE Topics SET topic_name = '{0}', topic_description ='{1}', topic_technology = '{2}', topic_requirement= '{3}', topic_category = '{4}', max_members = '{5}' WHERE topic_id = '{6}' ",
                                    topic.Name, topic.Description, topic.Technology, topic.Requirement, topic.Category, topic.MaxMember, topic.Id);
        }
        public void LoadTopic(string sql, DataGridView dgvTopics)
        {
            try { 
            DBConnect dBConnect = new DBConnect();
            DataTable dt = new DataTable();
            TeacherDAO teacherDao = new TeacherDAO();

            dt = dBConnect.GetData(sql);

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
                if (!row.IsNewRow)
                {
                    row.Cells["teacher_name"].Value = teacherDao.GetTeacherNameFromTeacherID(row.Cells["teacher_id"].Value.ToString(), dBConnect.GetData(string.Format("SELECT teacher_name FROM Teacher WHERE teacher_id = {0}", row.Cells["teacher_id"].Value.ToString())));
                }
            }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


    }
}
