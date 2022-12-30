using System;
using System.Collections.Generic;

namespace ARRAY_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a one-dimensional array of strings
            string[] stringArray = { "socks", "pants", "sweater", "skirt", "jacket", "shoes" };

            // Ask the user to select an index of the array
            Console.WriteLine("Select an index of the string array (0-5):");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Display the string at the selected index
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                Console.WriteLine("The string at index " + stringIndex + " is: " + stringArray[stringIndex]);
            }
            else
            {
                Console.WriteLine("Invalid index. Please select an index between 0 and " + (stringArray.Length - 1) + ".");
            }

            // Create a one-dimensional array of integers
            int[] intArray = { 1, 2, 3, 4, 5, 6 };

            // Ask the user to select an index of the array
            Console.WriteLine("Select an index of the integer array (0-5):");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Display the integer at the selected index
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                Console.WriteLine("The integer at index " + intIndex + " is: " + intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("Invalid index. Please select an index between 0 and " + (intArray.Length - 1) + ".");
            }

            // Create a list of strings
            List<string> stringList = new List<string> { "dogs", "cats", "birds", "snakes", "rodents", "fish" };

            // Ask the user to select an index of the list
            Console.WriteLine("Select an index of the string list (0-5):");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // Display the string at the selected index
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                Console.WriteLine("The string at index " + listIndex + " is: " + stringList[listIndex]);
            }
            else
            {
                Console.WriteLine("Invalid index. Please select an index between 0 and " + (stringList.Count - 1) + ".");
            }
        }
    }
}
