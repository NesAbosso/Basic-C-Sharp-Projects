using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_and_Objects
{
    //class called persons and give it two properties
    class persons
    {
        //two properties, each of data type string
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //this class a void method called SayName()
        //writes the person's full name to the console in the format of: “Name: [full name]”.
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

