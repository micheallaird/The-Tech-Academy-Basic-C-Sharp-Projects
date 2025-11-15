// Lambda Submission Assignment
using System;
using System.Net.Security;
// Creates an Employee class with the following properties: ID, FirstName and LastName
public class Employee
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
static class Program
{
    static void Main(string[] args)
    {
        // Creates a list of at least 10 employees. With two employees that have the first name "Joe".
        List<Employee> employees = new List<Employee>
        {
            new Employee { ID = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { ID = 2, FirstName = "Jane", LastName = "Doe" },
            new Employee { ID = 3, FirstName = "Joe", LastName = "Johnson" },
            new Employee { ID = 4, FirstName = "Emily", LastName = "Davis" },
            new Employee { ID = 5, FirstName = "Michael", LastName = "Brown" },
            new Employee { ID = 6, FirstName = "Sarah", LastName = "Wilson" },
            new Employee { ID = 7, FirstName = "David", LastName = "Taylor" },
            new Employee { ID = 8, FirstName = "Laura", LastName = "Anderson" },
            new Employee { ID = 9, FirstName = "James", LastName = "Thomas" },
            new Employee { ID = 10, FirstName = "Linda", LastName = "Jackson" }
        };
        // Using a foreach loop, create a new list of all employees with the first name "Joe".
        List<Employee> joeEmployeesLoop = new List<Employee>();
        foreach (Employee emp in employees)
        {
            if (emp.FirstName == "Joe")
            {
                joeEmployeesLoop.Add(emp);
            }
        }
        // Print out the employees named Joe found using the foreach loop
        Console.WriteLine("Employees named Joe (using foreach loop):");
        foreach (Employee emp in joeEmployeesLoop)
        {
            Console.WriteLine($"ID: {emp.ID}, First Name: {emp.FirstName}, Last Name: {emp.LastName}");
        }
        // Using a lambda expression, create a new list of all employees with the first name "Joe".
        List<Employee> joeEmployeesLambda = employees.Where(emp => emp.FirstName == "Joe").ToList();
        // Print out the employees named Joe found using the lambda expression
        Console.WriteLine("\nEmployees named Joe (using lambda expression):");
        foreach (Employee emp in joeEmployeesLambda)
        {
            Console.WriteLine($"ID: {emp.ID}, First Name: {emp.FirstName}, Last Name: {emp.LastName}");
        }
        // Using a lambda expression, create a new list of all employees with an ID number greater than 5.
        List<Employee> idGreaterThanFive = employees.Where(emp => emp.ID > 5).ToList();
        // Print out the employees with ID greater than 5
        Console.WriteLine("\nEmployees with ID greater than 5:");
        foreach (Employee emp in idGreaterThanFive)
        {
            Console.WriteLine($"ID: {emp.ID}, First Name: {emp.FirstName}, Last Name: {emp.LastName}");
        } Console.ReadLine();// Keep the console window open
    }
}