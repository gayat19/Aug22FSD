using System.ComponentModel.DataAnnotations;

namespace DoctorClinicApplication.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Doctor name is manditory")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Doctor's years of exp has to be provided")]
        [Range(0,22,ErrorMessage ="Invalid number for exp")]
        public int Experience { get; set; }
        public string Speciality { get; set; }
        [Required(ErrorMessage = "Doctor's phone number is manditory")]
        [RegularExpression(@"^(\+91[\-\s]?)?[0]?(91)?[789]\d{9}$", ErrorMessage ="Invalid phone number")]
        public string Phone { get; set; }
       
        [RegularExpression(@"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})", ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        public string Pic { get; set; }
        public ICollection<Appointment> Appointmnets { get; set; }
    }
}
