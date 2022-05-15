using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string _connectionString;
        public ConnectionToSql()
        {
            _connectionString = "data source=az-server-dp-test.database.windows.net; initial catalog=az-sql-concurso-dp; User Id=adminDP; Password=V.18539299; MultipleActiveResultSets=True;";            
        }
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}