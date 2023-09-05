using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorClinicApplication.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentNumber { get; set; }
        [Required(ErrorMessage ="Patient details are manditory")]
        public int PatientId { get; set; }
        [Required(ErrorMessage = "Doctor details are manditory")]
        public int DoctorId { get; set; }
        [Required(ErrorMessage = "Plaease choose a date and time")]
        public DateTime AppointmentDateTime { get; set; }

        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor? Doctor { get; set; }
    }
}
