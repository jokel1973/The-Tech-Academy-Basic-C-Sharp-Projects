using System;



using System;

class Program
{
    static void Main()
    {
        // Print the starting message
        Console.WriteLine("Code Academy");
        Console.WriteLine("Student Daily Report");

        // Declare variables to store user input
        string name, course, positiveExperiences, additionalFeedback;
        int pageNumber, studyHours;
        bool needHelp;

        // Ask and save user data
        Console.Write("What is your name? ");
        name = Console.ReadLine();

        Console.Write("What course are you on? ");
        course = Console.ReadLine();

        Console.Write("What page number? ");
        // Use direct casting to int
        pageNumber = (int)Convert.ChangeType(Console.ReadLine(), typeof(int));

        Console.Write("Do you need help with anything? (true/false) ");
        // Use direct casting to bool
        needHelp = (bool)Convert.ChangeType(Console.ReadLine(), typeof(bool));

        Console.Write("Were there any positive experiences you’d like to share? Please give specifics. ");
        positiveExperiences = Console.ReadLine();

        Console.Write("Is there any other feedback you’d like to provide? Please be specific. ");
        additionalFeedback = Console.ReadLine();

        Console.Write("How many hours did you study today? ");
        // Use direct casting to int
        studyHours = (int)Convert.ChangeType(Console.ReadLine(), typeof(int));

        // Print the closing message
        Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();
    }
}
