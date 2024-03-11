using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Ask the user for a number
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            // Log the number to a text file
            LogNumberToFile(userInput);

            // Read and print the contents of the text file
            string fileContents = ReadFileContents();
            Console.WriteLine($"Contents of the text file: {fileContents}");
        }
        catch (Exception ex)
        {
            // Handle any exceptions that might occur
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        // Keep the console window open until a key is pressed
        Console.ReadKey();
    }

    static void LogNumberToFile(string number)
    {
        // Specify the path of the text file
        string filePath= "log.txt";

        // Write the number to the text file or create a new file if it doesn't exist
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(number);
        }
    }

    static string ReadFileContents()
    {
        // Specify the path of the text file
        string filePath = "log.txt";

        // Read the contents of the text file
        string fileContents = File.ReadAllText(filePath);

        return fileContents;
    }
}