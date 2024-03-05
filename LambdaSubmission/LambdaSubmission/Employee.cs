using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    public class Employee
    {
        // Properties of the Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the == operator to compare Employee IDs
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1?.Id == employee2?.Id;
        }

        // Overload the != operator to compare Employee IDs
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }
}
