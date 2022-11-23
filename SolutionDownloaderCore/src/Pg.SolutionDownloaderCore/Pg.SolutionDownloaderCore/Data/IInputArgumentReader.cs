using Pg.SolutionDownloaderCore.Model;

namespace Pg.SolutionDownloaderCore.Data
{
    internal interface IInputArgumentReader
    {
        InputDto GetInput(string[] args); 
    }
}
