using Common;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class AnswerDao: ConnectionToSql
    {
        public List<Answer> GetAnswers()
        {
            List<Answer> list = new List<Answer>();
            using (var conn = GetSqlConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "Select * from [dbo].[Table_Answers]";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Answer answer = new Answer();
                        answer.Id = Convert.ToInt32(reader["Id"]);
                        answer.Respuesta = reader["Respuesta"].ToString();
                        answer.is_correct = Convert.ToBoolean(reader["is_correct"]);
                        answer.Pregunta_Id = Convert.ToInt32(reader["Pregunta_Id"]);
                        list.Add(answer);
                    }
                }
                return list;

            }
        }

    }
}
