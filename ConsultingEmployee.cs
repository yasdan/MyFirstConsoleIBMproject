using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMproject
{
    internal class ConsultingEmployee : Employee
    {
        public string? ConsultingFirm { get; set; } //nullable

        public int ContractDuration { get; set; } //in months

        public ConsultingEmployee() { }

        public ConsultingEmployee(int id, int employeeId, string name, string city, int age, string role, string email, double salary, string consultingFirm, int contractDuration)
            : base(id, employeeId, name, city, age, role, email, salary)
        {
            ConsultingFirm = consultingFirm;
            ContractDuration = contractDuration;
        }

        public void DisplayConsultingEmployeeDetails()
        {
            DisplayEmployeeDetails();
            Console.WriteLine($"Consulting Firm: {ConsultingFirm}");
            Console.WriteLine($"Contract Duration: {ContractDuration} months");
        }
    }
}
