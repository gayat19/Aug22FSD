using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyApplication.Models
{
    public class EmployeesSkills
    {
        public int EmployeeId { get; set; }
        public string SkillName { get; set; }
        public int SkillLevel { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [ForeignKey("SkillName")]
        public Skill Skill { get; set; }
    }
}
