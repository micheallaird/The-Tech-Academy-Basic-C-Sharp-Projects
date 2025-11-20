using System;

// Creates a const variable 
const int myConst = 10;
// Creates a variable using 'var' keyword
var myVar = "Hello, World!";
// Outputs the values to the console
Console.WriteLine($"Const: {myConst}, Var: {myVar}");
// Chains two constructors together
var myObject = new MyClass();
// Outputs a message to the console
Console.WriteLine("MyClass instance created.");
// Defines the MyClass with constructor chaining
class MyClass
{
    public MyClass() : this("Default Value")
    {
        // Outputs a message indicating the parameterless constructor was called
        Console.WriteLine("Parameterless constructor called.");
    }
    public MyClass(string value)
    {
        // Outputs the value passed to the constructor
        Console.WriteLine($"Constructor with parameter called. Value: {value}");
        // Keeps the program running to observe output
        Console.ReadLine();
    }
}