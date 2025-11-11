using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class contains a method that divides an integer by 2 and outputs the result
namespace ClassSubmission
{
    internal class Class1
    {
        public void DivideAndOutput(int data)
        {
            // Outputs the original integer and the result after division
            Console.WriteLine("Original integer: " + data);
            int result = data / 2;
            Console.WriteLine("Result after dividing by 2: " + result);
        }
        // Creates a method with output parameters
        public void OutputMessage()
        {
            Console.WriteLine("This is a message from Class1.");
        }
        // Overloads the DivideAndOutput method to accept a double parameter
        public void DivideAndOutput(double data)
        {
            // Outputs the original double and the result after division
            Console.WriteLine("Original double: " + data);
            double result = data / 2;
            Console.WriteLine("Result after dividing by 2: " + result);
        }
    }
}
