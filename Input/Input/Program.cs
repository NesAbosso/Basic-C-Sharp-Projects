using System;
using System.IO;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            // Log the number to a text file
            string filePath = "numbers.txt";
            File.AppendAllText(filePath, number + Environment.NewLine);

            // Print the text file back to the user
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
