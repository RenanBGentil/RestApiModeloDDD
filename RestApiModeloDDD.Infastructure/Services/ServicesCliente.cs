using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Infastructure.Services
{
    public class ServicesCliente : ServicesBase<Clientes>, IServicesBase<Clientes>
    {
        private readonly IRepositoryCliente repository;

        public ServicesCliente(IRepositoryCliente repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
