using Microsoft.Extensions.Configuration;
using Pg.Dataverse.Kafka.Data;

Console.WriteLine("Hello, World!");

var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables()
    .AddCommandLine(args)
    .Build();

var baseUrl = Environment.GetEnvironmentVariable("app-settings:crm-base-url");
var clientId = Environment.GetEnvironmentVariable("app-settings:crm-application-id");
var clientSecret = Environment.GetEnvironmentVariable("app-settings:crm-client-secret"); 

var connectionString = @$"Url={baseUrl};AuthType=ClientSecret;"
        + $"ClientId={clientId};ClientSecret={clientSecret};RequireNewInstance=true"; 

var repo = new TaskRepository(connectionString);
repo.Create("Hello from command line!"); 