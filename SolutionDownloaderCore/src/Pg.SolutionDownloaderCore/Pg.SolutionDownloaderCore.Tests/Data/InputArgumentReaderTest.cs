using Microsoft.Crm.Sdk.Messages;
using Pg.SolutionDownloaderCore.Data;
using Pg.SolutionDownloaderCore.Model;
using static System.Net.WebRequestMethods;

namespace Pg.SolutionDownloaderCore.Tests.Data
{
    public class InputArgumentReaderTest
    {
        [Fact]
        public void GetInput_ValidArgs_ReturnDto()
        {
            var expected = new InputDto()
            {
                DataverseUrl = "http:myinstance.crm4.dynamics.com",
                ApplicationId = "1234",
                ClientSecret = "09876543321",
                SolutionName = "MySolution",
                IsManaged = true,
                OutputDir = "."
            }; 

            string[] args = new string[6]; 
            args[0] = $"-url:http:{expected.DataverseUrl}";
            args[1] = $"-appId:{expected.ApplicationId}";
            args[2] = $"-clientSecret:{expected.ClientSecret}";
            args[3] = $"-solution:{expected.SolutionName}";
            args[4] = $"-isManaged:{expected.IsManaged}";
            args[5] = $"-outputDir:{expected.OutputDir}";

            var reader = new InputArgumentReader();
            var actual = reader.GetInput(args);

            Assert.Multiple(
                () => Assert.Equal(expected.DataverseUrl, actual.DataverseUrl),
                () => Assert.Equal(expected.ApplicationId, actual.ApplicationId),
                () => Assert.Equal(expected.ClientSecret, actual.ClientSecret),
                () => Assert.Equal(expected.SolutionName, actual.SolutionName),
                () => Assert.Equal(expected.IsManaged, actual.IsManaged),
                () => Assert.Equal(expected.OutputDir, actual.OutputDir)
            );
        }

        public void GetInput_ValidArgsWithoutDefaults_ReturnDto()
        {
            string[] args = new string[5];
            args[0] = "-url:http:myinstance.crm4.dynamics.com";
            args[1] = "-appId:";
            args[2] = "-clientSecret:";
            args[3] = "-solution:";

            throw new NotImplementedException();
        }

        [Fact]
        public void GetInput_InvalidArgsCount_ThrowException()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void GetInput_MisingDataverseUrl_ThrowException()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void GetInput_MisingApplicationId_ThrowException()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void GetInput_ClientSecret_ThrowException()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void GetInput_MisingSolutionName_ThrowException()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void GetInput_MisingIsManaged_UseDefaultValue()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void GetInput_MisingOutputDir_UseDefaultValue()
        {
            throw new NotImplementedException();
        }

    }
}
