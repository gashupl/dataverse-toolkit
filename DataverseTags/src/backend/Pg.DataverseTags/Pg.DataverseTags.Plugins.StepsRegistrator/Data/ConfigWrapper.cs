using Newtonsoft.Json;
using Pg.DataverseTags.Plugins.StepsRegistrator.Model;
using System.Collections.Generic;
using System.IO;

namespace Pg.DataverseTags.Plugins.StepsRegistrator.Data
{
	internal class ConfigWrapper : IConfig
	{
		public List<PluginStepConfig> ReadStepsConfiguration(string path)
		{
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<PluginStepConfig>>(path);
            }
        }
    }
}
