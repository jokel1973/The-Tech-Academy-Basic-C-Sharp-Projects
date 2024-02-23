using System;

class Program
{
    static void Main()
    {
        // Initialize an array of strings
        string[] stringArray = { "Erik", "Jesse", "Daniel" };

        // Ask the user to input some text
        Console.Write("Enter your first name: ");
        string userInput = Console.ReadLine();

        // Loop to update each string in the array by appending user's text
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] += userInput;
        }

        // Loop to print each updated string in the array
        Console.WriteLine("\nUpdated Strings:");
        foreach (string str in stringArray)
        {
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}

