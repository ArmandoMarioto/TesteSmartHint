using Teste.Data;
using Teste.Models;

namespace Teste.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ClienteRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public List<ClienteModel> BuscarTodos()
        {
            return _bancoContext.Clientes.ToList();
        }
        public ClienteModel Adicionar(ClienteModel cliente)
        {
            _bancoContext.Clientes.Add(cliente);
            _bancoContext.SaveChanges();
            return cliente;
        }

        public ClienteModel BuscaPorId(int Id)
        {
            return _bancoContext.Clientes.FirstOrDefault(cliente => cliente.Id == Id);
        }

        public ClienteModel Atualizar(ClienteModel cliente)
        {
            ClienteModel clientedb = BuscaPorId(cliente.Id);
            if (clientedb == null) throw new Exception("Houve um erro na atualização do cliente.");

            clientedb.Name = cliente.Name;
            _bancoContext.Clientes.Update(clientedb);
            _bancoContext.SaveChanges();

            return cliente;
        }

        public bool Apagar(int Id)
        {
            ClienteModel clientedb = BuscaPorId(Id);
            if (clientedb == null) throw new Exception("Houve um erro na exclusão do cliente.");
            _bancoContext.Clientes.Remove(clientedb);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
