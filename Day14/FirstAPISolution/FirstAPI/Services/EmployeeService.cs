using FirstAPI.Interfaces;
using FirstAPI.Models;
using FirstAPI.Models.DTOs;

namespace FirstAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<int, Employee> _employeeRepository;

        public EmployeeService(IRepository<int,Employee> employeeRepo)
        {
            _employeeRepository = employeeRepo;
        }
        public Employee AddANewEmployee(Employee employee)
        {
            return _employeeRepository.Add(employee);
        }

        public List<Employee> GemEmployeesInASalaryRange(float min, float max)
        {
            var employees = _employeeRepository.GetAll().Where(emp=>emp.Salary>=min && emp.Salary<=max);
            if(employees.Count() > 0)
            {
                return employees.ToList();
            }
            return null;
        }

        public List<Employee> GetAllEmployees()
        {
           return _employeeRepository.GetAll();
        }

        public Employee ToggleEmployeeStatus(int id)
        {
            var employee = _employeeRepository.Get(id);
            if (employee!=null)
            {
                if (employee.IsActive == null)
                {
                    employee.IsActive = false;
                }
                employee.IsActive = !employee.IsActive;
                return _employeeRepository.Update(employee);
            }
            return null;
        }

        public Employee UpdateEmployeePhone(EmployeePhoneDTO employee)
        {
            var myemployee = _employeeRepository.Get(employee.Id);
            if (myemployee != null)
            {
                myemployee.Phone = employee.Phone;
                return _employeeRepository.Update(myemployee);
            }
            return null;
        }

        public Employee UpdateEmployeeSalary(EmployeeSalaryDTO employee)
        {
            var myemployee = _employeeRepository.Get(employee.Id);
            if (myemployee != null)
            {
                myemployee.Salary = employee.Salary;
                return _employeeRepository.Update(myemployee);
            }
            return null;
        }
    }
}
