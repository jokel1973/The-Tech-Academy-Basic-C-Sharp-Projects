using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{

    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input.
            Console.Write("Enter a number: ");

            // Read the user input and convert it to an integer.
            int userInput;
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                // Create an instance of the MathOperations class.
                Maths mathOperations = new Maths();

                // Call the DoubleNumber method and display the result.
                int doubledNumber = mathOperations.DoubleNumber(userInput);
                Console.WriteLine($"Double of {userInput}: {doubledNumber}");

                // Call the SquareNumber method and display the result.
                int squaredNumber = mathOperations.SquareNumber(userInput);
                Console.WriteLine($"Square of {userInput}: {squaredNumber}");

                // Call the Factorial method and display the result.
                int factorialResult = mathOperations.Factorial(userInput);
                Console.WriteLine($"Factorial of {userInput}: {factorialResult}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Wait for user input before closing the console window.
            Console.ReadLine();
        }
    }
}
