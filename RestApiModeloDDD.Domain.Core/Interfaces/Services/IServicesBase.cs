using System.Collections.Generic;

namespace RestApiModeloDDD.Domain.Core.Interfaces.Services
{
    public interface IServicesBase<TEntity> where TEntity : class
    {
        public void Add(TEntity obj);
        public void Update(TEntity obj);
        public void Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetId(int id);
    }
}
