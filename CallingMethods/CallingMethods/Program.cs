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
            // Asks the user what single number they want to do the math operations on
            Console.WriteLine("Enter the number to use in the math equation:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            // Performs the equation using the user's number and two additional pre-programmed numbers
            Math math = new Math(num1, 5, 10); 
            Console.ReadLine();
        }
    }
}