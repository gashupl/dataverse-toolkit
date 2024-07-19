using Confluent.Kafka;
using Microsoft.Xrm.Sdk;
using Pg.Dataverse.Kafka.Plugin.Model;
using System;

namespace Pg.Dataverse.Kafka.Plugin
{
    public class TaskPlugin : PluginBase
    {
        public TaskPlugin(string unsecureConfiguration, string secureConfiguration)
            : base(typeof(TaskPlugin))
        {
            // TODO: Implement your custom configuration handling
            // https://docs.microsoft.com/powerapps/developer/common-data-service/register-plug-in#set-configuration-data
        }

        // Entry point for custom business logic execution
        protected override void ExecuteDataversePlugin(ILocalPluginContext localPluginContext)
        {
            if (localPluginContext == null)
            {
                throw new ArgumentNullException(nameof(localPluginContext));
            }

            var context = localPluginContext.PluginExecutionContext;

            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                var entity = (Entity)context.InputParameters["Target"];

                // Check for entity name on which this plugin would be registered
                if (entity.LogicalName == Task.EntityLogicalName)
                { 
                    var config = new ProducerConfig
                    {
                        BootstrapServers = "host1:9092",
                    };

                    new InvalidPluginExecutionException("Yes, it is working!"); 
                    //using (var producer = new ProducerBuilder<Null, string>(config).Build())
                    //{
                    //    //...
                    //}
                }
            }
        }
    }
}
