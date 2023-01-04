using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate an Employee object with firstName “Sample” and lastName “Student
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };
            //Call the SayName() method on the object.
            employee.SayName();
        }
        }
    }
    
