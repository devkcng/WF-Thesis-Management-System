﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace WFThesisManagementSystem.DataAccess
{
    public class DBConnect
    {
        private const string DatabaseRelativePath = @"..\..\..\DATABASE\ThesisManagement.mdf";

        private static readonly string ExecutablePath = AppDomain.CurrentDomain.BaseDirectory;

        private static readonly string DatabaseFilePath = Path.GetFullPath(Path.Combine(ExecutablePath, DatabaseRelativePath));

        private static readonly string ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={DatabaseFilePath};Integrated Security=True";
        public readonly SqlConnection _conn = new SqlConnection(ConnectionString);

        public bool ExecuteSqlQuery(string sqlStr)
        {
            try
            {
                _conn.Open();
                var cmd = new SqlCommand(sqlStr, _conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable LoadData(string tablename)
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();
                string sqlStr = string.Format("SELECT *FROM {0}", tablename);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, _conn);
                DataTable dtTopics = new DataTable();
                adapter.Fill(dtTopics);
                dt = dtTopics; /// gvHsinh = name cua data gridview
            }
            catch (Exception exc)
            {
                //MessageBox.Show(exc.Message);
            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }
    }
}
