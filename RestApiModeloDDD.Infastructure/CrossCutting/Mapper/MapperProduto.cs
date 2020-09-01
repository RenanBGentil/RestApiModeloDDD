using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;
using RestApiModeloDDD.Infastructure.CrossCutting.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Infastructure.CrossCutting.Mapper
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor,

            };
            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor,
            };

            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListClienteToDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(c => new ProdutoDto
            { 
                Id = c.Id,
                Nome = c.Nome,
                Valor = c.Valor,
            });

            return dto;
        }
    }
}
