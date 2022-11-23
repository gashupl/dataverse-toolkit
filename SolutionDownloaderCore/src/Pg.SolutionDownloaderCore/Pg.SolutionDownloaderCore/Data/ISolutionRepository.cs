using Microsoft.Crm.Sdk.Messages;

namespace Pg.SolutionDownloaderCore.Data
{
    public interface ISolutionRepository
    {
        ExportSolutionResponse Get(string name, bool isManaged); 
    }
}
