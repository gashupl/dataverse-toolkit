﻿using Pg.SolutionDownloaderCore.Model;
using System.Text.RegularExpressions;

namespace Pg.SolutionDownloaderCore.Data
{
    internal class InputArgumentReader
    {
        public const string UrlPrefix = "-url:";
        public const string AppIdPrefix = "-appid:";
        public const string ClientSecretPrefix = "-clientsecret:";
        public const string SolutionPrexix = "-solution:";
        public const string IsManagedPrefix = "-ismanaged:";
        public const string OutputDirPrefix = "-outputdir:";

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
                else if (formattedArg.StartsWith(SolutionPrexix))
                {
                    input.SolutionName = arg.Remove(0, SolutionPrexix.Length);
                }
                else if (formattedArg.StartsWith(IsManagedPrefix))
                {
                    var isManaged = false; 
                    var result = bool.TryParse(formattedArg.Remove(0, IsManagedPrefix.Length), out isManaged);
                    if (result)
                    {
                        input.IsManaged = isManaged;
                    }
                    else
                    {
                        throw new ArgumentException($"Invalid isManaged parameter value : { formattedArg }");
                    }
                }
                else if (formattedArg.StartsWith(OutputDirPrefix))
                {
                    input.OutputDir = arg.Remove(0, OutputDirPrefix.Length);
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
            else if (string.IsNullOrEmpty(input.SolutionName))
            {
                ThrowMissingParameterException(SolutionPrexix); 
            }
            return input;
        }

        private void ThrowMissingParameterException(string parameterName)
        {
			throw new ArgumentException($"Missing parameter: { parameterName }");
		}
    }
}
