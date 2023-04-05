using Pg.DataverseTags.Shared.Model;
using System;

namespace Pg.DataverseTags.Plugins.StepsRegistrator.Data
{
    public interface IPluginsRepository
    {
        PluginType GetPluginType(string assemblyName, string pluginName);
        void CreateStep(Guid pluginType, Guid filterId, Guid messageId, string messageName);
        SdkMessage GetMessage(string messageName);
        SdkMessageFilter GetMessageFilter(string entityLogicalName, string messageName);
    }
}
