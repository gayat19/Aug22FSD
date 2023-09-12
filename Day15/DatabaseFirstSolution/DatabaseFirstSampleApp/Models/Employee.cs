using System;
using System.Collections.Generic;

namespace DatabaseFirstSampleApp.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string? Phone { get; set; }
        public float Salary { get; set; }
        public bool? IsActive { get; set; }
    }
}
