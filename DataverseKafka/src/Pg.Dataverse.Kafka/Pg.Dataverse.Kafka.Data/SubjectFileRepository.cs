namespace Pg.Dataverse.Kafka.Data
{
    public class SubjectFileRepository : ISubjectRepository
    {
        private readonly string _filePath;

        public SubjectFileRepository(string filePath)
        {
            _filePath = filePath;
        }

        public void InsertSubject(string text)
        {
            // Append the text to the file, followed by a newline character
            File.AppendAllText(_filePath, text + Environment.NewLine);
        }
    }
}
