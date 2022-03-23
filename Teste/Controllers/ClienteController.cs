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
                    _clienteRepositorio.Adicionar(cliente);
                    TempData["MensagemSucesso"] = "Cliente cadastrado com sucesso!!!";
                    return RedirectToAction("Index");
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
                    _clienteRepositorio.Atualizar(cliente);
                    TempData["MensagemSucesso"] = "Cliente alterado com sucesso!!!";
                    return RedirectToAction("Index");
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
