using System;

class Program
{
    static void Main()
    {
        // Task 1: Multiply user input by 50
        Console.Write("Enter a number: ");
        double userInput1 = Convert.ToDouble(Console.ReadLine());
        double result1 = userInput1 * 50;
        Console.WriteLine($"Result 1: {result1}");

        // Task 2: Add 25 to user input
        Console.Write("Enter another number: ");
        double userInput2 = Convert.ToDouble(Console.ReadLine());
        double result2 = userInput2 + 25;
        Console.WriteLine($"Result 2: {result2}");

        // Task 3: Divide user input by 12.5
        Console.Write("Enter a third number: ");
        double userInput3 = Convert.ToDouble(Console.ReadLine());
        double result3 = userInput3 / 12.5;
        Console.WriteLine($"Result 3: {result3}");

        // Task 4: Check if user input is greater than 50
        Console.Write("Enter a number to check if it's greater than 50: ");
        double userInput4 = Convert.ToDouble(Console.ReadLine());
        bool isGreaterThan50 = userInput4 > 50;
        Console.WriteLine($"Result 4: {isGreaterThan50}");

        // Task 5: Divide user input by 7 and print the remainder
        Console.Write("Enter a number for remainder calculation: ");
        double userInput5 = Convert.ToDouble(Console.ReadLine());
        double remainder = userInput5 % 7;
        Console.WriteLine($"Result 5: {remainder}");
        Console.ReadLine();
    }
}
