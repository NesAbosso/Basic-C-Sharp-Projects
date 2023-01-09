using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DateTimeNow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            Console.WriteLine(DateTime.Now);

            // Ask the user for a number
            Console.Write("Enter a number of hours: ");
            string input = Console.ReadLine();
            int hours = int.Parse(input);

            // Print the exact time it will be in X hours
            DateTime future = DateTime.Now.AddHours(hours);
            Console.WriteLine($"In {hours} hours, it will be {future:t}.");
        }
    }
}
