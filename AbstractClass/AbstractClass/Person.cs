using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        // Properties of the Person class
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method to be implemented by derived classes
        public abstract void SayName();
    }

}
