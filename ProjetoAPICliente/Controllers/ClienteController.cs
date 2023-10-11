using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoAPICliente.Data.DTO;
using ProjetoAPICliente.Dominio.Dominio;
using ProjetoAPICliente.Servico.Servico.Interface;
using System;
using System.Collections.Generic;

namespace ProjetoAPICliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServico _clienteServico;

        public ClienteController(IClienteServico clienteServico)
        {
            _clienteServico = clienteServico;
        }

        [HttpPost]
        public ActionResult Cadastro(ClienteDTO clienteDTO)
        {
            try
            {
                Cliente cliente = new Cliente()
                {
                    IdCliente = clienteDTO.IdCliente,
                    NomeCliente = clienteDTO.NomeCliente,
                    EmailCliente = clienteDTO.EmailCliente,
                    Cpf = clienteDTO.Cpf
                };

                _clienteServico.Adicionar(cliente);
            }
            catch
            {
                throw;
            }

            return Ok(clienteDTO);
        }

        [HttpGet]
        public List<Cliente> ListarClientes()
        {
            try
            {
                var lista = _clienteServico.ListarClientes();
                return lista;
            }
            catch
            {
                throw;
            }
        }
    }
}
