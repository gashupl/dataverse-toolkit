using Pg.DataverseTags.Plugins.StepsRegistrator.Model;
using System.Collections.Generic;

namespace Pg.DataverseTags.Plugins.StepsRegistrator.Data
{
	public interface IConfig
	{
        List<PluginStepConfig> ReadStepsConfiguration(string path); 
    }
}
