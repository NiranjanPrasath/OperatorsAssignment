using System;

namespace OperatorsAssignment
{
    // Employee class
    public class Employee
    {
        // Employee properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the == operator
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Handle null values
            if (ReferenceEquals(emp1, emp2))
                return true;

            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare employees by Id
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals()
        public override bool Equals(object obj)
        {
            if (obj is Employee employee)
            {
                return this.Id == employee.Id;
            }
            return false;
        }

        // Override GetHashCode()
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}