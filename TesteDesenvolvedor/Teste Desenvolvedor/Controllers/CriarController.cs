using Microsoft.AspNetCore.Mvc;

namespace Teste_Desenvolvedor.Controllers
{
    public class CriarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
