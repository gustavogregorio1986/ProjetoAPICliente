using ProjetoAPICliente.Data.DTO;
using ProjetoAPICliente.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAPICliente.Servico.Servico.Interface
{
    public interface IClienteServico
    {
        void Adicionar(Cliente cliente);

        List<Cliente> ListarClientes();

        void Atualizar(Cliente cliente);

        Cliente BuscarPorId(int id);

        void Deletar(int id);
    }
}
