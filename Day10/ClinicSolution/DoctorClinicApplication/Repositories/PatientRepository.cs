using DoctorClinicApplication.Contexts;
using DoctorClinicApplication.Interfaces;
using DoctorClinicApplication.Models;
using DoctorClinicApplication.Utilities;

namespace DoctorClinicApplication.Repositories
{
    public class PatientRepository : IRepository<int, Patient>
    {
        private readonly ClinicContext _context;

        public PatientRepository(ClinicContext context)
        {
            _context = context;
        }
        public Patient Add(Patient entity)
        {
            _context.patients.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Patient Delete(int key)
        {
            var patient = GetById(key);
            if (patient == null)
                throw new NoSuchEntityException("Patient");
            _context.patients.Remove(patient);
            _context.SaveChanges();
            return patient;
        }

        public ICollection<Patient> GetAll()
        {
           var patients = _context.patients;
            if (patients.Count() == 0)
                throw new NoEntriesAvailable("Patient");
            return patients.ToList();
        }

        public Patient GetById(int key)
        {
            var patient = _context.patients.SingleOrDefault(d => d.Id == key);
            if (patient != null)
                return patient;
            throw new NoSuchEntityException("Patinet");
        }

        public Patient Update(Patient entity)
        {
            var patient = GetById(entity.Id);
            if (patient == null)
                throw new NoSuchEntityException("Patient");
            _context.patients.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
