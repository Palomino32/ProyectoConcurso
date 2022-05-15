using Common;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class UserDataDao : ConnectionToSql
    {
        public List<UserData> GetUserDatas()
        {
            List<UserData> list = new List<UserData>();
            using (var conn = GetSqlConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "Select * from [dbo].[Table_UserData]";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UserData userData = new UserData();
                        userData.Id = Convert.ToInt32(reader["Id"]);
                        userData.Nivel_Id = Convert.ToInt32(reader["Nivel_Id"]);
                        userData.User_Id = Convert.ToInt32(reader["User_Id"]);
                        userData.Premio_Acumulado = Convert.ToDecimal(reader["Premio_Acumulado"]);
                        list.Add(userData);
                    }
                }
                return list;

            }
        }

        public bool AddUserData(UserData data)
        {
            using (var conn = GetSqlConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("[dbo].[SP_AddUserData]", conn))
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NivelId", data.Nivel_Id);
                    cmd.Parameters.AddWithValue("@UserId", data.User_Id);
                    cmd.Parameters.AddWithValue("@Premio_Acumulado", data.Premio_Acumulado);                    
                    cmd.ExecuteReader();
                }
                return true;
            }
        }
    }
}
