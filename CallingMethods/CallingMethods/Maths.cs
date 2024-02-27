using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Maths
    {// Method to double the input integer.
        public int DoubleNumber(int number)
        {
            return number * 2;
        }

        // Method to square the input integer.
        public int SquareNumber(int number)
        {
            return number * number;
        }

        // Method to calculate the factorial of the input integer.
        public int Factorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;

            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}