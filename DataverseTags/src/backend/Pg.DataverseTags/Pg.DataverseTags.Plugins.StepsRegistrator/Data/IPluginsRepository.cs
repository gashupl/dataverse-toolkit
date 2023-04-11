using Pg.DataverseTags.Plugins.StepsRegistrator.Model;
using Pg.DataverseTags.Shared.Model;
using System;

namespace Pg.DataverseTags.Plugins.StepsRegistrator.Data
{
    public interface IPluginsRepository
    {
        PluginType GetPluginType(string assemblyName, string pluginName);
        void CreateStep(CreateStepParam param);
        SdkMessage GetMessage(string messageName);
        SdkMessageFilter GetMessageFilter(string entityLogicalName, string messageName);
    }
}
