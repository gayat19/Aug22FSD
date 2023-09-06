using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Services
{
    public class EmployeeService
    {
        public int CountFullTimeEmployees()
        {
            int num = new Random().Next(10, 30);
            return num;
        }
    }
}
