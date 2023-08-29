using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class PizzaController : Controller
    {
        List<string> pizzas = new List<string>
        {
            "ABC","XYZ","EFG"
        };
        public IActionResult Index()
        {
            ViewBag.PizzaName = "ABC Pizza";
            ViewBag.PIzzaPrice = 200;
            ViewBag.PizzaQuantity = 4;
            return View();
        }
        public IActionResult List()
        {
            ViewBag.Pizzas = pizzas;
            return View();
        }
    }
}
