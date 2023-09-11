using FirstAPI.Models;
using FirstAPI.Models.DTOs;

namespace FirstAPI.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        List<Employee> GemEmployeesInASalaryRange(float min,float max);
        Employee AddANewEmployee(Employee employee);   
        Employee UpdateEmployeePhone(EmployeePhoneDTO employee);
        Employee UpdateEmployeeSalary(EmployeeSalaryDTO employee);
        Employee ToggleEmployeeStatus(int id);

    }
}
