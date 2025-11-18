// Prints the current date and time to the console.
using System;
class Program
{
    static void Main()
    {
        
        Console.WriteLine("Current Date and Time: " + DateTime.Now);
        // Asks the user for a number and prints to the console the exact time it will be in X hours. 
        // X being the number provide by the user.
        Console.Write("Enter number of hours to find out what time it will be in that number of hours: ");
        string input = Console.ReadLine();
        // Validate input and calculate future time
        if (int.TryParse(input, out int hours))
        {
            DateTime futureTime = DateTime.Now.AddHours(hours);
            // Display the future time
            Console.WriteLine($"The time in {hours} hours will be: {futureTime}");
        }
        // Handle invalid input
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        // Wait for user to acknowledge the result
        Console.WriteLine("Press any key to exit...");
        // Keep the console window open and clean until enter key is pressed
        Console.ReadLine();
    }
}