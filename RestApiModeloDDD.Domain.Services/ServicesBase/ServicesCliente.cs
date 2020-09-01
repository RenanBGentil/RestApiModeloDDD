using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Domain.Services.ServicesBase
{
    public class ServicesCliente : ServicesBase<Clientes>, IServicesBase<Clientes>
    {
        private readonly IRepositoryCliente repository;

        public ServicesCliente(IRepositoryCliente repository) : base (repository)
        {
            this.repository = repository;
        }
    }
}
