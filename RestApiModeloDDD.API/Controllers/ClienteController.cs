using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Dtos;

namespace RestApiModeloDDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ApplicationServicesCliente _applicationServicesCliente;

        public ClienteController(ApplicationServicesCliente applicationServicesCliente)
        {
            _applicationServicesCliente = applicationServicesCliente;
        }
        [HttpGet("")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServicesCliente.GetAll());
        }
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServicesCliente.GetById(id));
        }
        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServicesCliente.Add(clienteDto);
                return Ok("Cliente encontrado com sucesso");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServicesCliente.Add(clienteDto);
                return Ok("Cliente atualizado com sucesso");
            }
            catch (Exception e)
            {
                throw e;
            }
        } 
        [HttpDelete]
        public ActionResult Delete([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServicesCliente.Add(clienteDto);
                return Ok("Cliente deletado com sucesso");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
