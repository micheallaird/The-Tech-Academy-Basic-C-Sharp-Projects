using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    internal class Person
    {
        // Add FirstName and LastName properties 
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        // Gives this class a void method called SayName that takes no parameters and simply writes
        // the person's full name to the console in the format of "Full Name: {FirstName} {LastName}".
        public void SayName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
    }
}