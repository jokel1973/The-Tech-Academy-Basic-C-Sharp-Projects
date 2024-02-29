using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjects
{
    public class Person
    {
        // Property to represent the first name of the person
        public string FirstName { get; set; }

        // Property to represent the last name of the person
        public string LastName { get; set; }

        // Method to write the person's full name to the console
        public void SayName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
            
        }
    }
}
