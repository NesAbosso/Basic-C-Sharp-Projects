using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorConstVar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a const variable.
            const int maxAttempts = 1;
            for (int i = 1; i <= maxAttempts; i++)
            {
                Console.WriteLine($"Attempt {i} of {maxAttempts}");
                {
                    //Create a variable using the keyword “var"
                    var name = "Jared";
                    Console.WriteLine($"Name: {name}");

                    var person = new Human("Stephens", 49);
                    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                }
            }
        }
    }
}
