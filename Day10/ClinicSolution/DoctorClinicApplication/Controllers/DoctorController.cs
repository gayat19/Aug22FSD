using DoctorClinicApplication.Interfaces;
using DoctorClinicApplication.Models;
using DoctorClinicApplication.Models.DTOs;
using DoctorClinicApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DoctorClinicApplication.Controllers
{
    public class DoctorController : Controller
    {
        List<SelectListItem> specilities = new List<SelectListItem>()
        {
            new SelectListItem{Value="Dentists", Text="Dentists"},
            new SelectListItem{Value="Cardiologist", Text="Cardiologist"},
            new SelectListItem{Value="Dermatologits", Text="Dermatologits"},
            new SelectListItem{Value="Pediatrician", Text="Pediatrician" }
        };
        private readonly IDoctorService _doctorService;
        private readonly ILogger<DoctorController> _logger;

        public DoctorController(IDoctorService doctorService,ILogger<DoctorController> logger)
        {
            _doctorService = doctorService;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var doctors = new List<Doctor>();
            try
            {
               
                if (TempData.Peek("un") == null)
                    return RedirectToAction("UserLogin", "Login");
                ViewBag.Username = TempData.Peek("un").ToString();
                doctors = _doctorService.GetAllDoctor().ToList();
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
                _logger.LogError("No doctors are available and call this a hospital..");
            }
            return View(doctors);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Specialities = specilities;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Doctor doctor)
        {
            ViewBag.ErrorMessage = "";
            ViewBag.Specialities = specilities;
            try
            {
                var myDoctor = _doctorService.Add(doctor);
                _logger.LogInformation("Created doctor record");
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
                //Logging for programmer
                _logger.LogError("Unable to add doctor "+DateTime.Now.ToString());
            }
           return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Specialities = specilities;
            var doc = _doctorService.GetAllDoctor().SingleOrDefault(x => x.Id == id);
            var doctor = new DoctorSpecialDTO { Id= id,Speciality=doc.Speciality };
            return View(doctor);
        }
        [HttpPost]
        public IActionResult Update(int id,DoctorSpecialDTO doctor)
        {
            ViewBag.Specialities = specilities;
            try
            {
               var result =  _doctorService.UpdateSpecialization(doctor);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
                //Logging for programmer
                _logger.LogError("Unable to upadte doctor speciality " + DateTime.Now.ToString());
            }
            return View(doctor);
        }
    }
}
