// See https://aka.ms/new-console-template for more information


// String Assignment
// Concatenates three strings
using System.Text;

Console.WriteLine("Hello, " + "world" + "!");

// Converts a string to uppercase
string lowerCaseString = "this is a test to change to upper case.";
string upperCaseString = lowerCaseString.ToUpper();
Console.WriteLine(upperCaseString);
// Creates a Stringbuilder and builds a paragraph of text, one sentence at a time
StringBuilder sb  = new StringBuilder();
// Append first sentence into the StringBuilder
sb.Append("My name is Micheal");
// Display the current content of the StringBuilder
Console.WriteLine(sb);
// Wait for user input before proceeding
Console.ReadLine();
// Append second sentence into the StringBuilder
sb.Append(". \nI am learning C# and using StringBuilder.");
// Display the current content of the StringBuilder
Console.WriteLine(sb);
// Wait for user input before proceeding
Console.ReadLine();
// Append third sentence into the StringBuilder
sb.Append(". \nI hope to build many applications using C# and really get into the meat of the language.");
// Display the current content of the StringBuilder
Console.WriteLine(sb);
// Wait for user input before proceeding
Console.ReadLine();
// Append fourth sentence into the StringBuilder
sb.Append(". \nI am excited to see what I can create!");
// Display the final content of the StringBuilder
Console.WriteLine(sb);
// Wait for user input before exiting
Console.ReadLine();