using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the Void class
            Void voidInstance = new Void();

            // Call the MathOps method with two integers
            voidInstance.MathOps(3, 7);

            // Call the MathOps method with parameters specified by name
            voidInstance.MathOps(firstNumber: 5, secondNumber: 10);


            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
