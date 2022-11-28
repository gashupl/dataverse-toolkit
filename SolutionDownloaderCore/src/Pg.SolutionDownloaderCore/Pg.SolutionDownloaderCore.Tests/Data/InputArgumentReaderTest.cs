using Microsoft.Crm.Sdk.Messages;
using Pg.SolutionDownloaderCore.Data;
using Pg.SolutionDownloaderCore.Model;
using Xunit;
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

        [Fact]
        public void GetInput_ValidArgsWithoutDefaults_ReturnDto()
        {
            var expected = new InputDto()
            {
                DataverseUrl = "http:myinstance.crm4.dynamics.com",
                ApplicationId = "1234",
                ClientSecret = "09876543321",
                SolutionName = "MySolution",
                IsManaged = false,
                OutputDir = "."
            };

            string[] args = new string[4];
            args[0] = $"-url:http:{expected.DataverseUrl}";
            args[1] = $"-appId:{expected.ApplicationId}";
            args[2] = $"-clientSecret:{expected.ClientSecret}";
            args[3] = $"-solution:{expected.SolutionName}";

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

        [Fact]
        public void GetInput_MisingDataverseUrl_ThrowException()
        {
            var expected = new InputDto()
            {
                DataverseUrl = "http:myinstance.crm4.dynamics.com",
                ApplicationId = "1234",
                ClientSecret = "09876543321",
                SolutionName = "MySolution",
                IsManaged = false,
                OutputDir = "."
            };

            string[] args = new string[3];
            args[0] = $"-appId:{expected.ApplicationId}";
            args[1] = $"-clientSecret:{expected.ClientSecret}";
            args[2] = $"-solution:{expected.SolutionName}";

            var reader = new InputArgumentReader();

            Assert.Throws<ArgumentException>(() => reader.GetInput(args)); 
        }

        [Fact]
        public void GetInput_MisingApplicationId_ThrowException()
        {
            var expected = new InputDto()
            {
                DataverseUrl = "http:myinstance.crm4.dynamics.com",
                ApplicationId = "1234",
                ClientSecret = "09876543321",
                SolutionName = "MySolution",
                IsManaged = false,
                OutputDir = "."
            };

            string[] args = new string[4];
            args[0] = $"-url:http:{expected.DataverseUrl}";
            args[1] = $"-appId:{expected.ApplicationId}";
            args[2] = $"-clientSecret:{expected.ClientSecret}";
            args[3] = $"-solution:{expected.SolutionName}";

            var reader = new InputArgumentReader();
            
            Assert.Throws<ArgumentException>(() => reader.GetInput(args)); 
        }

        [Fact]
        public void GetInput_ClientSecret_ThrowException()
        {
            var expected = new InputDto()
            {
                DataverseUrl = "http:myinstance.crm4.dynamics.com",
                ApplicationId = "1234",
                ClientSecret = "09876543321",
                SolutionName = "MySolution",
                IsManaged = false,
                OutputDir = "."
            };

            string[] args = new string[4];
            args[0] = $"-url:http:{expected.DataverseUrl}";
            args[1] = $"-appId:{expected.ApplicationId}";
            args[2] = $"-solution:{expected.SolutionName}";

            var reader = new InputArgumentReader();

            Assert.Throws<ArgumentException>(() => reader.GetInput(args));
        }

        [Fact]
        public void GetInput_MisingSolutionName_ThrowException()
        {
            var expected = new InputDto()
            {
                DataverseUrl = "http:myinstance.crm4.dynamics.com",
                ApplicationId = "1234",
                ClientSecret = "09876543321",
                SolutionName = "MySolution",
                IsManaged = false,
                OutputDir = "."
            };

            string[] args = new string[4];
            args[0] = $"-url:http:{expected.DataverseUrl}";
            args[1] = $"-appId:{expected.ApplicationId}";
            args[2] = $"-clientSecret:{expected.ClientSecret}";

            var reader = new InputArgumentReader();

            Assert.Throws<ArgumentException>(() => reader.GetInput(args));
        }

        [Fact]
        public void GetInput_InvalidParameter_ThrowException()
        {
            var expected = new InputDto()
            {
                DataverseUrl = "http:myinstance.crm4.dynamics.com",
                ApplicationId = "1234",
                ClientSecret = "09876543321",
                SolutionName = "MySolution",
                IsManaged = false,
                OutputDir = "."
            };

            string[] args = new string[5];
            args[0] = $"-url:http:{expected.DataverseUrl}";
            args[1] = $"-appId:{expected.ApplicationId}";
            args[2] = $"-clientSecret:{expected.ClientSecret}";
            args[3] = $"-solution:{expected.SolutionName}";
            args[4] = $"-invalidParam:InvalidValue";

            var reader = new InputArgumentReader();

            Assert.Throws<ArgumentException>(() => reader.GetInput(args));
        }
    }
}
