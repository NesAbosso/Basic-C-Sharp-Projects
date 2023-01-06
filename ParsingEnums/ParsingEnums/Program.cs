using System;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user to enter the current day of the week
            Console.WriteLine("Enter the current day of the week:");

            //Wrap the above statement in a try/catch block and have it print "Please enter an
            //actual day of the week.” to the console if an error occurs.
            try
            {
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
                Console.WriteLine($"Today is {day}.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }
}