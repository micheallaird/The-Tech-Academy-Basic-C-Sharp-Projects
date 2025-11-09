using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Math
    {
        // Takes one integer from the user and uses two additional pre-programmed integers
        public Math(int num1)
        {
            int num2 = 5;
            int num3 = 10;
            // Calls each method in turn, passing the user input to the method and displays returned integer to the console.
            // Tells the user what is happening with their input
            Console.WriteLine("Performing math operations on your numbers...");
            Console.WriteLine("Press Enter for first equation.");
            Console.ReadLine();
            // Calls the Add method
            int sum = Add(num1, num2, num3);
            Console.WriteLine($"The sum of {num1} and {num2} and {num3} is: {sum}");
            Console.WriteLine("Press Enter for second equation.");
            Console.ReadLine();
            // Calls the Subtract method
            int difference = Subtract(num1, num2, num3);
            Console.WriteLine($"The difference when {num2} and {num3} is subtracted from {num1} is: {difference}");
            Console.WriteLine("Press Enter for third equation.");
            Console.ReadLine();
            // Calls the Multiply method
            int product = Multiply(num1, num2, num3);
            Console.WriteLine($"The product of {num1}, {num2}, and {num3} is: {product}");
        }
        // The add method that takes the user inputted integer and adds it to two other integers
        private int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        // The subtract method that takes the user inputted integer and subtracts two other integers from it
        private int Subtract(int num1, int num2, int num3)
        {
            return num1 - num2 - num3;
        }
        // The multiply method that takes the user inputted integer and multiplies it by two other integers
        private int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
    }
}
