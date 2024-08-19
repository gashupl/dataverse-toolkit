namespace Pg.Dataverse.Kafka.Data
{
    public class SubjectFileRepository
    {
        private readonly string _filePath;

        public SubjectFileRepository(string filePath)
        {
            _filePath = filePath;
        }

        public void AddLine(string text)
        {
            // Append the text to the file, followed by a newline character
            File.AppendAllText(_filePath, text + Environment.NewLine);
        }
    }
}
