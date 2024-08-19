using System.Data.SqlClient;

namespace Pg.Dataverse.Kafka.Data
{
    public class SubjectSqlRepository
    {
        private readonly string _connectionString;

        public SubjectSqlRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int InsertSubject(string subjectName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command
                    = new SqlCommand("INSERT INTO Subjects (SubjectText) OUTPUT INSERTED.Id VALUES (@SubjectText)", connection))
                {
                    command.Parameters.AddWithValue("@SubjectText", subjectName);

                    // Execute the command and get the inserted ID
                    int insertedId = (int)command.ExecuteScalar();
                    return insertedId;

                }
            }
        }
    }
}
