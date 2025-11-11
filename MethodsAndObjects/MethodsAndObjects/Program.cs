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
        // Instantiates and initializes an Employee object with a first name of "Sample", a last name of "Student"
        Employee employee = new()
        {
            FirstName = "Sample",
            LastName = "Student",
        };
        // Calls the superclass method SayName() on the Employee object.
        employee.SayName();
    }
}