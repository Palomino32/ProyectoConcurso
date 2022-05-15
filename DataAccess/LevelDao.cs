using Common;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class LevelDao: ConnectionToSql
    {
        public List<Level> GetLevels()
        {
            List<Level> list = new List<Level>();
            using (var conn = GetSqlConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "Select * from [dbo].[Table_Level]";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Level level = new Level();
                        level.Id = Convert.ToInt32(reader["Id"]);                        
                        level.Nivel = Convert.ToInt32(reader["Nivel"]);
                        level.Categoria = reader["Categoría"].ToString();
                        list.Add(level);
                    }
                }
                return list;

            }
        }

    }
}
