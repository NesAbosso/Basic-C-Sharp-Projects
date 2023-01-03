
using System;
using System.Collections.Generic;

namespace SIX_PART_Console_App_Assignment
{
    class Program
    {
        private static int counter;

        static void Main(string[] args)
        {
            //Assignment Part 1
            // Create an array of strings
            string[] array = { "I", "Love", "Cats!" };

            // Ask the user to input some text
            Console.WriteLine("Enter some text: ");
            string text = Console.ReadLine();

            // Loop through each string in the array and add the user's text to the end of each string
            //It then loops through each string in the array using a for loop and appends the value of text to the end of each string using the += operator.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += text;
            }

            // Create a second loop that prints off each string in the array one at a time
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }

            //Assignment Part 2
            //Here is an example of an infinite loop

            // while (true)
            {
                /// Console.WriteLine("This is an infinite loop!");
            }

            //To fix an infinite loop, you need to identify the cause of the infinite loop and add an exit condition to the loop
            //The infinite loop was fixed by adding a counter variable and using it to exit the loop after 10 iterations.
            while (true)
            {
                Console.WriteLine("This is an infinite loop!");
                counter++;
                if (counter >= 10)

                    break;
            }
            {
                //Assignment Part 3
                //In the 1st loop the < operator indicates that the loop will continue to iterate as long as i is less than 10
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }

                //In the 2nd loop, the <= operator indicates that the loop will continue to iterate as long as i is less than or equal to 10.
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

                //Assignment Part 4
                //A list of strings called list and initializes it with three unique strings
                List<string> list = new List<string>() { "dog", "cat", "bunny" };

                // Ask the user to input text to search for in the list
                Console.WriteLine("Enter some text to search for: ");
                string searchText = Console.ReadLine();

                // A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen
                bool found = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Contains(searchText))
                    {
                        Console.WriteLine("Match found at index {0}", i);
                        found = true;
                        break; // Add code that stops the loop from executing once a match has been found
                    }
                }

                // Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list
                if (!found)
                {
                    Console.WriteLine("Input not found in the list.");
                }
            }

            {
                //Assignment Part 5
                //Create a list of strings that has at least two identical strings in the list
                List<string> mylist = new List<string>() { "kitten", "bird", "puppy", "kitten" };

                // Ask the user to select text to search for in the list
                Console.WriteLine("Enter some text to search for: ");
                string searchText = Console.ReadLine();

                // Create a loop that iterates through the list and then displays the indices of the items matching the user-selected text
                bool found = false;
                for (int i = 0; i < mylist.Count; i++)
                {
                    if (mylist[i].Contains(searchText))
                    {
                        Console.WriteLine("Match found at index {0}", i);
                        found = true;
                    }
                }
                // Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list
                if (!found)
                {
                    Console.WriteLine("Input not found in the list.");
                }

                //Assignment Part 6
                // Create a list of strings that has at least two identical strings in the list
                List<string> list = new List<string>() { "A", "B", "C", "D", "C" };

                // Create a hash set to store the strings that have already appeared in the list
                HashSet<string> set = new HashSet<string>();

                // Create a foreach loop that evaluates each item in the list
                foreach (string s in list)
                {
                    // Display a message showing the string and whether or not it has already appeared in the list
                    if (set.Contains(s))
                    {
                        Console.WriteLine("{0} - this item is a duplicate", s);
                    }
                    else
                    {
                        Console.WriteLine("{0} - this item is unique", s);
                        set.Add(s);
                    }
                }
            }
        }
    }
}




