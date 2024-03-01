using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // Main program class
    class Program
    {
        static void Main()
        {
            // Instantiate an Employee object with firstName "Sample" and lastName "Student"
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call the SayName() method on the Employee object
            employee.SayName();

            // Keep the console window open until a key is pressed
            Console.ReadKey();
        }
    }
}
