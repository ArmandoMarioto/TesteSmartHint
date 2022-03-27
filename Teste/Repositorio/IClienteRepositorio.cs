using Teste.Models;

namespace Teste.Repositorio
{
    public interface IClienteRepositorio
    {
        ClienteModel BuscaPorId(int Id);
        ClienteModel BuscaPorEmail(string Email);
        ClienteModel BuscaPorCpf(string Cpf);
        ClienteModel BuscaPorCnpj(string Cnpj);
        ClienteModel BuscaPorEstadual(string Estadual);
        bool Apagar(int Id);
        List<ClienteModel> BuscarTodos();
        ClienteModel Adicionar(ClienteModel cliente);

        ClienteModel Atualizar(ClienteModel cliente);
    }
}
