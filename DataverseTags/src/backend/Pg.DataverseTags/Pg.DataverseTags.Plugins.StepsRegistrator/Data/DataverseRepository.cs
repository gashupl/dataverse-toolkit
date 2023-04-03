using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using Pg.DataverseTags.Plugins.StepsRegistrator.Data;
using Pg.DataverseTags.Shared.Model;
using System;
using System.Linq;
using System.ServiceModel;

namespace Pg.SolutionDownloaderCore.Data
{
    public class DataverseRepository : IPluginsRepository
    {
        private readonly IOrganizationService _service; 
		private readonly ILogger<DataverseRepository> _logger;
        public DataverseRepository(IOrganizationService service, ILoggerFactory loggerFactory)
		{
            _service = service;
			_logger = loggerFactory.CreateLogger<DataverseRepository>();
		}

        public void CreateSteps()
        {
            try
            {

                //TODO: Implement step creation here...

                //Retrieve Plugin Type to see if it is registered in Dataverse
                using (var ctx = new DataverseContext(_service))
                {
					var query = ctx.CreateQuery<PluginType>()
						.Where(x => x.assemblyname == "Pg.DataverseTags.Plugins"
							&& x.name == "Pg.DataverseTags.Plugins.ValidateTagPlugin");

					var pluginType = query.FirstOrDefault<PluginType>();
					var id = pluginType.Id; 
                }

				return; 
                //Create
                var step = new SdkMessageProcessingStep();
                step.name = "Pg.DataverseTags.Plugins.ValidateTagPlugin: Create of pg_tag";
                step.description = "Pg.DataverseTags.Plugins.ValidateTagPlugin: Create of pg_tag";
                step.mode = SdkMessageProcessingStep_mode.Synchronous;
				step.rank = 1; //Execution Order
				step.stage = SdkMessageProcessingStep_stage.Prevalidation;
				step.supporteddeployment = SdkMessageProcessingStep_supporteddeployment.ServerOnly; 
    //            step.plugintypeid = sdkPluginType.ToEntityReference();
				//step.
    //            step.sdkmessageid = new EntityReference(SdkMessage.EntityLogicalName, sdkMessageId.Value);
              
                _service.Create(step);
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

					FaultException<OrganizationServiceFault> fe = ex.InnerException
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
