namespace SyntaxSugarDemo;

class Program
{
    static void Main(string[] args)
    {
        // Explicit typing. Being explicit about the variable type
        int number = 10;
        string work;
        
        // Inferred typing
        var myVariable = 10; // the var makes it so the compiler will decide the type based on the value, in this case an integer
        
        // Inline if statement (aka the ternary operator)
        var age = 40;

        Console.WriteLine(age >= 18 ? "You're an adult!" : age < 5 ? "You're a child!" : "You're a minor!");
        
        // String interpolation vs. concatenation

        var middleInitial = "E";

        Console.WriteLine($"Aaron {middleInitial} Tanguma"); // string interpolation
        Console.WriteLine("Aaron" + " " + middleInitial + " " + "Tangum");
    }
}