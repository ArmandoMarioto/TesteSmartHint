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
            Console.WriteLine("asfasfasfasfasf");
            _clienteRepositorio.Apagar(Id);
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult Criar(ClienteModel cliente)
        {
            if (ModelState.IsValid)
            {
                _clienteRepositorio.Adicionar(cliente);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Alterar(ClienteModel cliente)
        {
            if (ModelState.IsValid)
            {
                _clienteRepositorio.Atualizar(cliente);
                return RedirectToAction("Index");
            }
            return View("Editar",cliente);
        }
    }
}
