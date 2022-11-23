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
            .AddSingleton<ISolutionRepository, DataverseRepository>()
            .AddSingleton<ISolutionService, SolutionService>()    
            .BuildServiceProvider();

        var loggerFactory = serviceProvider.GetService<ILoggerFactory>(); 
        if(loggerFactory != null)
        {
            var logger = loggerFactory.CreateLogger<Program>();
            logger.LogTrace("Starting application");

            var solutionDownloader = serviceProvider.GetService<ISolutionService>();
            solutionDownloader?.Get();

            logger.LogTrace("Closing application");
        }

    }
}
