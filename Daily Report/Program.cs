// See https://aka.ms/new-console-template for more information

//Basic C# Print Lines Describing the report and asking for user input
Console.WriteLine("The Tech Academy");
Console.WriteLine("Student Daily Report (Press Enter key to continue)");
Console.ReadLine();
Console.WriteLine("Please answer the following questions: (Press Enter key to continue)");
Console.ReadLine();

//Returns a string value for name and course
Console.WriteLine("What is your name?");
string yourName = Console.ReadLine();
Console.WriteLine("What course are you on?");
string yourCourse = Console.ReadLine();
//Returns a byte value for page number
Console.WriteLine("What page number?");
byte yourPageNumber = Convert.ToByte(Console.ReadLine());
//Returns a boolean value for help needed
Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
bool helpWithAnything = Convert.ToBoolean(Console.ReadLine());
//Returns a string value for positive experiences and other feedback
Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
string positiveExperiences = Console.ReadLine();
Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
string otherFeedback = Console.ReadLine();
//Returns a byte value for study hours
Console.WriteLine("How many hours did you study today?");
byte studyHours = Convert.ToByte(Console.ReadLine());
//Final message to user
Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
Console.ReadLine();

