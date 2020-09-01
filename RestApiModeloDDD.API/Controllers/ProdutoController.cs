using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestApiModeloDDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ApplicationServicesProduto _servicesProduto;

        public ProdutoController(ApplicationServicesProduto servicesProduto)
        {
            _servicesProduto = servicesProduto;
        }
     
        [HttpGet]
        public ActionResult <IEnumerable<string>> Get()
        {
            return Ok(_servicesProduto.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_servicesProduto.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                return NotFound();

                _servicesProduto.Add(produtoDto);
                return Ok("Produto cadastrado com sucesso");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _servicesProduto.Update(produtoDto);
                return Ok("Produto foi atualizado com sucesso");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id, [FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _servicesProduto.Remove(produtoDto);
                return Ok("Produto deletado com sucesso");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
