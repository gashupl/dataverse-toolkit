using Moq;
using Pg.SolutionDownloaderCore.Data;
using Pg.SolutionDownloaderCore.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Extensions.DependencyInjection;

namespace Pg.SolutionDownloaderCore.Tests.Services
{
	public class SolutionServiceTest
	{
        private readonly ILoggerFactory _loggerFactory;

		public SolutionServiceTest()
		{
			var serviceProvider = new ServiceCollection()
				.AddLogging(opt => opt.AddConsole().SetMinimumLevel(LogLevel.Trace))
                .BuildServiceProvider();
            _loggerFactory = serviceProvider.GetService<ILoggerFactory>();
        }

		[Fact]
		public void DownloadSolution_ValidResponse()
		{
			bool fileSaved = false; 
			var repo = new Mock<ISolutionRepository>();
			repo.Setup(r => r.Get(It.IsAny<string>(), It.IsAny<bool>()))
				.Returns(new ExportSolutionResponse());
			
			var file  = new Mock<IFile>();
			file.Setup(f => f.WriteAllBytes(It.IsAny<string>(), It.IsAny<byte[]>()))
				.Callback(() =>
					{
						fileSaved = true; 
					});

			var service = new SolutionService(repo.Object, file.Object, _loggerFactory);
			service.DownloadSolution(String.Empty, String.Empty, false);

			Assert.True(fileSaved); 
        }

		[Fact]
		public void DownloadSolution_MissingResponse()
		{
            bool fileSaved = false;
            var repo = new Mock<ISolutionRepository>();
            repo.Setup(r => r.Get(It.IsAny<string>(), It.IsAny<bool>()))
                .Returns<ISolutionRepository>(null);

            var file = new Mock<IFile>();
            file.Setup(f => f.WriteAllBytes(It.IsAny<string>(), It.IsAny<byte[]>()))
                .Callback(() =>
                {
                    fileSaved = true;
                });

            var service = new SolutionService(repo.Object, file.Object, _loggerFactory);
            service.DownloadSolution(String.Empty, String.Empty, false);

            Assert.False(fileSaved);
        }

        [Fact]
        public void DownloadSolution_HandleDataverseCallException() 
		{
            bool fileSaved = false;
            var repo = new Mock<ISolutionRepository>();
            repo.Setup(r => r.Get(It.IsAny<string>(), It.IsAny<bool>()))
                .Throws(new DataverseCallException(String.Empty, new Exception()));

            var file = new Mock<IFile>();
            file.Setup(f => f.WriteAllBytes(It.IsAny<string>(), It.IsAny<byte[]>()))
                .Callback(() =>
                {
                    fileSaved = true;
                });

            var service = new SolutionService(repo.Object, file.Object, _loggerFactory);
            service.DownloadSolution(String.Empty, String.Empty, false);

            Assert.False(fileSaved);
        }

        [Fact]
        public void DownloadSolution_HandleException()
        {
            bool fileSaved = false;
            var repo = new Mock<ISolutionRepository>();
            repo.Setup(r => r.Get(It.IsAny<string>(), It.IsAny<bool>()))
                .Throws(new Exception());

            var file = new Mock<IFile>();
            file.Setup(f => f.WriteAllBytes(It.IsAny<string>(), It.IsAny<byte[]>()))
                .Callback(() =>
                {
                    fileSaved = true;
                });

            var service = new SolutionService(repo.Object, file.Object, _loggerFactory);
            service.DownloadSolution(String.Empty, String.Empty, false);

            Assert.False(fileSaved);
        }
    }
}
