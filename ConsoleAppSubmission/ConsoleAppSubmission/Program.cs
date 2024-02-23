using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Step 1: One-dimensional array of strings
        string[] stringArray = { "First string", "Second string", "Third string" };

        // Step 2: Ask the user to input some text
        Console.Write("Enter text to append to each string: ");
        string userInput = Console.ReadLine();

        // Step 3: Loop to update each array element by appending user's text
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] += userInput;
        }

        // Loop to print each updated string in the array
        Console.WriteLine("\nUpdated strings in the array:");
        foreach (string str in stringArray)
        {
            Console.WriteLine(str);
        }

        // Infinite loop (commented out initially)
        //while (true)
        //{
        //    Console.WriteLine("This is an infinite loop!");
        //}
        // Loop with "less than" (<) operator
        Console.WriteLine("\nLoop with \"<\" operator:");
        for (int i = 1; i < stringArray.Length; i++)
        {
            Console.WriteLine(stringArray[i]);
        }

        // Loop with "less than or equal to" (<=) operator
        Console.WriteLine("\nLoop with \"<=\" operator:");
        for (int i = 1; i <= 1; i++)
        {
            Console.WriteLine(stringArray[i]);
        }

        // Step 4: List of strings with at least two identical strings
        List<string> identicalStringsList = new List<string> { "Apple", "Banana", "Orange", "Apple", "Grapes" };

        // Step 5: Ask the user to input text to search for in the list
        Console.Write("Enter a fruit to search for in the first list: ");
        string searchInput = Console.ReadLine().ToLower(); // Make the input case-insensitive

        // Step 6: Loop to iterate through the first list and display the indices of matching text
        bool foundMatch = false; // Flag to check if a match has been found

        for (int i = 0; i < identicalStringsList.Count; i++)
        {
            if (identicalStringsList[i].ToLower().Contains(searchInput))
            {
                Console.WriteLine($"Match found at index {i}: {identicalStringsList[i]}");
                foundMatch = true;
            }
        }

        // Step 7: Check if the user input is not on the first list
        if (!foundMatch)
        {
            Console.WriteLine("Your input is not on the first list.");
        }

        // Loop to print each updated string in the array
        Console.WriteLine("\nUpdated strings in the array:");
        foreach (string str in stringArray)
        {
            Console.WriteLine(str);
        }

        // Step 8: Create a new list of strings with at least two identical strings
        List<string> duplicateStringsList = new List<string> { "X", "Y", "Z", "Y", "W" };

        // Step 9: Create a dictionary to keep track of seen items in the second list
        Dictionary<string, bool> seenItemsSecondList = new Dictionary<string, bool>();

        // Step 10: Use a foreach loop to iterate through the second list
        foreach (string item in duplicateStringsList)
        {
            // Step 11: Check if the item has already appeared in the second list
            if (seenItemsSecondList.ContainsKey(item))
            {
                Console.WriteLine($"{item} - this item is a duplicate in the second list");
            }
            else
            {
                // Step 12: If the item is unique, add it to the dictionary for the second list
                seenItemsSecondList[item] = true;
                Console.WriteLine($"{item} - this item is unique in the second list");
            }
        }

        Console.ReadLine(); // Keeps the console window open
    }
}





