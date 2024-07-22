using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Pg.Dataverse.Kafka.Functions
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;

        public Function1(ILogger<Function1> logger)
        {
            _logger = logger;
        }

        [Function("Function1")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("Received a webhook call from Dataverse.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            // Assuming the payload contains an entity name and operation
            string entityName = data?.entityName;
            string operation = data?.operation;

            _logger.LogInformation($"Entity: {entityName}, Operation: {operation}");

            // Here you can add your logic to handle different entities and operations
            // For example, processing a create operation for a specific entity
            if (entityName == "task" && operation == "create")
            {
                // Process the create operation for the contact entity
                _logger.LogInformation("Processing create operation for contact entity.");
            }

            return new OkResult();
        }


    }
}
