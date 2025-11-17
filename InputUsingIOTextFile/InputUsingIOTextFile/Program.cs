// Asks the user for a number, logs that number to a text file, then prints the text file back to the console.
using System;
using System.IO;
using System.Threading.Tasks;
namespace InputUsingIOTextFile
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Defines a dummy file path for demonstration purposes
            string filePath = "user_input.txt";
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();
            // Write the user input to a text file
            await File.WriteAllTextAsync(filePath, userInput);
            Console.WriteLine($"Your input has been saved to {filePath}.");
            // Read the content back from the text file and print it to the console
            string fileContent = await File.ReadAllTextAsync(filePath);
            Console.WriteLine($"The content of the file is: {fileContent}");
        }
    }
}