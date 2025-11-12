using System;
// Creates an abstract class called Person with two properties: string firstName and string lastName.
abstract class Person
{
    public int Id { get; set; }
    public required string FirstName { get; set; } // Added property
    public required string LastName { get; set; }  // Added property

    // Implements the SayName() method
    public virtual void SayName()
    {
        Console.WriteLine("Name: " + FirstName + " " + LastName);
    }
}
// Creates another class called Employee that inherits from the Person class.
class Employee : Person
{
    // Instantiates an Employee object with firstName "Sample" and lastName "Student" and calls the SayName() method on the object.
    static void Main(string[] args)
    {
        Employee employee = new()
        {
            FirstName = "Sample",
            LastName = "Student"
        };
        employee.SayName();

        // Adds break for readability
        Console.ReadLine();
    }
}
