using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

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
            JObject data = JObject.Parse(requestBody);

            // Assuming the payload contains an entity name and operation
            JToken? entityName = data?["PrimaryEntityName"];
            JToken? operation = data?["MessageName"];

            _logger.LogInformation($"Entity: {entityName?.ToString()}, Operation: {operation?.ToString()}");

            // Here you can add your logic to handle different entities and operations
            // For example, processing a create operation for a specific entity
            if (entityName.ToString() == "task" && operation.ToString() == "Create")
            {
                // Process the create operation for the contact entity
                _logger.LogInformation("Processing create operation for contact entity.");
            }

            return new OkObjectResult("OK!");
        }


    }
}
