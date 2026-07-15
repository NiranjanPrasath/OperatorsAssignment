using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object.
            Employee employee1 = new Employee()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith"
            };

            // Create the second Employee object.
            Employee employee2 = new Employee()
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Doe"
            };

            // Compare the two Employee objects using the overloaded == operator.
            if (employee1 == employee2)
            {
                Console.WriteLine("The employees are equal.");
            }
            else
            {
                Console.WriteLine("The employees are not equal.");
            }

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}