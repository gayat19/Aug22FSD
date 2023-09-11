using Microsoft.AspNetCore.Mvc;
using UnderstandingStateManagmentApp.Models;
using UnderstandingStateManagmentApp.Services;

namespace UnderstandingStateManagmentApp.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService) 
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            var result = _userService.LoginCheck(user);
            if(result)
            {
                HttpContext.Session.SetString("Username", user.Username);
                return RedirectToAction("Index", "Home");
            }
              
            ViewBag.ErrorMessage = "Invalid username or password";
            return View(user);
        }
    }
}
