using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Domain.Services.ServicesBase
{
    public class ServicesBase<TEntity> : IServicesBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServicesBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntity obj)
        {
               repository.Add(obj);
          
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetId(int id)
        {
            return repository.GetId(id);
        }

        public void Remove(TEntity obj)
        {
           
                repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
           
                repository.Update(obj);
        
        }
    }
}
