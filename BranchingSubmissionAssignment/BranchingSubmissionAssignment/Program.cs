// See https://aka.ms/new-console-template for more information


// BranchingSubmissionAssignment to create a console-based application for getting a shipping quote based on user input.

// Application Instructions:
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

// Prompt the user for the weight of the package.
Console.Write("What is the weight of the package in pounds? ");
// Convert the user input to a numeric value.
double weight = Convert.ToDouble(Console.ReadLine());

// If the weight is greater than 50 pounds, display a message indicating package too heavy and terminate the program.
if (weight > 50)
{
    Console.WriteLine("Package too heavy to be shipped via Package Express.");
    System.Environment.Exit(0);
}

// Prompt the user for the package dimensions: width.
Console.Write("What is the width of the package in inches? ");
// Convert the user input to a numeric value.
double width = Convert.ToDouble(Console.ReadLine());

// Prompt the user for the package dimensions: height.
Console.Write("What is the height of the package in inches? ");
// Convert the user input to a numeric value.
double height = Convert.ToDouble(Console.ReadLine());

// Prompt the user for the package dimensions: length.
Console.Write("What is the length of the package in inches? ");
// Convert the user input to a numeric value.
double length = Convert.ToDouble(Console.ReadLine());

// If the sum of the dimensions is greater than 50, display a message indicating package too big and terminate the program.
if ((width + height + length > 50))
{
    Console.WriteLine("Package too big to be shipped via Package Express.");
}
// Otherwise, calculate the shipping quote and display it to the user.
else
{
    double quote = (width * height * length) * (weight / 100);
    Console.WriteLine($"Your estimated shipping cost is: ${quote}");
}