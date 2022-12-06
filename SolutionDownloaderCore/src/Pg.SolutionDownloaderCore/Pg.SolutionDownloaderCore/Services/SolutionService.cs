using Microsoft.Extensions.Logging;
using Pg.SolutionDownloaderCore.Data;


namespace Pg.SolutionDownloaderCore.Services
{
    public class SolutionService : ISolutionService
    {
        private readonly ISolutionRepository _repository;
        private readonly IFile _file; 
        private readonly ILogger<SolutionService> _logger; 
        public SolutionService(ISolutionRepository repository, IFile file, ILoggerFactory loggerFactory)
        {
            _repository = repository;
            _file = file;
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
                _file.WriteAllBytes(outputDir + filename, exportXml);
            }
        }
    }
}
