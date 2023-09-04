using DoctorClinicApplication.Contexts;
using DoctorClinicApplication.Interfaces;
using DoctorClinicApplication.Models;
using DoctorClinicApplication.Utilities;

namespace DoctorClinicApplication.Repositories
{
    public class AppointmnetRepository : IRepository<int, Appointment>
    {
        private readonly ClinicContext _context;

        public AppointmnetRepository(ClinicContext context)
        {
            _context = context;   
        }
        public Appointment Add(Appointment entity)
        {
            _context.appointments.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Appointment Delete(int key)
        {
            var appointment = GetById(key);
            if (appointment == null)
                throw new NoSuchEntityException("Appointment");
            _context.appointments.Remove(appointment);
            _context.SaveChanges();
            return appointment;
        }

        public ICollection<Appointment> GetAll()
        {
            var appointments = _context.appointments;
            if (appointments.Count() == 0)
                throw new NoEntriesAvailable("Appointments");
            return appointments.ToList();
        }

        public Appointment GetById(int key)
        {
            var appointmnet = _context.appointments.SingleOrDefault(app => app.AppointmentNumber == key);
            if (appointmnet != null)
                return appointmnet;
            throw new NoSuchEntityException("Appointments");
        }

        public Appointment Update(Appointment entity)
        {
            var appointmnet = GetById(entity.AppointmentNumber);
            if (appointmnet == null)
                throw new NoSuchEntityException("Appointmnet");
            appointmnet.PatientId = entity.PatientId;
            appointmnet.DoctorId = entity.DoctorId;
            appointmnet.AppointmentDateTime = entity.AppointmentDateTime;
            _context.SaveChanges();
            return entity;
        }
    }
}
