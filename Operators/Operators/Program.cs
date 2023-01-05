using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate two objects of the Employee class and
            //assign values to their properties
            Employee employee1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            Employee employee2 = new Employee
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe"
            };
            //Then compare the two Employee objects using the newly overloaded operators
            // and display the results
            if (employee1 == employee2)
            {
                Console.WriteLine("The two employees have the same Id.");
            }
            else
            {
                Console.WriteLine("The two employees have different Ids.");
            }
        }
    }
}
