using Microsoft.Extensions.Logging;
using Pg.SolutionDownloaderCore.Data;


namespace Pg.SolutionDownloaderCore.Services
{
    public class SolutionService : ISolutionService
    {
        private readonly ISolutionRepository _repository;
        private readonly ILogger<SolutionService> _logger; 
        public SolutionService(ISolutionRepository repository, ILoggerFactory loggerFactory)
        {
            _repository = repository;
            _logger = loggerFactory.CreateLogger<SolutionService>();
        }

        public void DownloadSolution(string outputDir, string name, bool isManaged)
        {
            _logger.LogTrace("Getting solution ready...");
            var response = _repository.Get(name, isManaged); 
            if(response != null) 
            {
                byte[] exportXml = response.ExportSolutionFile;
                string filename = name + ".zip";
                File.WriteAllBytes(outputDir + filename, exportXml);
            }
        }
    }
}
