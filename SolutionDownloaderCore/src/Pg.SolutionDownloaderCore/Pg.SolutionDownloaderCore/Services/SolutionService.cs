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
            try
            {
				var response = _repository.Get(name, isManaged);
				if (response != null)
				{
                    _logger.LogInformation("Solution exported");
					byte[] exportXml = response.ExportSolutionFile;
					string filename = name + ".zip";
					_file.WriteAllBytes(outputDir + filename, exportXml);
                    _logger.LogInformation("Solution saved to disk");
				}
			}
            catch (DataverseCallException ex) 
            {
                _logger.LogInformation("Error when connecting to Dataverse");
                _logger.LogInformation(ex.Message);
            }
			catch (Exception ex)
            {
                _logger.LogInformation("The application terminated with an error.");
                _logger.LogInformation(ex.Message);

                if (ex.InnerException != null)
                {
                    _logger.LogInformation(ex.InnerException.Message);    
                }
            }
        }
    }
}
