using System;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.WriteLine("Enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the MultiplyByTwo method and display the result
            int result1 = mathOps.MultiplyByTwo(userInput);
            Console.WriteLine(result1);

            // Call the DivideByThree method and display the result
            int result2 = mathOps.DivideByThree(userInput);
            Console.WriteLine(result2);

            // Call the AddFive method and display the result
            int result3 = mathOps.AddFive(userInput);
            Console.WriteLine(result3);
        }
    }
}
