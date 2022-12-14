using Microsoft.Crm.Sdk.Messages;
using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.PluginTelemetry;
using Pg.SolutionDownloaderCore.Services;
using System.ServiceModel;

namespace Pg.SolutionDownloaderCore.Data
{
    public class DataverseRepository : ISolutionRepository
    {
        private readonly IOrganizationService _service; 
		private readonly ILogger<DataverseRepository> _logger;
        public DataverseRepository(IOrganizationService service, ILoggerFactory loggerFactory)
		{
            _service = service;
			_logger = loggerFactory.CreateLogger<DataverseRepository>();
		}

        public ExportSolutionResponse Get(string name, bool isManaged)
        {
            try
            {
				var exportSolutionRequest = new ExportSolutionRequest();
				exportSolutionRequest.Managed = isManaged;
				exportSolutionRequest.SolutionName = name;

				return (ExportSolutionResponse)_service.Execute(exportSolutionRequest);
			}
			catch (FaultException<OrganizationServiceFault> ex)
			{
				_logger.LogError("The application terminated with an error.");
				_logger.LogError("Timestamp: {0}", ex.Detail.Timestamp);
				_logger.LogError("Code: {0}", ex.Detail.ErrorCode);
				_logger.LogError("Message: {0}", ex.Detail.Message);
				_logger.LogError("Inner Fault: {0}",
					null == ex.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");

				throw new DataverseCallException("Exception during solution export", ex); 
			}
			catch (TimeoutException ex)
			{
				_logger.LogError("The application terminated with an error.");
				_logger.LogError("Message: {0}", ex.Message);
				_logger.LogError("Stack Trace: {0}", ex.StackTrace);
				_logger.LogError("Inner Fault: {0}",
					null == ex?.InnerException?.Message ? "No Inner Fault" : ex.InnerException.Message);

				throw new DataverseCallException("Exception during solution export", ex);
			}
			catch (Exception ex)
			{
				_logger.LogError("The application terminated with an error.");
				_logger.LogError(ex.Message);

				// Display the details of the inner exception.
				if (ex.InnerException != null)
				{
					_logger.LogError(ex.InnerException.Message);

					FaultException<OrganizationServiceFault>? fe = ex.InnerException
						as FaultException<OrganizationServiceFault>;
					if (fe != null)
					{
						_logger.LogError("Timestamp: {0}", fe.Detail.Timestamp);
						_logger.LogError("Code: {0}", fe.Detail.ErrorCode);
						_logger.LogError("Message: {0}", fe.Detail.Message);
						_logger.LogError("Trace: {0}", fe.Detail.TraceText);
						_logger.LogError("Inner Fault: {0}", 
							null == fe.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
					}
				}

				throw new DataverseCallException("Exception during solution export", ex);
			}
        }
    }
}
