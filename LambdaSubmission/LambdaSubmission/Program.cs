using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of at least 10 employees
            List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "John", LastName = "Doe" },
            new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" },
            new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
            new Employee { Id = 4, FirstName = "Bob", LastName = "Williams" },
            new Employee { Id = 5, FirstName = "Alice", LastName = "Jones" },
            new Employee { Id = 6, FirstName = "Joe", LastName = "Brown" },
            new Employee { Id = 7, FirstName = "Charlie", LastName = "Miller" },
            new Employee { Id = 8, FirstName = "David", LastName = "Davis" },
            new Employee { Id = 9, FirstName = "Eva", LastName = "Evans" },
            new Employee { Id = 10, FirstName = "Frank", LastName = "Franklin" }
        };

            // Using a foreach loop, create a new list of all employees with the first name “Joe”
            List<Employee> joesUsingForeach = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joesUsingForeach.Add(employee);
                }
            }

            Console.WriteLine("Employees with the first name 'Joe' using foreach:");
            foreach (Employee joe in joesUsingForeach)
            {
                Console.WriteLine($"{joe.Id} {joe.FirstName} {joe.LastName}");
            }
            Console.WriteLine();

            // Using a lambda expression, create a new list of all employees with the first name “Joe”
            List<Employee> joesUsingLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            Console.WriteLine("Employees with the first name 'Joe' using lambda expression:");
            foreach (Employee joe in joesUsingLambda)
            {
                Console.WriteLine($"{joe.Id} {joe.FirstName} {joe.LastName}");
            }
            Console.WriteLine();

            // Using a lambda expression, make a list of all employees with an Id number greater than 5
            List<Employee> idGreaterThan5 = employees.Where(e => e.Id > 5).ToList();

            Console.WriteLine("Employees with Id greater than 5 using lambda expression:");
            foreach (Employee emp in idGreaterThan5)
            {
                Console.WriteLine($"{emp.Id} {emp.FirstName} {emp.LastName}");
            }

            // Keep the console window open until a key is pressed
            Console.ReadKey();
        }
    }
}
