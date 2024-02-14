using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Concatenate three strings
        Console.WriteLine("String Concatenation:");
        string firstString = "My name is";
        string secondString = "\nMy name is";
        string thirdString = "\nMy name is not slim shady!";
        string concatenatedString = firstString + " " + secondString + " " + thirdString;
        Console.WriteLine(concatenatedString);

        // Convert the third string to uppercase
        Console.WriteLine("\nUppercase Conversion:");
        string uppercaseThirdString = thirdString.ToUpper();
        Console.WriteLine(uppercaseThirdString);

        // StringBuilder and build a paragraph of text
        Console.WriteLine("\nStringBuilder Paragraph:");
        StringBuilder sb = new StringBuilder();

        // Build the paragraph by appending sentences
        sb.Append("Lorem ipsum dolor sit amet, consectetuer adipiscing elit.")
          .Append(" Maecenas porttitor congue massa.")
          .Append(" Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero,")
          .Append(" sit amet commodo magna eros quis urna.")
          .Append(" Nunc viverra imperdiet enim.")
          .Append(" Fusce est. Vivamus a tellus.")
          .Append(" Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.")
          .Append(" Proin pharetra nonummy pede.")
          .Append(" Mauris et orci. Aenean nec lorem.")
          .Append(" In porttitor. Donec laoreet nonummy augue.")
          .Append(" Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc.")
          .Append(" Mauris eget neque at sem venenatis eleifend.")
          .Append(" Ut nonummy.");

        // Print the built paragraph directly to the console using Console.Write
        Console.Write(sb);

        Console.ReadLine(); // Wait for user input before closing the console window
    }
}
