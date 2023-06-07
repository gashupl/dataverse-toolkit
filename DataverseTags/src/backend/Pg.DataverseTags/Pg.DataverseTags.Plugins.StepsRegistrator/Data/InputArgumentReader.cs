using Pg.SolutionDownloaderCore.Model;
using System;
using System.Linq;
namespace Pg.DataverseTags.Plugins.StepsRegistrator.Data
{
    internal class InputArgumentReader
    {
        public const string UrlPrefix = "-url:";
        public const string AppIdPrefix = "-appid:";
        public const string ClientSecretPrefix = "-clientsecret:";
        public const string ConfigurationPrefix = "-config:";


        public InputDto GetInput(string[] args)
        {
            var input = new InputDto();
            foreach (var arg in args.Where(a => a != null))
            {
                var formattedArg = arg.ToLower(); 
                if (formattedArg.StartsWith(UrlPrefix))
                {
                    input.DataverseUrl = arg.Remove(0, UrlPrefix.Length); 
                }
                else if (formattedArg.StartsWith(AppIdPrefix))
                {
                    input.ApplicationId = arg.Remove(0, AppIdPrefix.Length);
                }
                else if (formattedArg.StartsWith(ClientSecretPrefix))
                {
                    input.ClientSecret = arg.Remove(0, ClientSecretPrefix.Length);
                }
                else if (formattedArg.StartsWith(ConfigurationPrefix))
                {
                    input.Configuration = arg.Remove(0, ConfigurationPrefix.Length);
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Invalid parameter: {arg}"); 
                }
            }

            if (string.IsNullOrEmpty(input.DataverseUrl))
            {
				ThrowMissingParameterException(UrlPrefix);
            }
            else if (string.IsNullOrEmpty(input.ApplicationId))
            {
				ThrowMissingParameterException(AppIdPrefix);
            }
            else if (string.IsNullOrEmpty(input.ClientSecret))
            {
				ThrowMissingParameterException(ClientSecretPrefix);
            }
            return input;
        }

        private void ThrowMissingParameterException(string parameterName)
        {
			throw new ArgumentException($"Missing parameter: { parameterName }");
		}
    }
}
