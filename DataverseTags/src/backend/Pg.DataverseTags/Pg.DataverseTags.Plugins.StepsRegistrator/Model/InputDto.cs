namespace Pg.SolutionDownloaderCore.Model
{
    public class InputDto
    {
        public string DataverseUrl { get; set; }
        public string ApplicationId { get; set; }
        public string ClientSecret { get; set; }
        public string Configuration { get; set; } = "plugins-config.json"; 
    }
}
