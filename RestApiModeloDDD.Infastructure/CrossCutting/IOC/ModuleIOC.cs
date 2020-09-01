using Autofac;
using Module = Autofac.Module;

namespace RestApiModeloDDD.Infastructure.CrossCutting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}
