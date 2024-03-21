using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

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
        public DataTable LoadData(string tableName)
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();
                string sqlStr = string.Format("SELECT *FROM {0}", tableName);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, _conn);
                DataTable dtTable = new DataTable();
                adapter.Fill(dtTable);
                dt = dtTable; 
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }

        public DataTable GetData(string sqlStr)
        {
            try
            {
                _conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, _conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                return dtSinhVien;
            }
            catch (Exception exc)
            {
                throw new Exception("Load unsuccessfully", exc);
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable GetData(SqlCommand command)
        {
                command.Connection = _conn;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                _conn.Open();
                adapter.Fill(dataTable);
                return dataTable;
        }
    }
}
