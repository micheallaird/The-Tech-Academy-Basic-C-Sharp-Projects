using System;

class Program
{
    static void Main()
    {
        // ----- Integer Array Section -----
        int[] intArray = { 15, 30, 45, 60, 75 };
        // Prompt the user to select an index
        Console.WriteLine("INTEGER ARRAY");
        Console.WriteLine("Please select an index between 0 and " + (intArray.Length - 1) + ":");

        // Validate user input
        int intIndex;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out intIndex) && intIndex >= 0 && intIndex < intArray.Length)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid index. Please enter a number between 0 and " + (intArray.Length - 1) + ":");
            }
        }

        // Display the selected integer
        Console.WriteLine("You selected: " + intArray[intIndex]);
        Console.WriteLine(); // Blank line for readability


        // ----- String Array Section -----
        string[] stringArray = { "Corvette", "Camaro", "Viper", "Mustang", "Cobra" };
        // Prompt the user to select an index
        Console.WriteLine("STRING ARRAY");
        Console.WriteLine("Please select an index between 0 and " + (stringArray.Length - 1) + ":");

        // Validate user input
        int strIndex;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out strIndex) && strIndex >= 0 && strIndex < stringArray.Length)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid index. Please enter a number between 0 and " + (stringArray.Length - 1) + ":");
            }
        }

        // Display the selected string
        Console.WriteLine("You selected: " + stringArray[strIndex]);

        // ----- List of Strings Section -----
        List<string> stringList = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple" };
        // Prompt the user to select an index
        Console.WriteLine("STRING LIST");
        Console.WriteLine("Please select an index between 0 and " + (stringList.Count - 1) + ":");
        
        // Validate user input
        int listIndex;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out listIndex) && listIndex >= 0 && listIndex < stringList.Count)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid index. Please enter a number between 0 and " + (stringList.Count - 1) + ":");
            }
        }

        // Display the selected string from the list
        Console.WriteLine("You selected: " + stringList[listIndex]);

        // End of Main method
        Console.WriteLine("Program has ended. Press any key to exit.");
        Console.ReadKey();
    }
}
