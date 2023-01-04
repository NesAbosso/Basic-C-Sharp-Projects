using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // polymorphism to create an object of type IQuittable
            // and call the Quit() method on it
            IQuittable quittableEmployee = employee;
            quittableEmployee.Quit();
        }
    }
}
