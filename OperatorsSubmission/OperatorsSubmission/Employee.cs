using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    internal class Employee
    {
        // Gives this class an integer property called ID.
        public int ID { get; set; }

        // Overloads the == operator so it checks if two Employee objects are equal based on their ID property.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, emp2))
                return true;
            if (emp1 is null || emp2 is null)
                return false;
            return emp1.ID == emp2.ID;
        }

        // Overloads the != operator as well.
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Overrides the GetHashCode method to ensure consistency with the overloaded operators.
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        // Overrides the Equals method to ensure consistency with the overloaded operators.
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
                return true;
            if (obj is null || obj.GetType() != this.GetType())
                return false;
            Employee other = (Employee)obj;
            return this.ID == other.ID;
        }
    }
}

