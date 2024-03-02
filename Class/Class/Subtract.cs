using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public static class Minus
    {
        // Static method that outputs an integer by dividing the data passed to it by 2
        public static void MathOp(int number)
        {
            int result = number - 2;
            Console.WriteLine($"Result of subtracting {number} by 2 (minus): {result}");
        }
    }
}