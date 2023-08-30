using Microsoft.AspNetCore.Mvc;
using PizzaStoreApp.Models;
using PIzzaStoreModelLibrary;

namespace PizzaStoreApp.Controllers
{
    public class PizzaController : Controller
    {
        static List<PizzaWithPic> pizzas = new List<PizzaWithPic>()
        {
            new PizzaWithPic{Id=1,Name="Schezwan Margherita", Price=389,Quantity=3,Type="Non-Veg",Pic="/images/Pizza1.jpeg"},
            new PizzaWithPic{Id=2,Name="Ultimate Tandoori Veggie", Price=609,Quantity=2,Type="Veg" ,Pic="/images/Pizza2.jpeg"}
        };
        [HttpGet]
        public IActionResult Index()
        {
            //ViewBag.Pizzas = pizzas;
            //return View();
            return View(pizzas);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
           Pizza pizza = pizzas.SingleOrDefault(x => x.Id == id);
           return View(pizza);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Pizza pizza = pizzas.SingleOrDefault(x => x.Id == id);
            return View(pizza); ;
        }

        [HttpPost]
        public IActionResult Delete(int id,PizzaWithPic pizza)
        {
            pizzas.Remove(pizza);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PizzaWithPic pizza)
        {
            pizza.Pic = "/images/" + pizza.Pic;
            pizzas.Add(pizza);
            return RedirectToAction("Index");
        }
    }
}
