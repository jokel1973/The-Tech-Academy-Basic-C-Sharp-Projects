using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main()
        {
            // Create and initialize an object of data type Number
            Number myNumber = new Number();

            // Assign an amount (decimal value) to the Amount property of the struct
            myNumber.Amount = 123.45M;

            // Print the amount to the console
            Console.WriteLine($"Amount: {myNumber.Amount}");

            // Keep the console window open until a key is pressed
            Console.ReadKey();
        }
    }
}
