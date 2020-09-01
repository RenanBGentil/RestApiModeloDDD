using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Domain.Services.ServicesBase
{
    public class ServicesProduto : ServicesBase<Produto>, IServicesBase<Produto>
    {
        private readonly IRepositoryProduto repository;

        public ServicesProduto(IRepositoryProduto repository) : base (repository)
        {
            this.repository = repository;
        }
    }
}
