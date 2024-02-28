using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class Void
    {
        public void MathOps(int firstNumber, int secondNumber)
        {
            int squareResult = firstNumber * firstNumber;

            Console.WriteLine($"Square of (firstNumber): {squareResult}, Second Number: {secondNumber}");
        }
    }
}
