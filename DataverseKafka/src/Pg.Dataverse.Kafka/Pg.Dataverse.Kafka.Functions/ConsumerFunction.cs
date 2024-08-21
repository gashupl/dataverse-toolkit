using Confluent.Kafka;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Pg.Dataverse.Kafka.Data;

namespace Pg.Dataverse.Kafka.Functions
{
    public class ConsumerFunction
    {
        private const string _topic = "dataverse-task-topic";
        private readonly ISubjectRepository _subjectsRepository;
        private readonly IConsumer<String, String> _consumer;
        private readonly ILogger _logger;

        public ConsumerFunction
            (IConsumer<String, String> consumer, ISubjectRepository subjectsRepository, ILoggerFactory loggerFactory)
        {
            _consumer = consumer;
            _subjectsRepository = subjectsRepository;
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
                var subject = result.Message.Value; 

                _subjectsRepository.InsertSubject(subject);
                _logger.LogInformation($"Saved subject: {subject} ");

                Thread.Sleep(1000);
            }
        }
    }
}
