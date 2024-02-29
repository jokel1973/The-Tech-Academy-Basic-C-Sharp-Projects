using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee
            {
                FirstName = "Sample",   // Set the first name to "Sample"
                LastName = "Student",   // Set the last name to "Student"
                Id = 1                  // Set the Id to 1
            };

            // Call the superclass method SayName() on the Employee object
            employee.SayName();

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }

}
