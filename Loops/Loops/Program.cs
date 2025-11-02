// See https://aka.ms/new-console-template for more information

// Loops in C#

// This example demonstrates the use of a do-while loop and switch statement

// Asks user to guess a number until they guess the correct one (12)
Console.WriteLine("Guess a number?");
// Convert the input to an integer
int number = Convert.ToInt32(Console.ReadLine());
// Initialize a boolean variable to track if the number is guessed
bool isGuessed = number == 12;

// Start of do-while loop
do
{
    // Switch statement to handle different cases based on the guessed number
    switch (number)
    {
        // Different cases for specific numbers
        case 62:
            Console.WriteLine("You guessed 62. Try again.");
            Console.WriteLine("Guess a number?");
            number = Convert.ToInt32(Console.ReadLine());
            break;
        case 29:
            Console.WriteLine("Guess a number?");
            Console.WriteLine("You guessed 29. Try again.");
            number = Convert.ToInt32(Console.ReadLine());
            break;
        case 55:
            Console.WriteLine("Guess a number?");
            Console.WriteLine("You guessed 55. Try again");
            number = Convert.ToInt32(Console.ReadLine());
            break;
        case 12:
            // Correct guess
            Console.WriteLine("You guessed the number 12. That is correct!");
            isGuessed = true;
            break;
        // Default case for all other numbers
        default:
            Console.WriteLine("You are wrong");
            Console.WriteLine("Guess a number?");
            number = Convert.ToInt32(Console.ReadLine());
            break;
    }
}

// Continue the loop until the correct number is guessed
while (!isGuessed);

Console.Read();