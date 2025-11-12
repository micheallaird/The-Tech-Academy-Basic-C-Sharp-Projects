using System;

namespace AbstractClass
{
    internal class Employee
    {
        // Store the employee's name
        public required string Name { get; set; }

        // Implements the SayName() method
        public virtual void SayName()
        {
            // Output the name
            Console.WriteLine(Name);
        }
    }
}