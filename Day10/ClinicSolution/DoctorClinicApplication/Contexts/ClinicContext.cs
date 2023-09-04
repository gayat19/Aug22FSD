using DoctorClinicApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorClinicApplication.Contexts
{
    public class ClinicContext :DbContext
    {
        public ClinicContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Patient> patients { get; set; }
        public DbSet<Appointment> appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = 101, Name = "Ramu", Speciality= "Dentists", Experience = 4, Email = "ramu@myclinic.com", Phone = "+919988776655", Pic = "/images/Doc1", },
                 new Doctor { Id = 102, Name = "Somu",Speciality= "Cardiologist", Experience = 8, Email = "somu@myclinic.com", Phone = "+915544332211", Pic = "/images/Doc2", }
                );
            modelBuilder.Entity<Patient>().HasData(
                new Patient { Id=1,Name="Kim",Age=22,Phone="5454545454",Email="kim@gmail.com"},
                new Patient { Id = 2, Name = "Lom", Age = 56, Phone = "9898989898", Email = "lom@gmail.com" }
                );
        }
    }
}
