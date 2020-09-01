using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServicesCliente : IApplicationServiceCliente
    {
        private readonly IServicesCliente servicesCliente;
        private readonly IMapperCliente mapperCliente;

        public ApplicationServicesCliente(IMapperCliente mapperCliente, IServicesCliente servicesCliente)
        {
            this.mapperCliente = mapperCliente;
            this.servicesCliente = servicesCliente;
        }

        public void Add(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            servicesCliente.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = servicesCliente.GetAll();
            return mapperCliente.MapperListClienteToDto(clientes); 
        }

        public ClienteDto GetById(int id)
        {
            var cliente = servicesCliente.GetId(id);
            return mapperCliente.MapperEntityToDto(cliente);
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            servicesCliente.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            servicesCliente.Update(cliente);
        }
    }
}
