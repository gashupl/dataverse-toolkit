using Pg.DataverseTags.Plugins.StepsRegistrator.Model;

namespace Pg.DataverseTags.Plugins.StepsRegistrator.Data
{
    public interface IPluginsRepository
    {
        void CreateStep(PluginStepConfig stepConfig); 
    }
}
