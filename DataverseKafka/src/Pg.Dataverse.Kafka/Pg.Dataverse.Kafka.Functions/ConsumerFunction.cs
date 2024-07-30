using Confluent.Kafka;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Pg.Dataverse.Kafka.Functions
{
    public class ConsumerFunction
    {
        private const string _topic = "dataverse-task-topic";
        private readonly IConsumer<String, String> _consumer;
        private readonly ILogger _logger;

        public ConsumerFunction(IConsumer<String, String> consumer, ILoggerFactory loggerFactory)
        {
            _consumer = consumer;
            _logger = loggerFactory.CreateLogger<ConsumerFunction>();
        }

        [Function("ConsumerFunction")]
        public void Run([TimerTrigger("0 * * * * *", RunOnStartup = true)] TimerInfo myTimer)
        {
            _logger.LogInformation($"C# Timer trigger consumer function executed at: {DateTime.Now}");

            _consumer.Subscribe(_topic);
            while (true)
            {
                var result = _consumer.Consume();
                _logger.LogInformation($"Result: {result.Message.Value} ");
                Thread.Sleep(1000);
            }
        }
    }
}
