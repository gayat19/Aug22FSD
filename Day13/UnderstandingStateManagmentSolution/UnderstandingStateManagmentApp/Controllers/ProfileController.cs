using Microsoft.AspNetCore.Mvc;

namespace UnderstandingStateManagmentApp.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet]
        public IActionResult UserProfile()
        {
            try
            {
                ViewBag.User = HttpContext.Session.GetString("Username").ToString();
            }
            catch (Exception)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
        [HttpGet]
        public IActionResult UserLogout(string un)
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "User");
        }
    }
}
