using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{

    //abstract class called Person
    abstract class Person
        {
        //two properties: string firstName and string lastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //adstract method SayName().
        public abstract void SayName();
        }

    //Employee class inherits from Person class
        class Employee : Person
        {
        //SayName() method inside of the Employee class
        //with override
        public override void SayName()
            {
                Console.WriteLine($"Name: {FirstName} {LastName}");
            }
        }
    }


