using MethodClass;
using System.Reflection;
class Program
{
    static void Main(string[] args)
    {
        // Instantiates the VoidMethodClass
        VoidMethodClass mathOps = new VoidMethodClass();
        // Calls the Void method with 2 integers as parameters
        mathOps.AddAndDisplay(firstNumber: 15, secondNumber: 20);
        // Keeps the console window open
        Console.ReadLine();
    }
}


