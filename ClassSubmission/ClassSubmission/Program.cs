using System;
namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates Class1 and calls the method
            Class1 program = new Class1();
            // Asks the user for an integer input
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            program.DivideAndOutput(number);
            // Calls the overloaded method with a double parameter
            Console.Write("Enter a double: ");
            double doubleNumber = Convert.ToDouble(Console.ReadLine());
            program.DivideAndOutput(doubleNumber);
            // Calls the OutputMessage method
            program.OutputMessage();
            // Calls the static method from Class2 without instantiating it
            Class2.StaticMethod();
        }
    }
}