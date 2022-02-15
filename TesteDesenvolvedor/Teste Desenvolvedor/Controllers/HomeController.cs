using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Teste_Desenvolvedor.Models;

namespace Teste_Desenvolvedor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {            
            return View();
        }
                
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new BancoContext { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}