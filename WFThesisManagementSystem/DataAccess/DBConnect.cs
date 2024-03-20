using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace WFThesisManagementSystem.DataAccess
{
    internal class DBConnect
    {
        private const string DatabaseRelativePath = @"..\..\..\DATABASE\ThesisManagement.mdf";

        private static readonly string ExecutablePath = AppDomain.CurrentDomain.BaseDirectory;

        private static readonly string DatabaseFilePath = Path.GetFullPath(Path.Combine(ExecutablePath, DatabaseRelativePath));

        private static readonly string ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={DatabaseFilePath};Integrated Security=True";
        private readonly SqlConnection _conn = new SqlConnection(ConnectionString);

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
    }
}
