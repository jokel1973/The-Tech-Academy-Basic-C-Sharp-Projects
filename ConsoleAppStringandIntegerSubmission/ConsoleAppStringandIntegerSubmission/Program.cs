using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            // Step 1: Create a list of integers
            List<int> integerList = new List<int> { 10, 20, 30, 40, 50 };

            // Step 2: Ask the user for a number to divide each element in the list
            Console.Write("Enter a number to divide each element in the list by: ");

            // Step 3: Read the user input and convert it to an integer
            if (int.TryParse(Console.ReadLine(), out int divisor))
            {
                // Step 4: Loop to divide each integer in the list and display the result
                Console.WriteLine("\nResults after division:");

                foreach (int number in integerList)
                {
                    // Step 5: Try to perform the division
                    try
                    {
                        int result = number / divisor; // Ensure result is a decimal by using (double)
                        Console.WriteLine($"{number} / {divisor} = {result}");
                    }
                    // Step 6: Catch and handle exceptions related to division by zero or invalid input
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine($"Error: Cannot divide by zero.");
                        //return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred outside the loop: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Program has emerged from the try/catch block and continued with program execution.");
        }

        Console.ReadLine(); // Keeps the console window open
    }
}


