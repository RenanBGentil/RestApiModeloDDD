using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModeloDDD.Infastructure.CrossCutting.Interfaces
{
    public interface IMapperCliente
    {

        Clientes MapperDtoToEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MapperListClienteToDto(IEnumerable<Clientes> cliente);
        ClienteDto MapperEntityToDto(Clientes cliente);
    }
}
