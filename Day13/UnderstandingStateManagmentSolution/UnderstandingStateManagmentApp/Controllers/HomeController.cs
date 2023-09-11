using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnderstandingStateManagmentApp.Models;

namespace UnderstandingStateManagmentApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                ViewBag.User = HttpContext.Session.GetString("Username").ToString();
            }
            catch (Exception)
            {
                return RedirectToAction("Login","User");
            } 
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}