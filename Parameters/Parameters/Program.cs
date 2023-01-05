using System;
using System.Collections.Generic;

namespace Parameters
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Assign a list of strings as the property value of Things.
            Employee<string> e1 = new Employee<string>
            {
                Id = 1,
                FirstName = "Jared",
                LastName = "Stephens",
                Things = new List<string> { "Jeep", "Dodge", "Nissan" }
            };

            //Assign a list of integers as the property value of Things.
            Employee<int> e2 = new Employee<int>
            {
                Id = 2,
                FirstName = "Jolie",
                LastName = "Forsyth",
                Things = new List<int> { 1, 2, 3 }
            };

            //Create a loop that prints all of the Things to the Console
            foreach (var thing in e1.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (var thing in e2.Things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}

 
    
    


