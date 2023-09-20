using FirstAPI.Interfaces;
using FirstAPI.Models;
using FirstAPI.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [EnableCors("MyCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService) 
        {
            _employeeService = employeeService;
        }
        
        [HttpGet]
        public ActionResult Get()
        {
            var result = _employeeService.GetAllEmployees();
            if(result == null)
            {
                return NotFound("No employees are there at this moment");
            }
            return Ok(result);
        }
        [Authorize(Roles ="Manager")]
        [HttpPost]
        public ActionResult Post(Employee employee)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var result = _employeeService.AddANewEmployee(employee);
                    return Created("", result);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            return BadRequest(ModelState.Keys);
        }

        [HttpPut("UpdateStatus")]
        public ActionResult PutChangeStatus(int id )
        {
            try
            {
                var result = _employeeService.ToggleEmployeeStatus(id);
                if (result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
