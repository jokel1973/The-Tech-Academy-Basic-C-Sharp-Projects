using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        // Properties of the Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading the "==" operator to compare Employee objects based on their Id
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Check if both objects are null or if their Id properties are equal
            return ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null) ||
                   !ReferenceEquals(employee1, null) && !ReferenceEquals(employee2, null) && employee1.Id == employee2.Id;
        }

        // Overloading the "!=" operator as it must be overloaded in pairs
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            // Inverse of the equality operator
            return !(employee1 == employee2);
        }
    }
}
