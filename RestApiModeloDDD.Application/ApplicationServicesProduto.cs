using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServicesProduto : IApplicationServiceProduto
    {
        private readonly IServicesProduto servivesProduto;
        private readonly IMapperProduto mapperProduto;

        public ApplicationServicesProduto(IServicesProduto servivesProduto, IMapperProduto mapperProduto)
        {
            this.servivesProduto = servivesProduto;
            this.mapperProduto = mapperProduto;
        }
        public void Add(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            servivesProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produto = servivesProduto.GetAll();
            return mapperProduto.MapperListClienteToDto(produto);
        }

        public ProdutoDto GetById(int id)
        {
            var produto = servivesProduto.GetId(id);
            return mapperProduto.MapperEntityToDto(produto) ; 
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            servivesProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            servivesProduto.Update(produto);
        }
    }
}
