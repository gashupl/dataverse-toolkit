using Pg.SolutionDownloaderCore.Model;
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
            var output = new InputDto();
            foreach (var arg in args.Where(a => a != null))
            {
                var formattedArg = arg.ToLower(); 
                if (formattedArg.StartsWith(UrlPrefix))
                {
                    output.DataverseUrl = arg.Remove(0, UrlPrefix.Length); 
                }
                else if (formattedArg.StartsWith(AppIdPrefix))
                {
                    output.ApplicationId = arg.Remove(0, AppIdPrefix.Length);
                }
                else if (formattedArg.StartsWith(ClientSecretPrefix))
                {
                    output.ClientSecret = arg.Remove(0, ClientSecretPrefix.Length);
                }
                else if (formattedArg.StartsWith(SolutionPrexix))
                {
                    output.SolutionName = arg.Remove(0, SolutionPrexix.Length);
                }
                else if (formattedArg.StartsWith(IsManagedPrefix))
                {
                    var isManaged = false; 
                    var result = bool.TryParse(formattedArg.Remove(0, IsManagedPrefix.Length), out isManaged);
                    if (result)
                    {
                        output.IsManaged = isManaged;
                    }
                    else
                    {
                        throw new ArgumentException($"Invalid isManaged parameter value : { formattedArg }");
                    }
                }
                else if (formattedArg.StartsWith(OutputDirPrefix))
                {
                    output.OutputDir = arg.Remove(0, OutputDirPrefix.Length);
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Invalid parameter: {arg}"); 
                }
            }

            if (string.IsNullOrEmpty(output.DataverseUrl))
            {
				ThrowMissingParameterException(UrlPrefix);
            }
            else if (string.IsNullOrEmpty(output.ApplicationId))
            {
				ThrowMissingParameterException(AppIdPrefix);
            }
            else if (string.IsNullOrEmpty(output.ClientSecret))
            {
				ThrowMissingParameterException(ClientSecretPrefix);
            }
            else if (string.IsNullOrEmpty(output.SolutionName))
            {
                ThrowMissingParameterException(SolutionPrexix); 
            }
            return output;
        }

        private void ThrowMissingParameterException(string parameterName)
        {
			throw new ArgumentException($"Missing parameter: { parameterName }");
		}
    }
}
