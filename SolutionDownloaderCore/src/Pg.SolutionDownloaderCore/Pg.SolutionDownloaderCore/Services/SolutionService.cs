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
            try
            {
				var response = _repository.Get(name, isManaged);
				if (response != null)
				{
					_logger.LogTrace("Solution exported");
					byte[] exportXml = response.ExportSolutionFile;
					string filename = name + ".zip";
					_file.WriteAllBytes(outputDir + filename, exportXml);
					_logger.LogTrace("Solution saved to disk");
				}
			}
            catch (DataverseCallException ex) 
            {
				//TODO: Add error handling
			}
			catch (Exception ex)
            {
                //TODO: Add error handling
            }
        }
    }
}
