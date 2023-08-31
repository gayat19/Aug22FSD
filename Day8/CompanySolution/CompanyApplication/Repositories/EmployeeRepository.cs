using CompanyApplication.Contexts;
using CompanyApplication.Interfaces;
using CompanyApplication.Models;
using Microsoft.EntityFrameworkCore;


namespace CompanyApplication.Repositories
{
    public class EmployeeRepository : IRepository<int, Employee>
    {
        private readonly CompanyContext _context;

        public EmployeeRepository(CompanyContext context)
        {
            _context = context;
        }
        public Employee Add(Employee entity)
        {
            _context.employees.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Employee Delete(int key)
        {
            var employee = Get(key);
            if (employee != null)
            {
                _context.employees.Remove(employee);
                _context.SaveChanges();
                return employee;
            }
            return employee;
        }

        public Employee Get(int key)
        {
            var employee = _context.employees.FirstOrDefault(e => e.Id == key);
            return employee;
        }

        public ICollection<Employee> GetAll()
        {
            return _context.employees.ToList();
        }

        public Employee Update(Employee entity)
        {
            _context.Entry<Employee>(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }
    }
}
