using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Prompt the user to enter the current day of the week
                Console.Write("Enter the current day of the week: ");
                string userInput = Console.ReadLine();

                // Convert the user input to the enum type (DayOfWeekEnum)
                DayOfWeekEnum currentDay;

                // Parsing the user input to the enum type, ignoring case
                if (!Enum.TryParse(userInput, true, out currentDay))
                {
                    throw new ArgumentException("Invalid day of the week");
                }

                // Print the entered day of the week
                Console.WriteLine($"You entered: {currentDay}");
            }
            catch (ArgumentException ex)
            {
                // Catching an ArgumentException if there is an error in user input
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                // Optional: Code that will always run, whether an exception occurred or not
                Console.WriteLine("Please close the program and run again.");
            }

            // Keep the console window open until a key is pressed
            Console.ReadKey();
        }
    }
}
