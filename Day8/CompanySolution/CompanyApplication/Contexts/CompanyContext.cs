using CompanyApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyApplication.Contexts
{
    public class CompanyContext: DbContext
    {
        public CompanyContext(DbContextOptions options):base(options)//constructor chaining
        {
            
        }
        #region CollectionToTable
        //public DbSet<Employee> Employees { get; set; }//"Employees"
        public DbSet<Employee> employees { get; set; }//employees
        public DbSet<Department> departments { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<EmployeesSkills> employeesskills { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeesSkills>().HasKey(es => new { es.EmployeeId, es.SkillName });


            //Seeding/Initializing data
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentNumber=1,Name="Operations"},
                new Department { DepartmentNumber = 2, Name = "HR" }
                );
        }
    }
}
