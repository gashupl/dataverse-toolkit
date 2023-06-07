using System;

namespace Pg.DataverseTags.Plugins.StepsRegistrator.Model
{
    public class PluginStepConfig
    {
        public string Name { get; set; }    
        public string Configuration { get; set; }
        public int Mode { get; set; }
        public int Stage { get; set; }
        public int Rank { get; set; }
        public int SupportedDeployment { get; set; }
        public Guid PluginTypeId { get; set; }

        public Guid SdkMessageId { get; set; }

    }
}
