using System;
using System.Collections.Generic;

namespace Strings_and_Integers_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            // Ask the user for a number to divide by
            Console.WriteLine("Enter a number to divide the list of integers by: ");
            string input = Console.ReadLine();

            try
            {
                // Convert the user input to an integer
                int divisor = Convert.ToInt32(input);

                // Divide each integer in the list by the divisor
                // and display the result
                foreach (int number in numbers)
                {
                    int result = number / divisor;
                    Console.WriteLine($"{number} / {divisor} = {result}");
                }
            }
            //If you enter a valid number, the program will divide each integer in the list 
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. You must enter a number.");
            }
            //If you enter zero, the program will display the error message "Cannot divide by zero."
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            //If you enter a string, the program will display the error message "Invalid input. You must enter a number."
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            // Program execution continues below the try/catch block
            Console.WriteLine("Program execution continues...");
        }
    }
}
