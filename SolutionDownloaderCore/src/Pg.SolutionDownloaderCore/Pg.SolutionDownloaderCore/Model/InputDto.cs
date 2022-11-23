namespace Pg.SolutionDownloaderCore.Model
{
    public class InputDto
    {
        public string DataverseUrl { get; set; }
        public string ApplicationId { get; set; }
        public string ClientSecret { get; set; }
        public string SolutionName { get; set; }
        public bool IsManaged { get; set; }
        public string OutputDir { get; set; }
    }
}
