using System.ComponentModel.DataAnnotations;

namespace CompanyApplication.Models
{
    public class Skill
    {
        [Key]
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
