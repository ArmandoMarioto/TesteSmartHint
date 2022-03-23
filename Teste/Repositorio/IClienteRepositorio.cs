using Teste.Models;

namespace Teste.Repositorio
{
    public interface IClienteRepositorio
    {
        List<ClienteModel> BuscarTodos();
        ClienteModel Adicionar(ClienteModel cliente);
    }
}
