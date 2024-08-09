using Microsoft.Extensions.Configuration;
using Pg.Dataverse.Kafka.Data;

Console.WriteLine("Hello, World!");

var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables()
    .AddCommandLine(args)
    .Build();

var baseUrl = configuration["app-settings:crm-base-url"];
var clientId = configuration["app-settings:crm-application-id"];
var clientSecret = configuration["app-settings:crm-client-secret"]; 

var connectionString = @$"Url={baseUrl};AuthType=ClientSecret;"
        + $"ClientId={clientId};ClientSecret={clientSecret};RequireNewInstance=true"; 

var repo = new TaskRepository(connectionString);
repo.Create(StringRandomizer.Generate(20));

//TODO: Implement multithreaded task creation, sample code: https://markcarrington.dev/2020/12/04/improving-insert-update-delete-performance-in-d365-dataverse/