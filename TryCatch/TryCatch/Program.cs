using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exceptions must be handled using “try/catch
            try
            {
                //Ask the user for their age.
                //Display the year the user was born
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                if (age <= 0)
                {
                    Console.WriteLine("Error: Age must be a positive number.");
                }
                else
                {
                    int yearBorn = DateTime.Now.Year - age;
                    Console.WriteLine("You were born in the year {0}.", yearBorn);
                }
            }
            //Display appropriate error messages if the user enters zero or negative numbers
            catch (FormatException)
            {
                Console.WriteLine("Error: Age must be a number.");
            }
            //Display a general message if an exception was caused by anything else
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
            }
        }
    }
}
