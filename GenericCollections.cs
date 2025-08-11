using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMproject
{
    internal class GenericCollections
    {
        public List <int> numbers = new List<int>(); // generic list to hold integers
        public List<string> names = new List<string>(); // generic list to hold strings
        public List<Person> persons = new List<Person>(); // generic list to hold Person objects

        public void AddNumbers(int number)
        {
            numbers.Add(number); // adds an integer to the numbers list
        }

        public void AddName(string name)
        {
            names.Add(name); // adds a string to the names list
        }

        public void RemoveName(string name)
        {
            if (names.Contains(name))
            {
                names.Remove(name); // removes the specified name from the names list
                Console.WriteLine($"\nName '{name}' removed from the list.");
            }
            else
            {
                Console.WriteLine($"\nName '{name}' not found in the list.");
            }
        }

        public void AddPerson(Person person)
        {
            persons.Add(person); // adds a Person object to the persons list
        }

        public void DisplayNumbers()
        {
            Console.WriteLine("Numbers in the list:");
            foreach (var number in numbers)
            {
                Console.Write(number +"  "); // displays each number in the numbers list
            }
        }

        public void RemoveNumber(int number)
        {
            if (numbers.Contains(number))
            {
                numbers.Remove(number); // removes the specified number from the numbers list
                Console.WriteLine($"\nNumber {number} removed from the list.");
            }
            else
            {
                Console.WriteLine($"\nNumber {number} not found in the list.");
            }
        }

        public void ClearNumbers()
        {
            numbers.Clear(); // clears all numbers from the numbers list
            Console.WriteLine("\nAll numbers cleared from the list.");
        }

        public void DisplayNames() {    
            Console.WriteLine("\nNames in the list:");
            foreach (var name in names)
            {
                Console.Write(name + "  "); // displays each name in the names list
            }
        }
        public void DisplayPersons()
        {
            Console.WriteLine("\nPersons in the list:");
            foreach (var person in persons)
            {
                Console.WriteLine(person.GetPersonInfo()); // displays each Person's info in the persons list
            }
        }
        // generic list to hold Employee objects    
    }
}
