using Confluent.Kafka;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Pg.Dataverse.Kafka.Data;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices((context, services) =>
    {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();

        services.Configure<ProducerConfig>(context.Configuration.GetSection("Kafka"));
        services.AddSingleton<IProducer<String, String>>(sp =>
        {
            var config = sp.GetRequiredService<IOptions<ProducerConfig>>();

            return new ProducerBuilder<String, String>(config.Value)
                .Build();
        });

        services.Configure<ConsumerConfig>(context.Configuration.GetSection("Kafka"));
        services.AddSingleton<IConsumer<String, String>>(sp =>
        {
            var config = sp.GetRequiredService<IOptions<ConsumerConfig>>();

            return new ConsumerBuilder<String, String>(config.Value)
                .Build();
        });

        services.AddSingleton<ISubjectRepository>(sp =>
        {
            var connectionString = Environment.GetEnvironmentVariable("SqlConnectionString");
            if (connectionString != null)
            {
                return new SubjectSqlRepository(connectionString);
            }
            else
            {
                throw new InvalidOperationException("SqlConnectionString is not set");
            }
        });

    })
    .Build();

host.Run();
