using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class MathOps
    {
        public int PerformMathOps(int number) //Method to perform a math operation on the user input
        {
            int result = number + 9; // Adds 9 or any other number you enter here to the user input

            return result; //gives the sum of the user input and the above operation
        }

        public int PerformMathOps(decimal number) // Second method with decimal
        {
            int result = (int)(number * 2);
            return result;
        }
        // Third method with a string parameter
        public int PerformMathOps(string input)
        {
            // Convert the string to an integer if possible, otherwise, return 0
            if (int.TryParse(input, out int number))
            {
                // Example: Subtracting 3 from the converted integer
                int result = number - 3;
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Cannot convert the string to an integer.");
                return 0; // Default value if conversion fails
            }
        }
    }
}

