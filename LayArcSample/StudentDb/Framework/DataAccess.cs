using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace StudentDb.Framework
{
    public class DataAccess
    {
        string connectionString = "Data Source=172.16.2.93;Initial Catalog=00000000_Student;Persist Security Info=True;User ID=00-00000-0;Password=123456";

        public bool Post(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            command.Connection = connection;
            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }

        public DataTable Query(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            connection.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }
    }
}
