using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        // Print the current date and time to the console.
        DateTime currentDateTime = DateTime.Now;
        Console.WriteLine("Current Date and Time: " + currentDateTime);

        // Ask the user for a number.
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine();

        // Convert the user input to an integer.
        if (int.TryParse(userInput, out int hoursToAdd))
        {
            // Calculate the future date and time based on the user input.
            DateTime futureDateTime = currentDateTime.AddHours(hoursToAdd);

            // Print to the console the exact time it will be in X hours.
            Console.WriteLine($"In {hoursToAdd} hours, it will be: {futureDateTime}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        Console.ReadLine();
    }
}
