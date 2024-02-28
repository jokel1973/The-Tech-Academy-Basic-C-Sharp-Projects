using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOps mathOperations = new MathOps(); // Creates the instance of the MathOps class

            Console.WriteLine("Enter a number: "); //Request for user input

            if (int.TryParse(Console.ReadLine(), out int userInput)) //Convert user input to integer if needed
            {
                int result = mathOperations.PerformMathOps(userInput); // Calls the method and with user input 

                Console.WriteLine("Result: " + result); // Prints to the screen
            }
            else
            {
                Console.WriteLine("Invalid intput. Please enter a valid interger.");
            }

            Console.WriteLine("Enter a decimal: "); //Request for user input
            if (decimal.TryParse(Console.ReadLine(), out decimal userInputDecimal)) //Convert user input to integer if needed
            {
                int resultDecimal = mathOperations.PerformMathOps(userInputDecimal); // Calls the method and with user input

                Console.WriteLine("Result (decimal): " + resultDecimal); // Prints to the screen
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal.");
            }

            Console.WriteLine("Enter a string representing an integer: "); // Prompt user to enter a string
            string userInputString = Console.ReadLine();

            // Call the third method for strings and display the result
            int resultString = mathOperations.PerformMathOps(userInputString);
            Console.WriteLine("Result (string to integer): " + resultString);

            Console.ReadLine(); // Holds the display for the user to read
        }
    }
}
