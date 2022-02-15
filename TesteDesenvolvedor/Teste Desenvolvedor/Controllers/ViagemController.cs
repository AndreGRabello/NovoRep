using Microsoft.AspNetCore.Mvc;

namespace Teste_Desenvolvedor.Controllers
{
    public class ViagemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

    }
}
