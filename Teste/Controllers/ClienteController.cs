using Microsoft.AspNetCore.Mvc;
using Teste.Models;
using Teste.Repositorio;

namespace Teste.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        public IActionResult Index()
        {
            List<ClienteModel> clientes = _clienteRepositorio.BuscarTodos();

            return View(clientes);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int Id)
        {
            ClienteModel cliente = _clienteRepositorio.BuscaPorId(Id);
            return View(cliente);
        }
        public IActionResult Apagar(int Id)
        {
            ClienteModel cliente = _clienteRepositorio.BuscaPorId(Id);
            return View(cliente);
        }
        public IActionResult ApagarConfirmacao(int Id)
        {
            try
            {
                if (_clienteRepositorio.Apagar(Id))
                {
                    TempData["MensagemSucesso"] = "Cliente apagado com sucesso!!!";
                }
                else
                {
                    TempData["MensagemErro"] = "Ops, não conseguimos apagar seu cliente.";
                }
                return RedirectToAction("Index");
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu cliente, " +
                    $"tente novamente, detalhe do erro:{error.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Criar(ClienteModel cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ClienteModel resultadoEmail = _clienteRepositorio.BuscaPorEmail(cliente.Email);

                    if (resultadoEmail == null)
                    {
                        if (cliente.Tipo == "Física")
                        {
                            ClienteModel resultadoCpf = _clienteRepositorio.BuscaPorCpf(cliente.Cpf);
                            if(resultadoCpf != null)
                            {
                                TempData["MensagemCpf"] = "Este CPF já está cadastrado para outro Cliente";
                                return View("Criar", cliente);
                            }
                        }
                        else
                        {
                            ClienteModel resultadoCnpj = _clienteRepositorio.BuscaPorCnpj(cliente.Cnpj);
                            if (resultadoCnpj != null)
                            {
                                TempData["MensagemCnpj"] = "Este CNPJ já está cadastrado para outro Cliente";
                                return View("Criar", cliente);
                            }
                            else if(!cliente.Isento)
                            {
                                ClienteModel resultadoEstadual = _clienteRepositorio.BuscaPorEstadual(cliente.Estadual);
                                if (resultadoEstadual != null)
                                {
                                    TempData["MensagemEstadual"] = "Esta Inscrição Estadual já está cadastrada para outro Cliente";
                                    return View("Criar", cliente);
                                }
                            }
                        }

                        _clienteRepositorio.Adicionar(cliente);
                        TempData["MensagemSucesso"] = "Cliente cadastrado com sucesso!!!";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["MensagemEmail"] = "Este e-mail já está cadastrado para outro Cliente";
                        return View("Criar", cliente);
                    }

                }

                return View(cliente);

            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu cliente, " +
                    $"tente novamente, detalhe do erro:{error.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(ClienteModel cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ClienteModel resultadoEmail = _clienteRepositorio.BuscaPorEmail(cliente.Email);

                    if ((resultadoEmail != null && resultadoEmail.Id == cliente.Id) || resultadoEmail == null)
                    {
                        if (cliente.Tipo == "Física")
                        {
                            ClienteModel resultadoCpf = _clienteRepositorio.BuscaPorCpf(cliente.Cpf);
                            if (resultadoCpf != null && resultadoCpf.Id != cliente.Id)
                            {
                                TempData["MensagemCpf"] = "Este CPF já está cadastrado para outro Cliente";
                                return View("Editar", cliente);
                            }
                        }
                        else
                        {
                            ClienteModel resultadoCnpj = _clienteRepositorio.BuscaPorCnpj(cliente.Cnpj);
                            if (resultadoCnpj != null && resultadoCnpj.Id != cliente.Id)
                            {
                                TempData["MensagemCnpj"] = "Este CNPJ já está cadastrado para outro Cliente";
                                return View("Editar", cliente);
                            }
                            else if (!cliente.Isento)
                            {
                                ClienteModel resultadoEstadual = _clienteRepositorio.BuscaPorEstadual(cliente.Estadual);
                                if (resultadoEstadual != null && resultadoEstadual.Id != cliente.Id)
                                {
                                    TempData["MensagemEstadual"] = "Esta Inscrição Estadual já está cadastrada para outro Cliente";
                                    return View("Editar", cliente);
                                }
                            }
                        }

                        _clienteRepositorio.Atualizar(cliente);
                        TempData["MensagemSucesso"] = "Cliente alterado com sucesso!!!";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["MensagemEmail"] = "Este e-mail já está cadastrado para outro Cliente";
                        return View("Editar", cliente);
                    }

                }

                return View("Editar", cliente);
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos alterar seu cliente, " +
                    $"tente novamente, detalhe do erro:{error.Message}";
                return RedirectToAction("Index");
            }

        }
    }
}
