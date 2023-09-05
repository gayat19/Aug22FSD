using DoctorClinicApplication.Models;
using DoctorClinicApplication.Models.DTOs;

namespace DoctorClinicApplication.Interfaces
{
    public interface ILoginService
    {
        public Patient Login(LoginDTO loginDTO);
    }
}
