using DoctorClinicApplication.Interfaces;
using DoctorClinicApplication.Models.DTOs;
using DoctorClinicApplication.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace DoctorClinicApplication.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService service)
        {
            _loginService = service; 
        }
        [HttpGet]
        //Route("Login")]
        public IActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        //[Route("Login")]
        public IActionResult UserLogin(LoginDTO loginDTO)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var patient = _loginService.Login(loginDTO);
                    if(patient != null)
                    {
                        TempData.Add("un", patient.Name);
                    }
                    return RedirectToAction("Index", "Doctor");
                }
                catch (InvalidCredentialsException e)
                {
                    ViewBag.ErrorMessage = e.Message;
                }
            }

            return View(loginDTO);
        }
    }
}
