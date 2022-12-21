using Microsoft.Xrm.Sdk;
using Pg.DataverseTags.Plugins.Validators;
using System;

namespace Pg.DataverseTags.Plugins
{
    public class ValidateTagPlugin : PluginBase
    {
        public ValidateTagPlugin(string unsecureConfiguration, string secureConfiguration)
            : base(typeof(ValidateTagPlugin))
        {
        }

        protected override void ExecuteDataversePlugin(ILocalPluginContext localPluginContext)
        {
            localPluginContext.Trace("ValidateTagPlugin execution started"); 
            if (localPluginContext == null)
            {
                throw new ArgumentNullException(nameof(localPluginContext));
            }
            
            var context = localPluginContext.PluginExecutionContext;
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {

                localPluginContext.Trace("Target exists");
                var entity = (Entity)context.InputParameters["Target"];
                var validator = new TagValidator();
                var response = validator.IsValid(entity);

                if (!response.IsValid)
                {
                    localPluginContext.Trace("Validation failed");
                    throw new InvalidPluginExecutionException(response.GetErrors()); 
                }
                localPluginContext.Trace("Validation passed");

            }
            localPluginContext.Trace("ValidateTagPlugin execution completed");
        }
    }
}
