using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg.SolutionDownloaderCore.Services
{
    internal interface ISolutionService
    {
        void DownloadSolution(string outputDir, string name, bool isManaged); 
    }
}
