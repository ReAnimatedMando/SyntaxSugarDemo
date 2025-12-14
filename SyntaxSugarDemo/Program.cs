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
        
    }
}