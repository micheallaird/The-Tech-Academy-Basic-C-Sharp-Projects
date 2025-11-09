using System;

namespace MethodClass
{
    // Creates a class with a void method that takes two integers as parameters.
    public class VoidMethodClass
    {
        public void AddAndDisplay(int firstNumber, int secondNumber)
        {
            int result = firstNumber + 10; // Example math operation on the first integer but does not use it further
            Console.WriteLine(secondNumber); // Displays the second integer
        }
    }
}
