using CompanyApplication.Interfaces;
using CompanyApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Drawing.Printing;

namespace CompanyApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRepository<int, Employee> _repository;
        private readonly IRepository<int, Department> _departmentRepo;

        public EmployeeController(IRepository<int,Employee> repository,IRepository<int,Department> departmentRepo) 
        {
            _repository = repository;
            _departmentRepo = departmentRepo;
        }
        public IActionResult Index()
        {
            var employees = _repository.GetAll();
            return View(employees);
        }

        public IActionResult Create()
        {
            ViewBag.departmentList = GetDepartments();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            ViewBag.departmentList = GetDepartments();
            _repository.Add(employee);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = _repository.Get(id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Delete(int id,Employee employee)
        {
           _repository.Delete(id);
            return RedirectToAction("Index");
        }
        private List<SelectListItem> GetDepartments()
        {
            List<SelectListItem> departmentList = new List<SelectListItem>();
            var departments = _departmentRepo.GetAll();
            foreach (var item in departments)
            {
                departmentList.Add(
                    new SelectListItem
                    { Text = item.Name, Value = item.DepartmentNumber.ToString() }
                    );
            }
            return departmentList;
        }
    }
}
