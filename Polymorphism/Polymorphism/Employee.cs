using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    //Employee class has inherit from IQuittable interface
    class Employee : IQuittable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Implement the Quit() method
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit.");
        }
    }
}
