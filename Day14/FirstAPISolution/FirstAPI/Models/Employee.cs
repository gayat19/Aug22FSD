﻿namespace FirstAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string? Phone { get; set; }
        public float Salary { get; set; }
        public bool? IsActive { get; set; }
    }
}
