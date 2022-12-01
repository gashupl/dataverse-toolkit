using Pg.SolutionDownloaderCore.Model;
using System.Text.RegularExpressions;

namespace Pg.SolutionDownloaderCore.Data
{
    internal class InputArgumentReader : IInputArgumentReader
    {
        const string urlPrefix = "-url:";
        const string appIdPrefix = "-appid:";
        const string clientSecretPrefix = "-clientsecret:";
        const string solutionPrexix = "-solution:";
        const string isManagedPrefix = "-ismanaged:";
        const string outputDirPrefix = "-outputdir:";

        public InputDto GetInput(string[] args)
        {
            var output = new InputDto();
            foreach (var arg in args.Where(a => a != null))
            {
                var formattedArg = arg.ToLower(); 
                if (formattedArg.StartsWith(urlPrefix))
                {
                    output.DataverseUrl = arg.Remove(0, urlPrefix.Length); 
                }
                else if (formattedArg.StartsWith(appIdPrefix))
                {
                    output.ApplicationId = arg.Remove(0, appIdPrefix.Length);
                }
                else if (formattedArg.StartsWith(clientSecretPrefix))
                {
                    output.ClientSecret = arg.Remove(0, clientSecretPrefix.Length);
                }
                else if (formattedArg.StartsWith(solutionPrexix))
                {
                    output.SolutionName = arg.Remove(0, solutionPrexix.Length);
                }
                else if (formattedArg.StartsWith(isManagedPrefix))
                {
                    var isManaged = false; 
                    var result = bool.TryParse(formattedArg.Remove(0, isManagedPrefix.Length), out isManaged);
                    if (result)
                    {
                        output.IsManaged = isManaged;
                    }
                    else
                    {
                        throw new ArgumentException($"Invalid isManaged parameter value : { formattedArg }");
                    }
                }
                else if (formattedArg.StartsWith(outputDirPrefix))
                {
                    output.OutputDir = arg.Remove(0, outputDirPrefix.Length);
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Invalid parameter: {arg}"); 
                }
            }

            if (string.IsNullOrEmpty(output.DataverseUrl))
            {
				ThrowMissingParameterException(urlPrefix);
            }
            else if (string.IsNullOrEmpty(output.ApplicationId))
            {
				ThrowMissingParameterException(appIdPrefix);
            }
            else if (string.IsNullOrEmpty(output.ClientSecret))
            {
				ThrowMissingParameterException(clientSecretPrefix);
            }
            else if (string.IsNullOrEmpty(output.SolutionName))
            {
                ThrowMissingParameterException(solutionPrexix); 
            }
            return output;
        }

        private void ThrowMissingParameterException(string parameterName)
        {
			throw new ArgumentException($"Missing parameter: { parameterName }");
		}
    }
}
