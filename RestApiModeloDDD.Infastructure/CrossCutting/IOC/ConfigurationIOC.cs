using Autofac;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Infastructure.Data.Repositorys;
using RestApiModeloDDD.Infastructure.Services;

namespace RestApiModeloDDD.Infastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Ioc

            builder.RegisterType<ApplicationServicesCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServicesProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServicesCliente>().As<IServicesCliente>();
            builder.RegisterType<ServicesProduto>().As<IServicesProduto>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion
        }
    }
}
