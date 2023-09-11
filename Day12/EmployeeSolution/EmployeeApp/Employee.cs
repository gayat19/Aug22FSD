using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override bool Equals(object? obj)
        {
            Employee emp1, emp2;
            emp1 = this;
            emp2 = obj as Employee;
            if(emp1.Name==emp2.Name && emp1.Id==emp2.Id)
                return true;
            return false;
        }
    }
}
