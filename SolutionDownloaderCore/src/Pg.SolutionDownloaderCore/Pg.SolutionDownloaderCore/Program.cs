using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using Pg.SolutionDownloaderCore.Data;
using Pg.SolutionDownloaderCore.Services;
using Microsoft.PowerPlatform.Dataverse.Client;
using Pg.SolutionDownloaderCore.Model;

namespace Pg.SolutionDownloaderCore;

public class Program
{
	public static void Main(string[] args)
	{
        InputDto input; 
		try
		{
			var argsReader = new InputArgumentReader();
            input = argsReader.GetInput(args);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
			return; 
        }

        var connectionString = @$"Url={input.DataverseUrl};AuthType=ClientSecret;"
				+ $"ClientId={input.ApplicationId};ClientSecret={input.ClientSecret};RequireNewInstance=true";

		var serviceProvider = new ServiceCollection()
			.AddLogging(opt => opt.AddConsole().SetMinimumLevel(LogLevel.Trace))
			.AddSingleton<IOrganizationService>(new ServiceClient(connectionString))
			.AddSingleton<ISolutionRepository, DataverseRepository>()
			.AddSingleton<IFile, FileWrapper>()
			.AddSingleton<ISolutionService, SolutionService>()
			.BuildServiceProvider();

		var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
		if (loggerFactory != null)
		{

            ILogger logger = loggerFactory.CreateLogger<Program>();
			try
			{
                logger.LogTrace("Starting application");

				var solutionDownloader = serviceProvider.GetService<ISolutionService>();
				solutionDownloader?.DownloadSolution(input.OutputDir, input.SolutionName, input.IsManaged);

				logger.LogTrace("Closing application");
			}
			catch (Exception ex)
			{
				logger.LogError(ex, "Unhandled exception occured.");
            }
		}

	}
}