using FirstAPI.Interfaces;
using FirstAPI.Models;

namespace FirstAPI.Repositories
{
    public class EmployeeRepository : IRepository<int, Employee>
    {
        private readonly CompanyContext _context;

        public EmployeeRepository(CompanyContext context)
        {
            _context = context;
        }
        public Employee Add(Employee item)
        {
            _context.employees.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Employee Delete(int key)
        {
            var employee = Get(key);
            if(employee != null)
            {
                _context.employees.Remove(employee);
                _context.SaveChanges();
                return employee;
            }
            return null;
        }

        public Employee Get(int key)
        {
            var employee = _context.employees.FirstOrDefault(emp=>emp.Id== key);
            return employee;
        }

        public List<Employee> GetAll()
        {
            return _context.employees.ToList();
        }

        public Employee Update(Employee item)
        {
            _context.Entry<Employee>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return item;
        }
    }
}
