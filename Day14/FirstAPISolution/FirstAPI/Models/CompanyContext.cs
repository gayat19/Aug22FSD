using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions opts):base(opts) 
        {
            
        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<User> users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id=101,Name="Ramu",Age=21,Phone="1234567890",Salary=12345.6f},
                new Employee { Id = 102, Name = "Somu", Age = 27, Phone = "9876543210", Salary = 54321.6f }
                );
        }
    }
}
