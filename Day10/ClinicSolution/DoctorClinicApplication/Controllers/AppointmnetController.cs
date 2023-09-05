using DoctorClinicApplication.Interfaces;
using DoctorClinicApplication.Models;
using DoctorClinicApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DoctorClinicApplication.Controllers
{
    public class AppointmnetController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IDoctorService _doctorService;
        private readonly ILogger<AppointmnetController> _logger;

        public AppointmnetController(IAppointmentService appointmentService,
            IDoctorService doctorService,
            ILogger<AppointmnetController> logger) 
        {
            _appointmentService = appointmentService;
            _doctorService = doctorService;
            _logger = logger;

        }
        public IActionResult Index()
        {
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                appointments = _appointmentService.GetAll().ToList();
                return View(appointments);
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
                _logger.LogInformation("There were no appointments");
            }
            return View(appointments);
        }
        [HttpGet]
        [Route("BookAppointment/{id}")]
        public IActionResult Create(int id) 
        {
            ViewBag.Doctors = GetDoctors();
            Appointment appointment = new Appointment();
            appointment.DoctorId = id;
            appointment.AppointmentDateTime = DateTime.Now;
            return View(appointment);
        }
        [HttpPost]
        [Route("{controller}/BookAppointment/{id}")]
        public IActionResult Create(int id,Appointment appointment)
        {
            ViewBag.Doctors = GetDoctors();
            if (ModelState.IsValid)
            {
                try
                {
                    var myAppointment = _appointmentService.Add(appointment);
                    ViewBag.Registered = myAppointment.AppointmentNumber;
                    return View(myAppointment);
                }
                catch (Exception e)
                {

                    ViewBag.ErrorMessage = e.Message;
                    _logger.LogInformation("Unable to add appointment");
                }
            }
            return View(appointment);
        }
        private List<SelectListItem> GetDoctors()
        {

            List<SelectListItem> doctors = new List<SelectListItem>();
            foreach (var item in _doctorService.GetAllDoctor())
            {
                var li = new SelectListItem
                {
                    Text = item.Name+" - "+item.Speciality,
                    Value = item.Id.ToString()
                };
                doctors.Add(li);
            }
            return doctors;
            
        }
    }
}
