using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CallingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks the user for three numbers to use in a math equation
            Console.WriteLine("Enter the first number to use in the math equation:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number to use in the math equation:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number to use in the math equation:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            // Performs the equation using the user's number and two additional pre-programmed numbers
            Math math = new Math(num1, num2, num3); 
            Console.ReadLine();
        }
    }
}