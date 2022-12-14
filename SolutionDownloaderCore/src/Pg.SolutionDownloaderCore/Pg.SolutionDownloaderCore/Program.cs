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
		var argsReader = new InputArgumentReader();
		ILogger logger;
		InputDto input; 
		try
		{
            input = argsReader.GetInput(args);
        }
		catch(Exception ex)
		{
            Console.WriteLine(ex.Message);
			Console.WriteLine($"Required parameters:");
            Console.WriteLine($"{InputArgumentReader.UrlPrefix}value");
            Console.WriteLine($"{InputArgumentReader.AppIdPrefix}value");
            Console.WriteLine($"{InputArgumentReader.ClientSecretPrefix}value");
            Console.WriteLine($"{InputArgumentReader.SolutionPrexix}value");
            Console.WriteLine($"Optional parameters:");
            Console.WriteLine($"{InputArgumentReader.IsManagedPrefix}value");
            Console.WriteLine($"{InputArgumentReader.OutputDirPrefix}value");
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
			logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("Starting application");

            var solutionDownloader = serviceProvider.GetService<ISolutionService>();
            solutionDownloader?.DownloadSolution(input.OutputDir, input.SolutionName, input.IsManaged);

            logger.LogInformation("Closing application");
        }
	}
}