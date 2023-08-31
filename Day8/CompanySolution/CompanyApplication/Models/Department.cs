using System.ComponentModel.DataAnnotations;

namespace CompanyApplication.Models
{
    public class Department
    {
        [Key]
        public int DepartmentNumber { get; set; }
        public string Name { get; set; }

        //Navigation properties
        public ICollection<Employee> Employees { get; set; }
    }
}
