using Microsoft.Extensions.Configuration;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
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
var tasksNumber = configuration["app-settings:tasks-number"];

var connectionString = @$"Url={baseUrl};AuthType=ClientSecret;"
        + $"ClientId={clientId};ClientSecret={clientSecret};RequireNewInstance=true"; 

if(Int32.TryParse(connectionString, out int tasksCount))
{
    var repo = new TaskRepository(connectionString);

    var subjects = new List<string>();
    for (int i = 0; i < tasksCount; i++)
    {
        subjects.Add(StringRandomizer.Generate(20));
    }

    repo.CreateMultiple(subjects, 100);

}
