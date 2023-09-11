using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        //[HttpGet]
        //public string[] Get()
        //{
        //    return new string[]{ "Hello","Hi","Welcome","Bye"};
        //}

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new string[] { "Hello", "Hi", "Welcome", "Bye" });
        }
        [HttpGet("GetById")]
        public ActionResult GetAnother(int idx)
        {
            return Ok(new string[] { "Hello", "Hi", "Welcome", "Bye" }[idx]);
        }
        [HttpPost]
        public ActionResult Gayathri(string name)
        {
            if (name.Length > 3)
                return Ok(name);
            return BadRequest();
        }
        [HttpPut]
        public ActionResult Lakshman(Student student)
        {
            if (student.Id == 101)
            {
                student.Name = "Somu";
                return Ok(student);
            }
            return BadRequest();
               
        }
        [HttpDelete]
        public ActionResult Abhinav(int id)
        {
            if(id==101)
                return Ok();
            return NotFound();

        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
