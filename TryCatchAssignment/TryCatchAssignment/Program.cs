using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{


    class Program
    {
        static void Main()
        {
            try
            {
                // Step 1: Ask the user for their age.
                Console.Write("Please enter your age: ");
                int age = int.Parse(Console.ReadLine());

                // Check if age is zero or negative
                if (age <= 0)
                {
                    throw new ArgumentException("Error: Age cannot be zero or negative.");
                }

                // Step 2: Calculate the year the user was born.
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;

                // Step 3: Display the year the user was born.
                Console.WriteLine($"You were born in the year {birthYear}.");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                // Handles the case when user inputs non-numeric characters.
                Console.WriteLine("Error: Please enter a valid age as a number.");
                Console.ReadLine(); // Wait for user to press Enter
            }
            catch (ArgumentException ex)
            {
                // Handles the case when user inputs zero or negative numbers.
                Console.WriteLine(ex.Message);
                Console.ReadLine(); // Wait for user to press Enter
            }
            catch (Exception ex)
            {
                // Handles any other unexpected exceptions.
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.ReadLine(); // Wait for user to press Enter
            }
        }
    }
}