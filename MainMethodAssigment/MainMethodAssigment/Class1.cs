using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodAssigment
{
    class MathOperations
    {

            // Method that takes in an integer and returns the result of a math operation
        public int Calculate(int num)
        {
            // You can choose any math operation you like
            int result = num + 10;
            return result;
        }

        // Method that takes in a decimal and returns the result of a math operation
        public int Calculate(decimal num)
        {
            // You can choose any math operation you like
            int result = (int)(num / 2);
            return result;
        }

        // Method that takes in a string and returns the result of a math operation
        public int Calculate(string str)
        {
            // Try to convert the string to an integer
            if (int.TryParse(str, out int num))
            {
                // You can choose any math operation you like
                int result = num * 10;
                return result;
            }
            else
            {
                // If the string could not be converted to an integer, return 0
                return 0;
            }
        }
    }

}