﻿using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Tooling.Connector;
using Pg.DataverseTags.Plugins.StepsRegistrator.Data;
using Pg.DataverseTags.Shared.Common;
using Pg.DataverseTags.Shared.Model;
using Pg.SolutionDownloaderCore.Data;
using Pg.SolutionDownloaderCore.Model;
using System;
using System.ServiceModel.Security;

namespace Pg.DataverseTags.Plugins.StepsRegistrator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var argsReader = new InputArgumentReader();
            ILogger logger;
            InputDto input;
            try
            {
                input = argsReader.GetInput(args);

                var connectionString = $"Url={input.DataverseUrl};AuthType=ClientSecret;"
                    + $"ClientId={input.ApplicationId};ClientSecret={input.ClientSecret};RequireNewInstance=true";

                var client = new CrmServiceClient(connectionString);
                var loggerFactory = new LoggerFactory();

                var repo = new DataverseRepository(client, loggerFactory);
                var plugin = repo.GetPluginType("Pg.DataverseTags.Plugins", 
                    "Pg.DataverseTags.Plugins.ValidateTagPlugin");
                var createFilter = repo.GetMessageFilter(pg_tag.EntityLogicalName, Messages.Create);
                var updateFilter = repo.GetMessageFilter(pg_tag.EntityLogicalName, Messages.Update);
                var createMessage = repo.GetMessage(Messages.Create);
                var updateMessage = repo.GetMessage(Messages.Update); 
                repo.CreateStep(plugin.Id, createFilter.Id, createMessage.Id, Messages.Create);
                repo.CreateStep(plugin.Id, updateFilter.Id, updateMessage.Id, Messages.Update); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Required parameters:");
                Console.WriteLine($"{InputArgumentReader.UrlPrefix}value");
                Console.WriteLine($"{InputArgumentReader.AppIdPrefix}value");
                Console.WriteLine($"{InputArgumentReader.ClientSecretPrefix}value");
                Console.WriteLine($"Optional parameters:");
                Console.WriteLine($"{InputArgumentReader.ConfigurationPrefix}value");
            }
        }
    }
}
