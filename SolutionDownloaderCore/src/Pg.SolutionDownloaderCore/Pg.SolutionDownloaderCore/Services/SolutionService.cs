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
            _logger.LogInformation("Getting solution ready...");
            var response = _repository.Get(name, isManaged); 
            if(response != null) 
            {
                _logger.LogInformation("Solution exported. Saving to file...");
                byte[] exportXml = response.ExportSolutionFile;
                string filename = name + ".zip";
                _file.WriteAllBytes(outputDir + filename, exportXml);
                _logger.LogInformation("Solution file successfully saved");
            }
        }
    }
}
