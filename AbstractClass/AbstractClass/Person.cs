using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Person
    {
        // Store the person's ID
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        // Implements the SayName() method
        public virtual void SayName()
        {
            // Output the full name
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
    }
}
