//// See https://aka.ms/new-console-template for more information

//// Daily Report Assignment
//// This application collects daily report information from students.
//// Header Readlines
Console.WriteLine("The Tech Academy");
Console.WriteLine("Student Daily Report (Press Enter to continue)");
Console.ReadLine();
// Questions that return string data type
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("What course are you on?");
string course = Console.ReadLine();
// Question that returns byte data type
Console.WriteLine("What page number?");
byte pageNumber = byte.Parse(Console.ReadLine());
// Question that returns boolean data type
Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
bool needsHelp = bool.Parse(Console.ReadLine());
// More questions that return string data type
Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
string positiveExperience = Console.ReadLine();
Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
string feedback = Console.ReadLine();
// Final question that returns double data type
Console.WriteLine("How many hours did you study today?");
double studyHours = double.Parse(Console.ReadLine());
// Closing statement
Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
Console.ReadLine();