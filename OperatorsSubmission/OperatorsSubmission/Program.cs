// Creates a class called Person and gives it two string properties: FirstName and LastName.
public class Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public void SayName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }
}
// Creates a class called Employee and inherits from the Person class.
public class Employee : Person
{
    public int ID { get; set; }

    public void DisplayEmployeeInfo()
    {
        SayName();
        Console.WriteLine($"Employee ID: {ID}");
    }
}

public class Program
{
    public static void Main()
    {
        // Instantiates two objects of the Employee class and assign values to their properties.
        Employee emp1 = new()
        {
            ID = 1,
            FirstName = "John",
            LastName = "Doe"
        };
        Employee emp2 = new()
        {
            ID = 2,
            FirstName = "Jane",
            LastName = "Smith"
        };
        // Compares the two Employee objects using the newly overloaded operators and displays the results.
        Console.WriteLine($"emp1 == emp2: {emp1 == emp2}\n");
        Console.WriteLine($"emp1 != emp2: {emp1 != emp2}\n");
        // Displays the information of both employees.
        emp1.DisplayEmployeeInfo();
        // Added to create a space for readability in the console
        Console.WriteLine();
        emp2.DisplayEmployeeInfo();
        // Keeps the console window open.
        Console.ReadLine();
    }
}
