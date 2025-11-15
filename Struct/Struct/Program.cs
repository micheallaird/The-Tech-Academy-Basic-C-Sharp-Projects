// Struct Assignment
using System;
struct Number
{
    // Gives the Number struct a property named Amount and has it be of data type decimal
    public decimal Amount { get; set; }
    // Creates an object of data type Number and assigns the amount 5.75 to it
    public static void Main()
    {
        Number number = new Number();
        number.Amount = 5.75m;
        // Prints the value of Amount to the console
        Console.WriteLine(number.Amount);
        // Waits for user input before closing the console window
        Console.ReadLine();
    }
}