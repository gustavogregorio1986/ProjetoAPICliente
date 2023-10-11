using ProjetoAPICliente.Data.DTO;
using ProjetoAPICliente.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAPICliente.Data.Repositorio.Interface
{
    public interface IClienteRepositorio
    {
        void Adicionar(Cliente cliente);

        List<Cliente> ListarClientes();

        void Atualizar(Cliente cliente);

        void Deletar(int id);

        Cliente BuscarPorId(int id);
    }
}
