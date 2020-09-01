using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Clientes MapperDtoToEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MapperListClienteToDto(IEnumerable<Clientes> cliente);
        ClienteDto MapperEntityToDto(Clientes cliente);
    }
}
