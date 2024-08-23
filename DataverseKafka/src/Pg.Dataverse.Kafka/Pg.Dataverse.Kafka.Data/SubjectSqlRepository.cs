using System.Data.SqlClient;

namespace Pg.Dataverse.Kafka.Data
{
    public class SubjectSqlRepository : ISubjectRepository
    {
        private readonly string _connectionString;

        public SubjectSqlRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void InsertSubject(string subjectName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command
                    = new SqlCommand("INSERT INTO Subjects (SubjectText) VALUES (@SubjectText)", connection))
                {
                    command.Parameters.AddWithValue("@SubjectText", subjectName);
                    command.ExecuteScalar(); 
                }
            }
        }
    }
}
