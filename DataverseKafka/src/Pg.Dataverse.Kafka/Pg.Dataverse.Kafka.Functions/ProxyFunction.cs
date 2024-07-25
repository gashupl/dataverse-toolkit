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
        private const string _topic = "dataverse-task-topic";
        private readonly IProducer<String, String> _producer;
        private readonly ILogger<ProxyFunction> _logger;

        public ProxyFunction(IProducer<String, String> producer, ILogger<ProxyFunction> logger)
        {
            _producer = producer;
            _logger = logger;
        }

        [Function("ProxyFunction")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            try
            {
                _logger.LogInformation("Received a webhook call from Dataverse.");

                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                string jsonContext = JsonHelper.FormatJson(requestBody);

                var remoteExecutionContext = JsonHelper.DeserializeJsonString<RemoteExecutionContext>(jsonContext);

                if (remoteExecutionContext != null)
                {
                    string entityName = remoteExecutionContext.PrimaryEntityName;
                    string operation = remoteExecutionContext.MessageName;

                    _logger.LogInformation($"Entity: {entityName?.ToString()}, Operation: {operation?.ToString()}");

                    if (entityName == "task" && operation == "Create")
                    {
                        Entity target = (Entity)remoteExecutionContext.InputParameters["Target"];
                        var task = target.ToEntity<Model.Task>();

                        var result = await _producer.ProduceAsync(_topic, new Message<String, String>
                        {
                            Value = task.Subject
                        });

                        _producer.Flush();

                        return new OkObjectResult(result);
                    }
                }

                return new ObjectResult("An internal error occurred.")
                {
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred.");

                return new ObjectResult("An internal error occurred.")
                {
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }

        }
    }
}
