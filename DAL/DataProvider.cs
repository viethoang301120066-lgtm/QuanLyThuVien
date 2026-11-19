using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>Lớp truy cập CSDL dùng chung (ADO.NET). Luôn dùng tham số để chống SQL Injection.</summary>
    public static class DataProvider
    {
        public static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["QuanLyThuVien"].ConnectionString;

        public static SqlConnection GetConnection() => new SqlConnection(ConnectionString);

        private static SqlCommand CreateCommand(SqlConnection conn, string sql, object[] parameters)
        {
            var cmd = new SqlCommand(sql, conn);
            if (parameters != null)
            {
                // Tham số truyền theo cặp: "@Ten", giaTri, "@Ten2", giaTri2, ...
                for (int i = 0; i < parameters.Length; i += 2)
                    cmd.Parameters.AddWithValue((string)parameters[i], parameters[i + 1] ?? System.DBNull.Value);
            }
            return cmd;
        }

        public static DataTable ExecuteQuery(string sql, params object[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = CreateCommand(conn, sql, parameters))
            using (var da = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static int ExecuteNonQuery(string sql, params object[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = CreateCommand(conn, sql, parameters))
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string sql, params object[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = CreateCommand(conn, sql, parameters))
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}
