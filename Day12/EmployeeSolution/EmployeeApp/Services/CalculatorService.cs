using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Services
{
    public class CalculatorService
    {
        public int Add(int num1,int num2)
        {
            return (num1+num2);
        }
        public int Product(int num1, int num2)
        {
            return (num1 * num2);
        }
        public int Divide(int num1, int num2)
        {
            return (num1 / num2);
        }
        public int Subract(int num1, int num2)
        {
            return (num1 - num2);
        }

    }
}
