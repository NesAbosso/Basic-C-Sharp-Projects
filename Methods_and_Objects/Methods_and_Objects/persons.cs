using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_and_Objects
{
    //this class is a void method called SayName() and writes out the Name full name
    class persons
    {
        //two properties, each of data type string
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //SayName() on the Employee object
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    //Employess class inherits from the persons class
    class Employee : persons
    {
        //property called Id and data type int
        public int Id { get; set; }
    }
}

