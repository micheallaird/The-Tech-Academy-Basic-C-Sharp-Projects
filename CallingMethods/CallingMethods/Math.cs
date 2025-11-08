using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Math
    {
        // Takes one integer from the user and two additional pre-programmed integers
        public Math(int num1, int num2, int num3)
        {
            // Performs addition, multiplication, and subtraction with the three numbers
            int addition = num1 + num2 + num3;
            int multiplication = num1 * num2 * num3;
            int subtraction = num1 - num2 - num3;
            // Tells the user what is happening with their input
            Console.WriteLine("The math equation took your input and used the numbers 5 and 10 in three different equations");
            // Displays the results of the math operations
            Console.WriteLine($"Addition: {addition}");
            Console.WriteLine($"Multiplication: {multiplication}");
            Console.WriteLine($"Subtraction: {subtraction}");
        }
    }
}
