using Microsoft.Extensions.Configuration;
using Pg.Dataverse.Kafka.Data;

Console.WriteLine("Application started");

var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables()
    .AddCommandLine(args)
    .Build();

var baseUrl = configuration["app-settings:crm-base-url"];
var clientId = configuration["app-settings:crm-application-id"];
var clientSecret = configuration["app-settings:crm-client-secret"];
var tasksNumberConfig = configuration["app-settings:tasks-number"];
var maxDegreeOfParallelismConfig = configuration["app-settings:max-parallelism-degree"];


var connectionString = @$"Url={baseUrl};AuthType=ClientSecret;"
        + $"ClientId={clientId};ClientSecret={clientSecret};RequireNewInstance=true"; 

if(Int32.TryParse(tasksNumberConfig, out int tasksCount) 
    && Int32.TryParse(maxDegreeOfParallelismConfig, out int maxDegreeOfParallelism))
{
    var repo = new TaskRepository(connectionString);

    var subjects = new List<string>();
    for (int i = 0; i < tasksCount; i++)
    {
        subjects.Add($"{i}: {StringRandomizer.Generate(20)}");
    }

    repo.CreateMultiple(subjects, maxDegreeOfParallelism, tasksCount);

}
else
{
    Console.WriteLine("Invalid tasks number");
}
