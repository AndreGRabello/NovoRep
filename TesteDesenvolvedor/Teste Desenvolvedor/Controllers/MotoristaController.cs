using Microsoft.AspNetCore.Mvc;
using Teste_Desenvolvedor.Models;
using Teste_Desenvolvedor.Repositorio;

namespace Teste_Desenvolvedor.Controllers
{
    public class MotoristaController : Controller
    {
        private readonly IMotoristaRepositorio _motoristaRepositorio;
        public MotoristaController(IMotoristaRepositorio motoristaRepositorio)
        {
            _motoristaRepositorio = motoristaRepositorio;
        }
        public IActionResult Index()
        {
            List<MotoristaModel> motorista = _motoristaRepositorio.BuscarTodos();
            return View(motorista);
        }

        public IActionResult Listar()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            MotoristaModel motorista = _motoristaRepositorio.ListarPorId(id);
            return View(motorista);
        }

        public IActionResult Excluir(int id)
        {
            MotoristaModel motorista = _motoristaRepositorio.ListarPorId(id); 
            return View();
        }

        public IActionResult Apagar(int id)
        {
            _motoristaRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(MotoristaModel motorista)
        {
            if (ModelState.IsValid)
            {
                _motoristaRepositorio.Adicionar(motorista);
                return RedirectToAction("Index");
            }
            return View(motorista);
        }

        [HttpPost]
        public IActionResult Alterar(MotoristaModel motorista)
        {
            _motoristaRepositorio.Atualizar(motorista);
            return RedirectToAction("Index");
        }
    }
}
