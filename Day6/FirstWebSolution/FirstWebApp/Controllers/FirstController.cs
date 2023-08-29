using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Another()
        {
            return View();
        }
    }
}
