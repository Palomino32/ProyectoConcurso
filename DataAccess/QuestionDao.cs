using Common;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class QuestionDao: ConnectionToSql
    {
        public List<Question> GetQuestions() 
        {
            List<Question> list = new List<Question>();
            using (var conn = GetSqlConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "Select * from [dbo].[Table_Questions]";
                    SqlDataReader reader = cmd.ExecuteReader();                    
                        while (reader.Read())
                        {
                            Question question = new Question();
                            question.Id = Convert.ToInt32(reader["Id"]);
                            question.Pregunta = reader["Pregunta"].ToString();
                            question.Nivel_Id = Convert.ToInt32(reader["Nivel_Id"]);
                            question.Premio = Convert.ToDecimal(reader["Premio"]);
                            list.Add(question);
                        }                    
                }
                return list;

            }
        }       
    }
}
