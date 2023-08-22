using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class ManageEmployee
    {
        public Employee CreateEmployeeByTakingDetailsFromConsole()
        {
            Employee employee = new Employee();
            Console.WriteLine("Please enter the employee ID");
            employee.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee Name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Please enter the employee Age");
            employee.Age = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter the employee Phone");
            employee.Phone = Console.ReadLine();
            Console.WriteLine("Please enter the employee Salary");
            employee.Salary = Convert.ToDouble(Console.ReadLine());
            return employee;
        }
        public void PrintEmployeeDetails(Employee employee)
        {
            Console.WriteLine("Employee Id :" + employee.Id);
            Console.WriteLine("Employee Name :" + employee.Name);
            Console.WriteLine($"Employee Age :  {employee.Age}");
            Console.WriteLine($"Employee Phone :  {employee.Phone}");
            Console.WriteLine($"Employee Salary :  ${employee.Salary}");
        }
    }
}
