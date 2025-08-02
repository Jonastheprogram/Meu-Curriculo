using Microsoft.AspNetCore.Mvc;

namespace MeuCurriculo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult IndexHome()
        {
            return View();
        }
    }
}
