using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        // Implementation of the SayName method for Employee
        public override void SayName()
        {
            Console.WriteLine($"Employee Name: {FirstName} {LastName}");
        }
        // Implementation of the Quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"Employee {FirstName} {LastName} has quit.");
        }
    }
}