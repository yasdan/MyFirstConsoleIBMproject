using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMproject
{
    internal class Employee : Person
    {
        public int EmployeeId { get; set; } 

        public string? Role { get; set; }  //nullable 

        public string? Email { get; set; }

        public double Salary { get; set; }


        public Employee() { }

        public Employee(int id,int employeeId, string name, string city, int age, string role, string email, double salary)
            : base(id, name, city, age)
        {
            EmployeeId = employeeId;
            Role = role;
            Email = email;
            Salary = salary;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
