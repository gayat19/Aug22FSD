using DoctorClinicApplication.Models;
using DoctorClinicApplication.Models.DTOs;

namespace DoctorClinicApplication.Interfaces
{
    public interface IDoctorService :IAddingEntity<Doctor>
    {
        public Doctor UpdateSpecialization(DoctorSpecialDTO doctor);
        public IList<Doctor> GetAllDoctor();
    }
}
