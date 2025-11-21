// Try Catch Assignment
using System;
class Program
{
    static void Main()
    {
        // Asks user for their age
        Console.Write("Enter your age: ");
        string? input = Console.ReadLine();

        try
        {
            // Calculates and displays the user's birth year
            if (int.TryParse(input, out int age) && age > 0)
            {
                int birthYear = DateTime.Now.Year - age;
                Console.WriteLine($"You were born in {birthYear}.");
            }
            // Handles invalid input
            else if (!int.TryParse(input, out _))
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
            // Handles negative or zero age
            else
            {
                Console.WriteLine("Age must be a positive number.");
            }
        }
        // Catches any unexpected exceptions
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        // Final message
        Console.WriteLine("Thank you for using the age calculator.");
        Console.ReadLine();
    }

}