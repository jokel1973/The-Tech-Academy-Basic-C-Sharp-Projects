using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // Instantiate the Void class
        Class.Void voidInstance = new Class.Void();

        // Ask the user to enter a number
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            // Call the MathOps method with the user-entered number
            voidInstance.MathOps(userInput);

            // Call the MathOps method from the Static class
            Class.Minus.MathOp(userInput);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        // Method with output parameters
        int inputNumber = 5;
        int squareResult, cubeResult;

        // Call the method with output parameters
        voidInstance.CalculateSquareAndCube(inputNumber, out squareResult, out cubeResult);

        // Display the results
        Console.WriteLine($"Square of {inputNumber}: {squareResult}");
        Console.WriteLine($"Cube of {inputNumber}: {cubeResult}");

        // Overloaded method for double input
        double doubleInput = 10.5;
        voidInstance.MathOps(doubleInput);

        

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}
