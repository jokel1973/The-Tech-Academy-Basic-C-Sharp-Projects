using System;

class Program
{
    static void Main()
    {
        // Print the program title
        Console.WriteLine("Car Insurance Approval Program");

        // Ask the applicant's age
        Console.Write("What is your age? ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Ask if the applicant has ever had a DUI
        Console.Write("Have you ever had a DUI? (true/false) ");
        bool hasDUI = Convert.ToBoolean(Console.ReadLine());

        // Ask how many speeding tickets the applicant has
        Console.Write("How many speeding tickets do you have? ");
        int speedingTickets = Convert.ToInt32(Console.ReadLine());

        // Check qualification rules, use ! (not) to flip values for DUI
        bool isOver15 = age > 15;
        bool noDUI = !hasDUI;
        bool notMoreThan3Tickets = speedingTickets <= 3;

        // Check if the applicant qualifies
        bool isQualified = isOver15 && noDUI && notMoreThan3Tickets;

        // Print the result
        Console.WriteLine($"Qualified? {isQualified}");

        Console.ReadLine();
    }
}
