using ProjetoAPICliente.Data.Repositorio.Interface;
using ProjetoAPICliente.Dominio.Dominio;
using ProjetoAPICliente.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAPICliente.Servico.Servico
{
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public void Adicionar(Cliente cliente)
        {
            _clienteRepositorio.Adicionar(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            _clienteRepositorio.Atualizar(cliente);
        }

        public Cliente BuscarPorId(int id)
        {
           return _clienteRepositorio.BuscarPorId(id);
        }

        public void Deletar(int id)
        {
            _clienteRepositorio.Deletar(id);
        }

        public List<Cliente> ListarClientes()
        {
           return _clienteRepositorio.ListarClientes();
        }
    }
}
