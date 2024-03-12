using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Example
{
    static void Main()
    {
        // Create a const variable.
        const int myConstVariable = 10;

        // Create a variable using the keyword "var."
        var myVarVariable = "Hello, Var!";

        // Chain two constructors together.
        var chainedConstructorsExample = new ChainedConstructorsExample("John Doe");

        // Output values to the console for demonstration.
        Console.WriteLine("Const Variable: " + myConstVariable);
        Console.WriteLine("Var Variable: " + myVarVariable);
        Console.WriteLine("Chained Constructors Example Name: " + chainedConstructorsExample.Name);
        Console.ReadLine();
    }
}

class ChainedConstructorsExample
{
    public string Name { get; }

    // Constructor with parameter
    public ChainedConstructorsExample(string name)
        : this(name, "DefaultDepartment") // Chaining to another constructor
    {
    }

    // Constructor with two parameters
    public ChainedConstructorsExample(string name, string department)
    {
        Name = name;
        // Additional initialization logic can be added here if needed

    }
    
}



