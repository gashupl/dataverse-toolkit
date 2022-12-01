using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;

namespace Pg.SolutionDownloaderCore.Data
{
    public class DataverseRepository : ISolutionRepository
    {
        private readonly IOrganizationService _service; 

        public DataverseRepository(IOrganizationService service)
        {
            _service = service;
        }
        public ExportSolutionResponse Get(string name, bool isManaged)
        {
            var exportSolutionRequest = new ExportSolutionRequest();
            exportSolutionRequest.Managed = isManaged;
            exportSolutionRequest.SolutionName = name;

            return (ExportSolutionResponse)_service.Execute(exportSolutionRequest);
        }
    }
}
