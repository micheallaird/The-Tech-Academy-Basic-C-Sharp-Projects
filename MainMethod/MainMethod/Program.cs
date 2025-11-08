using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a class called MathOperations
            MathOperations mathOps = new MathOperations();
            int intResult = mathOps.Calculate(10);
            // Takes an integer and creates a math operation and returns the answer as an integer through the method.
            Console.WriteLine($"Integer result: {intResult}");
            int decimalResult = mathOps.Calculate(10.5m);
            // Takes a decimal and creates a different math operation and returns the answer as an integer through the method.
            Console.WriteLine($"Decimal result: {decimalResult}");
            int stringResult = mathOps.Calculate("20");
            // Takes a string that is a number, converts it to an integer if possible, and creates a different math operation and returns the answer as an integer through the method.
            Console.WriteLine($"String result: {stringResult}");
            // Waits for user input before closing the console window.
            Console.ReadLine();
        }
    }
}