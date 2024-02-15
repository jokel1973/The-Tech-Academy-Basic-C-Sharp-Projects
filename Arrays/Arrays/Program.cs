using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a one-dimensional Array of strings
        Console.WriteLine("Array of Strings Example:");
        string[] stringArray = { "Apple", "Banana", "Orange", "Grapes" };

        // Ask the user to select an index and display the string at that index
        Console.Write("Enter an index, 0-3, to retrieve a string from the array: ");
        if (int.TryParse(Console.ReadLine(), out int stringIndex) && stringIndex >= 0 && stringIndex < stringArray.Length)
        {
            Console.WriteLine($"String at index {stringIndex}: {stringArray[stringIndex]}");
        }
        else
        {
            Console.WriteLine("Please choose an Index number 0-3.");
        }

        // Create a one-dimensional Array of integers
        Console.WriteLine("\nArray of Integers Example:");
        int[] intArray = { 10, 20, 30, 40, 50 };

        // Ask the user to select an index and display the integer at that index
        Console.Write("Enter an index numbewr 0-4, to retrieve an integer from the array: ");
        if (int.TryParse(Console.ReadLine(), out int intIndex) && intIndex >= 0 && intIndex < intArray.Length)
        {
            Console.WriteLine($"Integer at index {intIndex}: {intArray[intIndex]}");
        }
        else
        {
            Console.WriteLine("Please choose an Index number 0-4.");
        }

        // Create a list of strings
        Console.WriteLine("\nList of Strings Example:");
        List<string> stringList = new List<string> { "Red", "Green", "Blue", "Yellow" };

        // Ask the user to select an index and display the content at that index
        Console.Write("Enter an index number, 0-3, to retrieve a string from the list: ");
        if (int.TryParse(Console.ReadLine(), out int listIndex) && listIndex >= 0 && listIndex < stringList.Count)
        {
            Console.WriteLine($"String at index {listIndex}: {stringList[listIndex]}");
        }
        else
        {
            Console.WriteLine("Please choose an Index number 0-3.");
        }
        Console.WriteLine();
        Console.ReadLine(); // Wait for user input before closing the console window
    }
}
