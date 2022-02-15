using Microsoft.AspNetCore.Mvc;

namespace Teste_Desenvolvedor.Controllers
{
    public class ListarController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
