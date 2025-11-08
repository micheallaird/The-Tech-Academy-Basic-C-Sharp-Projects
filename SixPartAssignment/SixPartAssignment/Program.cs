using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {

        // Six Part Console App Assignment

        // ----Assignment Part 1----
        // Instructs user to input text for 5 items
        Console.WriteLine("Please enter text for 5 items:");
        // A one-dimensional array of strings that asks a user to input some text
        string[] userInputs = new string[5];
        for (int i = 0; i < userInputs.Length; i++)
        {
            Console.Write($"Enter text for item {i + 1}: ");
            userInputs[i] = Console.ReadLine();
        }

        // Break line for better readability in console output
        Console.WriteLine();

        // A loop that iterates through each string in the array and adds the user's text to the string. 
        // This step will not output anything to the console, but will update each array element by appending the user's text.
        for (int i = 0; i < userInputs.Length; i++)
        {
            userInputs[i] = $"Item {i + 1}: {userInputs[i]}";
        }

        // Break line for better readability in console output
        Console.WriteLine();

        // A second loop that prints each string in the array on a separate line in the console window
        for (int i = 0; i < userInputs.Length; i++)
        {
            Console.WriteLine(userInputs[i]);
        }

        // Break line for better readability in console output
        Console.WriteLine();

        // End of Assignment Part 1 - Wait for user input before moving to next part
        Console.WriteLine("Press Enter Key to start Assignment Part 2 (Commented Out)");
        Console.ReadLine();



        // ----Assignment Part 2----
        //An infinite loop (commented out to prevent execution issues)
        //while (true)
        //{
        //    //Tells user that this is an infinite loop and how to stop it
        //    Console.WriteLine("This is an infinite loop. Press Ctrl+C to stop.");
        //}

        // End of Assignment Part 2 - Wait for user input before moving to next part
        Console.WriteLine("Press Enter Key to start Assignment Part 3");
        Console.ReadLine();



        // ----Assignment Part 3----
        // A loop where the comparison that's used to determine whether to continue iterating the loop is a "<" operator
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Iteration {i + 1} of loop with '<' operator.");
        }

        // Break line for better readability in console output
        Console.WriteLine();

        // Another loop where the comparison that's used to determine whether to continue iterating the loop is a "<=" operator
        for (int i = 0; i <= 4; i++)
        {
            Console.WriteLine($"Iteration {i + 1} of loop with '<=' operator.");
        }

        // Break line for better readability in console output
        Console.WriteLine();

        // End of Assignment Part 3 - Wait for user input before moving to next part
        Console.WriteLine("Press Enter Key to start Assignment Part 4");
        Console.ReadLine();



        // ----Assignment Part 4----
        // Define a list of unique strings
        List<string> uniqueStrings = new List<string>
        {
            "Micheal", "Sonya", "Virginia", "Austin", "Rhodey", "Remington"
        };

        bool found = false;

        while (!found)
        {
            Console.WriteLine("Enter text to select a name in the list:");
            string userInput = Console.ReadLine();

            // Check if the input is empty or just spaces
            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Input cannot be empty. Please enter a name.\n");
                continue; // Go back to the top of the loop
            }

            // Iterate through the list to find a match
            for (int i = 0; i < uniqueStrings.Count; i++)
            {
                // Use IndexOf for older .NET versions (instead of Contains)
                if (uniqueStrings[i].IndexOf(userInput, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine($"Match found at index {i}: {uniqueStrings[i]}");
                    found = true;
                    break; // Stop once a match is found
                }
            }

            // If no match found after checking all items
            if (!found)
            {
                Console.WriteLine("Your input is not on the list. Please try again.\n");
            }
        }

        // Break line for better readability in console output
        Console.WriteLine();

        // End of Assignment Part 4 - Wait for user input before moving to next part
        Console.WriteLine("Press Enter Key to start Assignment Part 5");
        Console.ReadLine();



        // ----Assignment Part 5----
        // A list of strings that has at least two identical strings in the list.
        List<string> nonUniqueStrings = new List<string>
        {
            "Micheal", "Sonya", "Virginia", "Austin", "Rhodey", "Remington", "Sonya", "Virginia"
        };

        bool matchFound = false;

        while (!matchFound)
        {
            //Asks the user to select text to search for in the list.
            Console.WriteLine("Enter text to search for in the list:");
            string searchInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(searchInput))
                {
                Console.WriteLine("Input cannot be empty. Please enter text to search for.\n");
                continue; // Go back to the top of the loop
            }

            //A loop that iterates through the list and displays the indices of all occurrences of the user's text in the list.
            for (int i = 0; i < nonUniqueStrings.Count; i++)
            {
                if (nonUniqueStrings[i].IndexOf(searchInput, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine($"Match found at index {i}: {nonUniqueStrings[i]}");
                    matchFound = true;
                }
            }
            if (!matchFound) {
                Console.WriteLine("Your input is not on the list.");
                break; // Exit the loop if no matches are found
            }
        }

        // Break line for better readability in console output
        Console.WriteLine();

        // End of Assignment Part 5 - Wait for user input before moving to next part
        Console.WriteLine("Press Enter Key to start Assignment Part 6");
        Console.ReadLine();



        // ----Assignment Part 6----
        //A list of strings that has at least two identical strings in the list.
        List<string> nonUniqueStrings1 = new List<string>
        {
            "Micheal", "Sonya", "Virginia", "Austin", "Rhodey", "Remington", "Sonya", "Virginia"
        };
        //A foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list
        HashSet<string> seenStrings = new HashSet<string>();
        foreach (string name in nonUniqueStrings1)
        {
            if (seenStrings.Contains(name))
            {
                Console.WriteLine($"'{name}' is a duplicate.");
            }
            else
            {
                Console.WriteLine($"'{name}' is a unique item.");
                seenStrings.Add(name);
            }
        }
        // End of 6 Part Assignment
        Console.ReadLine(); 
    }
}