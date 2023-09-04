using DoctorClinicApplication.Interfaces;
using DoctorClinicApplication.Models;
using DoctorClinicApplication.Models.DTOs;

namespace DoctorClinicApplication.Services
{
    public class DoctorService : IDoctorService
    {
        private IRepository<int, Doctor> _repository;

        public DoctorService(IRepository<int, Doctor> repository)
        {
            _repository = repository;
        }
        public Doctor Add(Doctor entity)
        {
           var doctor = _repository.Add(entity);
            return doctor;
        }

        public IList<Doctor> GetAllDoctor()
        {
            return _repository.GetAll().ToList();
        }

        public Doctor UpdateSpecialization(DoctorSpecialDTO doctor)
        {
            var myDoctor = _repository.GetById(doctor.Id);
            myDoctor.Speciality = doctor.Speciality;
            _repository.Update(myDoctor);
            return myDoctor;
        }
    }
}
