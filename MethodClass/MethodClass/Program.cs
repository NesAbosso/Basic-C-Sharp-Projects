using System;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperation class
            MathOperation mathOp = new MathOperation();

            // Call the DoMath() method and pass in two numbers
            mathOp.DoMath(10, 20);

            // Call the DoMath() method and specify the parameters by name
            mathOp.DoMath(num2: 30, num1: 40);
        }
    }
}
