using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class UserDao: ConnectionToSql
    {
        public bool Login (string user, string pass)
        {
            using (var conn = GetSqlConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from [dbo].[Table_UserLogin] where Usuario=@user and Contraseña=@pass";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else { return false; }
                }

            }
        }
    }
}
