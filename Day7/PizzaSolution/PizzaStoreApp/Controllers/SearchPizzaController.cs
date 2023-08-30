using Microsoft.AspNetCore.Mvc;
using PizzaStoreApp.Interfaces;
using PizzaStoreApp.Models;
using PizzaStoreApp.Models.DTO;

namespace PizzaStoreApp.Controllers
{
    public class SearchPizzaController : Controller
    {
        private readonly IPizzaService _pizzaService;

        public SearchPizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        [HttpGet]
        public IActionResult GetPizzas()
        {
            PriceRangeDTO priceRange = new PriceRangeDTO
            {
                SearchedPizzas = new List<PizzaWithPic>()
            };
            return View(priceRange);
        }
        [HttpPost]
        public IActionResult GetPizzas(PriceRangeDTO priceRange)
        {
            var pizzas = _pizzaService.GetPizzasByRange(priceRange.Minimum, priceRange.Maximum);
            priceRange.SearchedPizzas = pizzas;
            return View(priceRange);
        }
    }
}
