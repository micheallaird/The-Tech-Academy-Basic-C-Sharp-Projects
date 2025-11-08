using System;
using System.Collections.Generic;
using System.Threading.Tasks;
// Program placed inside a while loop to allow for multiple attempts
while (true)
{
    // Try block to catch exceptions
    try
    {
        // A list of integers
        List<int> numbers = new List<int>();
        // A loop that adds integers from 1 to 10 to the list
        for (int i = 1; i <= 10; i++)
        {
            numbers.Add(i);
        }
        // Asks the user for a number to divide each number in the list by
        Console.WriteLine("Enter a number to divide each number in the list by:");
        int divisor = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(
            $"Dividing each number in the list by {divisor}:"
        );
        Console.WriteLine();

        // A loop that takes each integer in the list
        foreach (int number in numbers)
        {
            int result = number / divisor;
            Console.WriteLine($"{number} divided by {divisor} is {result}");
        }
        Console.ReadLine();
        break; // Exit the while loop if successful
    }
    // Prints error if incorrect format is used
    catch (FormatException ex)
    {
        Console.WriteLine("Please type a whole number.");
        return;
    }
    // Prints error if division by zero is attempted
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Please don't divide by zero");
    }
    // Catches any other exceptions that may occur
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    // Ensures the program waits for user input before closing
    finally
    {
        Console.ReadLine();
    }
}