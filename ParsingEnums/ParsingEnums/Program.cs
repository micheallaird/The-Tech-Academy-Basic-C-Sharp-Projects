//Parsing Enums Submission Assignment
using System;
namespace ParsingEnums
{
    // Define an enumeration for days of the week
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a day of the week
            Console.WriteLine("Enter a day of the week:");
            string input = Console.ReadLine();
            // Try to parse the input string to the DaysOfWeek enum
            try
            {
                if (Enum.TryParse(input, true, out DaysOfWeek day))
                {
                    Console.WriteLine($"You entered: {day}");
                }
                else
                {
                    throw new ArgumentException("Invalid day");
                }
            }
            catch
            {
                // Handle invalid input
                Console.WriteLine("Please enter an actual day of the week.");
            }
            // Wait for user input before closing
            Console.ReadLine();
        }
    }
}