using ProjetoAPICliente.Data.Contexto;
using ProjetoAPICliente.Data.Repositorio.Interface;
using ProjetoAPICliente.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAPICliente.Data.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly BancoContexto _db;

        public ClienteRepositorio(BancoContexto db)
        {
            _db = db;
        }

        public void Adicionar(Cliente cliente)
        {
            _db.Add(cliente);
            _db.SaveChanges();
        }

        public void Atualizar(Cliente cliente)
        {
            _db.Update(cliente);
        }

        public Cliente BuscarPorId(int id)
        {
            return _db.Set<Cliente>().FirstOrDefault(x => x.IdCliente == id);
        }

        public void Deletar(int id)
        {
            _db.Remove(id);
        }

        public List<Cliente> ListarClientes()
        {
            return _db.Set<Cliente>().ToList();
        }
    }
}
