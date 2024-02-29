using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Class
{
    public class Void
    {
        // Method to divide a number by 2 and display the result
        public void MathOps(int number)
        {
            int result = number / 2;
            Console.WriteLine($"Result of dividing {number} by 2: {result}");
        }

        // Method with output parameters to calculate square and cube of a number
        public void CalculateSquareAndCube(int input, out int square, out int cube)
        {
            square = input * input;
            cube = input * input * input;
        }

        // Overloaded method for double input
        public void MathOps(double number)
        {
            double result = number / 2.0;
            Console.WriteLine($"Result of dividing {number} by 2: {result}");
        }
    }
}
