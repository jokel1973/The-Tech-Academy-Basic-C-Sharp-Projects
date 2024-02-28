using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMultiply

{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Multiply class
            Multiply multiplyInstance = new Multiply();

            Console.Write("Enter the first number: "); // Requests user input
            if (int.TryParse(Console.ReadLine(), out int firstNumber))
            {
                Console.Write("Enter the second number (or press Enter to skip): "); // Requests second input from user, or Enter to skip input
                
                int secondNumber;// Read the second number (it's optional, so the user can press Enter to skip)
                int.TryParse(Console.ReadLine(), out secondNumber);

                int result = multiplyInstance.MultiplyNumbers(firstNumber, secondNumber == 0 ? 1 : secondNumber); // Calls the MultiplyNumbers method with the entered numbers and defaults to 1 if no number is entered

                Console.WriteLine($"Result of multiplication: {result}"); // Display the result
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }

            Console.ReadLine(); // Wait for user input before closing the console window
        }
    }
}
