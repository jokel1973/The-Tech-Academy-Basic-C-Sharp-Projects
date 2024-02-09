using System;

class Program
{
    static void Main()
    {
        // Print the program title
        Console.WriteLine("Anonymous Income Comparison Program");

        // Person 1 details
        Console.WriteLine("Person 1");

        // Get hourly rate from user input
        Console.Write("Enter hourly rate for Person 1: ");
        double hourlyRatePerson1 = Convert.ToDouble(Console.ReadLine());

        // Get hours worked per week from user input
        Console.Write("Enter hours worked per week for Person 1: ");
        double hoursWorkedPerWeekPerson1 = Convert.ToDouble(Console.ReadLine());

        // Calculate annual salary for Person 1 (assuming 52 weeks in a year)
        double annualSalaryPerson1 = hourlyRatePerson1 * hoursWorkedPerWeekPerson1 * 52;

        // Print annual salary for Person 1
        Console.WriteLine($"Annual salary of Person 1: {annualSalaryPerson1:C}");

        // Person 2 details
        Console.WriteLine("\nPerson 2");

        // Get hourly rate from user input
        Console.Write("Enter hourly rate for Person 2: ");
        double hourlyRatePerson2 = Convert.ToDouble(Console.ReadLine());

        // Get hours worked per week from user input
        Console.Write("Enter hours worked per week for Person 2: ");
        double hoursWorkedPerWeekPerson2 = Convert.ToDouble(Console.ReadLine());

        // Calculate annual salary for Person 2 (assuming 52 weeks in a year)
        double annualSalaryPerson2 = hourlyRatePerson2 * hoursWorkedPerWeekPerson2 * 52;

        // Print annual salary for Person 2
        Console.WriteLine($"Annual salary of Person 2: {annualSalaryPerson2:C}");

        // Compare salaries and print the result
        Console.WriteLine($"\nDoes Person 1 make more money than Person 2? {annualSalaryPerson1 > annualSalaryPerson2}");
        Console.ReadLine();
    }
}
