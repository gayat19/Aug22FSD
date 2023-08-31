using CompanyApplication.Interfaces;
using CompanyApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CompanyApplication.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IRepository<int, Department> _repository;

        public DepartmentController(IRepository<int,Department> repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.GetAll());
        }
        [HttpGet]
        public IActionResult Add()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Add(Department department)
        {
            _repository.Add(department);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var department = _repository.Get(id);   
            return View(department);
        }
        public IActionResult Delete(int id,Department department)
        {
            ViewBag.Message = "";
            try
            {
                _repository.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                ViewBag.Message = "Unable to delete department.";
            }
            return View(department);
        }
    }
}
