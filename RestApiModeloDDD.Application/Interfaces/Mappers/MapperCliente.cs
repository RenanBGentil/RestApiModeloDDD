using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApiModeloDDD.Application.Interfaces.Mappers
{
    public class MapperCliente : IMapperCliente
    {


        public Clientes MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Clientes()
            {
                Id = clienteDto.Id,
                Nome = clienteDto.Nome,
                Sobrenome = clienteDto.SobreNome,
                Email = clienteDto.Email,
            };

            return cliente;
        }

        public ClienteDto MapperEntityToDto(Clientes cliente)
        {
            var clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                SobreNome = cliente.Sobrenome,
                Email = cliente.Email,
            };
            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClienteToDto(IEnumerable<Clientes> cliente)
        {
            var dto = cliente.Select(c => new ClienteDto
            {
                Id = c.Id,
                Nome = c.Nome,
                SobreNome = c.Sobrenome,
                Email = c.Email,
            });

            return dto;
        }
    }
}
