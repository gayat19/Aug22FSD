

using CompanyApplication.Migrations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyApplication.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public float Salary { get; set; }
        public int DepartmnetId { get; set; }

        [ForeignKey("DepartmnetId")]
        public Department Department  { get; set; }

        public ICollection<Skill> Skills { get; set; }
    }
}
