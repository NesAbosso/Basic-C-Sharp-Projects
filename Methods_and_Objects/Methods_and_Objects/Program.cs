using System;

namespace Methods_and_Objects
{
    class Program
    {
        //Main method, instantiate and initialize an Employee object
        //with a first name of “Sample” and a last name of “Student
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };
            //superclass method SayName() on the Employee object
            employee.SayName();
        }
    }
}
