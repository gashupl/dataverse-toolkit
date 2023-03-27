﻿using Microsoft.Extensions.Logging;
using Pg.SolutionDownloaderCore.Data;
using Pg.SolutionDownloaderCore.Model;
using System;

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
                return;
            }

            var connectionString = @"Url={input.DataverseUrl};AuthType=ClientSecret;"
                    + $"ClientId={input.ApplicationId};ClientSecret={input.ClientSecret};RequireNewInstance=true";

        }
    }
}
