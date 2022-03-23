using Teste.Models;

namespace Teste.Repositorio
{
    public interface IClienteRepositorio
    {
        ClienteModel BuscaPorId(int Id);
        bool Apagar(int Id);
        List<ClienteModel> BuscarTodos();
        ClienteModel Adicionar(ClienteModel cliente);

        ClienteModel Atualizar(ClienteModel cliente);
    }
}
