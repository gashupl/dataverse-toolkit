using System;

namespace Pg.DataverseTags.Plugins.StepsRegistrator.Model
{
    public class CreateStepParam
    {
        public Guid PluginId { get; set; }
        public Guid FilterId { get; set; }
        public Guid MessageId { get; set; }
        public string MessageName { get; set; }
        public string FilteringAttributes { get; set; } = null; 
    }
}
