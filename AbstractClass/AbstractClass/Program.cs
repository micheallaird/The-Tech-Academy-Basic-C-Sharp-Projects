using System;
// Creates an interface called IQuittable and has it define a method called Quit().
interface IQuittable
{
    void Quit();
}

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
// Creates another class called Employee that inherits from the Person class and implements IQuittable.
class Employee : Person, IQuittable
{
    // Implements the Quit() method from IQuittable interface
    public void Quit()
    {
        Console.WriteLine("Employee has quit.");
    }

    // Instantiates an Employee object with firstName "Sample" and lastName "Student" and calls the SayName() method on the object.
    static void Main(string[] args)
    {
        Employee employee = new ()
        {
            FirstName = "Sample",
            LastName = "Student"
        };
        employee.SayName();

        // Uses polymorphism to create an object of type IQuittable and calls the Quit() method on it.
        IQuittable quittable = new Employee
        {
            FirstName = "Sample",
            LastName = "Student"
        };
        quittable.Quit();

        // Adds break for readability
        Console.ReadLine();
    }
}
