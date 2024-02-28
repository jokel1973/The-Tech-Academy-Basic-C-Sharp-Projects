using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMultiply
{
    public class Multiply
    {
        public int MultiplyNumbers(int firstNumber, int secondNumber = 1) //Method to multiply 2 numbers, if only one is provided, the second defaults to 1
        {
            int result = firstNumber * secondNumber;
            return result;
        }
    }
}
