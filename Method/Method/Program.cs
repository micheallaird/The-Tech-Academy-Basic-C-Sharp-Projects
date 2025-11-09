using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Substantiates the MathOperations class
            MathOperations mathOps = new MathOperations();
            // Prompts the user to enter two numbers
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);
            // Checks if the user wants to enter a second number
            Console.WriteLine("Enter the second number (or press Enter to skip): If you elect to skip entering a second number \"6\" will be used.");
            string input2 = Console.ReadLine();
            // Calls the AddNumbers method with one or two arguments based on user input
            int result;
            if (string.IsNullOrEmpty(input2))
            {
                result = mathOps.AddNumbers(number1);
            }
            else
            {
                int number2 = int.Parse(input2);
                result = mathOps.AddNumbers(number1, number2);
            }
            // Displays the result
            Console.WriteLine("The result is: " + result);
            // Waits for user input before closing
            Console.ReadLine();
        }
    }
}