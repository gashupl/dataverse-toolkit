using Confluent.Kafka;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using Pg.Dataverse.Kafka.Functions.Utilities;

namespace Pg.Dataverse.Kafka.Functions
{
    public class ProxyFunction
    {
        private readonly ILogger<ProxyFunction> _logger;

        public ProxyFunction(ILogger<ProxyFunction> logger)
        {
            _logger = logger;
        }

        [Function("ProxyFunction")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("Received a webhook call from Dataverse.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            string jsonContext = JsonHelper.FormatJson(requestBody);

            var remoteExecutionContext = JsonHelper.DeserializeJsonString<RemoteExecutionContext>(jsonContext);

            if(remoteExecutionContext != null)
            {
                string entityName = remoteExecutionContext.PrimaryEntityName;
                string operation = remoteExecutionContext.MessageName;

                _logger.LogInformation($"Entity: {entityName?.ToString()}, Operation: {operation?.ToString()}");

                if (entityName == "task" && operation == "Create")
                {
                    Entity target = (Entity)remoteExecutionContext.InputParameters["Target"];
                    var task = target.ToEntity<Model.Task>();
                    // Process the create operation for the contact entity
                    _logger.LogInformation("Processing create operation for contact entity.");

                    var config = new ProducerConfig
                    {
                        BootstrapServers = "host1:9092",
                    };

                    //using (var producer = new ProducerBuilder<Null, string>(config).Build())
                    //{
                    //    //...
                    //}
                    return new OkObjectResult(task.Subject);
                }
            }

            return new ObjectResult("An internal error occurred.")
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }
    }
}
