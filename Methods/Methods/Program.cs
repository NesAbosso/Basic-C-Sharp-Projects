using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperation class
            MathOperation mathOp = new MathOperation();

            // Ask the user to enter two numbers
            Console.WriteLine("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number (optional): ");
            string input = Console.ReadLine();

            int num2 = 0;
            if (!string.IsNullOrEmpty(input))
            {
                num2 = int.Parse(input);
            }

            // Call the DoMath() method and pass in num1 and num2
            int result = mathOp.DoMath(num1, num2);
            Console.WriteLine("Result: " + result);
        }
    }
}
