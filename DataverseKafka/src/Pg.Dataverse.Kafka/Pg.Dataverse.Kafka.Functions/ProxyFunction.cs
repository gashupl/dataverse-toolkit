using Confluent.Kafka;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using System.Runtime.Serialization.Json;
using System.Text;

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
            string jsonContext = FormatJson(requestBody);

            //JObject data = JObject.Parse(requestBody);
            var remoteExecutionContext = DeserializeJsonString<RemoteExecutionContext>(jsonContext);

            string entityName = remoteExecutionContext.PrimaryEntityName;
            string operation = remoteExecutionContext.MessageName; 

            _logger.LogInformation($"Entity: {entityName?.ToString()}, Operation: {operation?.ToString()}");

            // Here you can add your logic to handle different entities and operations
            // For example, processing a create operation for a specific entity
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
            }

            return new OkObjectResult("OK!");

            //TODO: Check this method: https://www.inogic.com/blog/2018/06/parse-json-string-that-represents-the-dynamics-365-plugin-execution-context-received-in-azure-function/
        }

        public static string FormatJson(string unformattedJson)
        {
            string formattedJson = string.Empty;
            try
            {
                formattedJson = unformattedJson.Trim('"');
                formattedJson = System.Text.RegularExpressions.Regex.Unescape(formattedJson);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return formattedJson;
        }

        public static RemoteContextType DeserializeJsonString<RemoteContextType>(string jsonString)
        {
            //create an instance of generic type object
            var obj = Activator.CreateInstance<RemoteContextType>();
            var ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonString));
            var serializer = new DataContractJsonSerializer(obj.GetType());
            obj = (RemoteContextType)serializer.ReadObject(ms);
            ms.Close();
            return obj;
        }

    }
}
