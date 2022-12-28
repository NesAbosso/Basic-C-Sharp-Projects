using System;

namespace CONSOLE_APPLICATION
{
    class Program
    {
        static void Main(string[] args)
        {
            //input from the user, multiplies it by 50
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input); 
            int result = num * 50;
            Console.WriteLine("Result: " + result);


            //input from the user, adds 25 to it
            Console.WriteLine("Enter a number: ");
            string product = Console.ReadLine();
            int num1 = Convert.ToInt32(input); 
            int total = num1 + 25;
            Console.WriteLine("Result: " + total);

            //input from the user, divides it by 12.5
            Console.WriteLine("Enter a number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double results = num2 / 12.5;
            Console.WriteLine("The result is: " + results);

            //checks if it is greater than 50, then prints the true/false result to the console
            Console.WriteLine("Enter a number: ");
            input = Console.ReadLine();
            num = Convert.ToInt32(input);
            bool isGreaterThan50 = num > 50;
            Console.WriteLine("Result: " + isGreaterThan50);

            //divides it by 7, then prints the remainder to the console
            Console.WriteLine("Enter a number: ");
            input = Console.ReadLine();
            num = Convert.ToInt32(input);
            int remainder = num % 7;
            Console.WriteLine("Result: " + remainder);
        }
        }
}
        
    


