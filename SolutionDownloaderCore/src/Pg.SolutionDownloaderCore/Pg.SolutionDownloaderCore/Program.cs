using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Pg.SolutionDownloaderCore.Data;
using Pg.SolutionDownloaderCore.Services;

namespace Pg.SolutionDownloaderCore; 

public class Program
{
    public static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddLogging(opt => opt.AddConsole().SetMinimumLevel(LogLevel.Trace))
            .AddSingleton<IInputArgumentReader, InputArgumentReader>()
            .AddSingleton<ISolutionRepository, DataverseRepository>()
            .AddSingleton<ISolutionService, SolutionService>()    
            .BuildServiceProvider();

        var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
        var argsReader = serviceProvider.GetService<IInputArgumentReader>();
        if (loggerFactory != null && argsReader != null)
        {
            var logger = loggerFactory.CreateLogger<Program>();
            logger.LogTrace("Starting application");

            var input = argsReader.GetInput(args); 

            var solutionDownloader = serviceProvider.GetService<ISolutionService>();
            solutionDownloader?.DownloadSolution(input.OutputDir, input.SolutionName, input.IsManaged); 

            logger.LogTrace("Closing application");
        }

    }
}
