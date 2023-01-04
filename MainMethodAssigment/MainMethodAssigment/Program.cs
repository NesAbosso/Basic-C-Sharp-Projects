using System;

namespace MainMethodAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOp = new MathOperations();

            // Call the Calculate method with an integer argument
            int result1 = mathOp.Calculate(4);
            Console.WriteLine(result1);

            // Call the Calculate method with a decimal argument
            int result2 = mathOp.Calculate(2.14m);
            Console.WriteLine(result2);

            // Call the Calculate method with a string argument
            int result3 = mathOp.Calculate("6");
            Console.WriteLine(result3);
        }
    }
}
