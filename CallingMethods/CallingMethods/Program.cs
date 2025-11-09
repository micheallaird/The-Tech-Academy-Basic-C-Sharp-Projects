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
            // Asks the user for a number to use in the methods
            Console.WriteLine("Please enter an integer:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            // Instantiates the Math class, passing the user input to the constructor
            Math mathOperations = new Math(userInput);
            // Adds ReadLine to prevent the console from closing
            Console.ReadLine();
        }
    }
}