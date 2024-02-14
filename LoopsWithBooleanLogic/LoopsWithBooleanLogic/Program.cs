using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my name? A hint: it's 4 letters and begins with E.");
            string name = Console.ReadLine().ToLower(); //stores user input, allows upper or lower case entries
            bool isGuessed = name == "erik";

             Console.WriteLine("Try at least 3 more times");
            int whileCounter = 0; // Counter variable

            // While the counter is less than 3, execute the loop
            while (whileCounter < 3)
            {
                Console.WriteLine($"GO! {whileCounter + 1}");
                whileCounter++; // Increment the counter
            }

            do //begins do while loop
            {
                switch (name) //Switch statement
                {
                    case "eddy": //first case to check
                        Console.WriteLine("You guessed Eddy. Try again.");
                        Console.WriteLine("Guess again?");
                        name = Console.ReadLine().ToLower(); 
                        break;
                    case "erin"://second case to check
                        Console.WriteLine("You guessed Erin. Try again.");
                        Console.WriteLine("Guess again?");
                        name = Console.ReadLine().ToLower(); 
                        break;
                    case "echo"://third case to check
                        Console.WriteLine("You guessed Echo. Try again.");
                        Console.WriteLine("Guess again?");
                        name = Console.ReadLine().ToLower(); 
                        break;
                    case "erik"://final case to check
                        Console.WriteLine("You guessed Erik. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess my name?");
                        name = Console.ReadLine().ToLower(); 
                        break;
                }
            }
            while (!isGuessed);

            Console.ReadLine();
        }
    }
}

