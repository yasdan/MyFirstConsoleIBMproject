using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMproject
{
    internal class TechnoPrenure : Person, IEntroprenur
    {
        public TechnoPrenure() {
            BusinessName = "Unknown";
            BusinessType = "Unknown";
            InvestmentAmount = 0.0;
            YearsInBusiness = 0;
        }
        public TechnoPrenure(int id, string name, string city, int age,
            int entroprenurId, string businessName, string businessType, double investmentAmount, int yearsInBusiness)
            : base(id, name, city, age)
        {
            EntroprenurId = entroprenurId;
            BusinessName = businessName;
            BusinessType = businessType;
            InvestmentAmount = investmentAmount;
            YearsInBusiness = yearsInBusiness;
        }

        // Properties for Entroprenur class
        public int EntroprenurId { get; set; }
        public string? BusinessName { get; set; }
        public string? BusinessType { get; set; }
        public double InvestmentAmount { get; set; }
        public int YearsInBusiness { get; set; }

        public void DisplayEntroprenurDetails()
        {
            Console.WriteLine($"Entrepreneur ID: {EntroprenurId}");
            Console.WriteLine($"Business Name: {BusinessName}");
            Console.WriteLine($"Business Type: {BusinessType}");
            Console.WriteLine($"Investment Amount: {InvestmentAmount:C}");
            Console.WriteLine($"Years in Business: {YearsInBusiness}");
            base.DisplayPersonDetails(); // Call the base class method to display person details
        }

        public string GetEntroprenurInfo()
        {
            return $"Entrepreneur ID: {EntroprenurId}, Business Name: {BusinessName}, Business Type: {BusinessType}, " +
                   $"Investment Amount: {InvestmentAmount:C}, Years in Business: {YearsInBusiness}, " +
                   base.GetPersonInfo(); // Call the base class method to get person info
        }

    }
}
