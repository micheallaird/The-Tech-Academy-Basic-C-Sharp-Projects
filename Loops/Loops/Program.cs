// See https://aka.ms/new-console-template for more information

// Loops in C#

// Example of a boolean comparison using a while loop and switch statement
Console.WriteLine("Guess the Correct Corvette. It will be one of the following answers: C1, C2, C3, C4, C5, C6, C7, C8. Good luck!");
// Read user input
string corvette = Console.ReadLine();
// Initialize a boolean variable to track if the guess is correct
bool isCorrect = corvette == "C6";
while (!isCorrect)
{
    switch (corvette)
    {
        case "C1":
            Console.WriteLine("You guessed C1. Try again.");
            corvette = Console.ReadLine();
            break;
        case "C2":
            Console.WriteLine("You guessed C2. Try again.");
            corvette = Console.ReadLine();
            break;
        case "C3":
            Console.WriteLine("You guessed C3. Try again.");
            corvette = Console.ReadLine();
            break;
        case "C4":
            Console.WriteLine("You guessed C4. Try again.");
            corvette = Console.ReadLine();
            break;
        case "C5":
            Console.WriteLine("You guessed C5. Try again.");
            corvette = Console.ReadLine();
            break;
        // Correct guess
        case "C6":
            Console.WriteLine("You guessed C6. That is correct!");
            isCorrect = true;
            break;
        case "C7":
            Console.WriteLine("You guessed C7. Try again.");
            corvette = Console.ReadLine();
            break;
        case "C8":
            Console.WriteLine("You guessed C8. Try again.");
            corvette = Console.ReadLine();
            break;
        default:
            Console.WriteLine("That is not a valid Corvette model. Try again.");
            corvette = Console.ReadLine();
            break;
    }
}

// Break line for separation
Console.WriteLine("Press the Enter Key to go to next game.");
Console.ReadLine();


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

// Keep the console window open
Console.ReadLine();