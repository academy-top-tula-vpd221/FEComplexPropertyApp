using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModrelCreateApp
{
    public class Employee
    {
        public Employee() { }
        public Employee(string name, int age, EmployeeProfile profile)
        {
            Name = name;
            Age = age; 
            Profile = profile;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }

        private EmployeeProfile? Profile { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Login{Profile?.Login}, Password: {Profile?.Password}";
        }
    }

    //[Owned]
    public class EmployeeProfile
    {
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
