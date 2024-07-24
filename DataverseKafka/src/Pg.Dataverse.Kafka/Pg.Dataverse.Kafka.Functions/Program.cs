using Confluent.Kafka;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

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
    })
    .Build();

host.Run();
