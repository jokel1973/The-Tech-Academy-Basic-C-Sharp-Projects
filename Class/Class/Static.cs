using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public static class Static
    {
        // Static method that outputs an integer by dividing the data passed to it by 2
        public static void MathOps(int number)
        {
            int result = number / 2 ;
            Console.WriteLine($"Result of dividing {number} by 2 (Static): {result}");
        }
    }
}
