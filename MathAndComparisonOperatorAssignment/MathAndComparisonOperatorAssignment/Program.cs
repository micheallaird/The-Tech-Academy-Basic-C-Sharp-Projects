// See https://aka.ms/new-console-template for more information


// Anonymous Income Comparison Program
// Inputs for Person 1
Console.WriteLine("Anonymous Income Comparison Program");
Console.WriteLine("Person 1");
Console.Write("Hourly Rate: ");
string person1HourlyRate = Console.ReadLine();
Console.Write("Hours Worked: ");
string person1HoursWorked = Console.ReadLine();


// Inputs for Person 2
Console.WriteLine("Person 2");
Console.Write("Hourly Rate: ");
string person2HourlyRate = Console.ReadLine();
Console.Write("Hours Worked: ");
string person2HoursWorked = Console.ReadLine();

// Calculates annual salary for Person 1
decimal person1AnnualSalary = Convert.ToDecimal(person1HourlyRate) * Convert.ToDecimal(person1HoursWorked) * 52;
// Calculates annual salary for Person 2
decimal person2AnnualSalary = Convert.ToDecimal(person2HourlyRate) * Convert.ToDecimal(person2HoursWorked) * 52;

// Outputs the results for Person 1
Console.WriteLine("Annual Salary of Person 1: " + person1AnnualSalary);
// Outputs the results for Person 2
Console.WriteLine("Annual Salary of Person 2: " + person2AnnualSalary);
// Compares the annual salaries of Person 1 and Person 2
Console.WriteLine("Does Person 1 make more than Person 2: " + (person1AnnualSalary > person2AnnualSalary));
