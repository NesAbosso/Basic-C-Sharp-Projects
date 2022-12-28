using System;

namespace car_insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their age
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask the user if they have ever had a DUI
            Console.WriteLine("Have you ever had a DUI? (Yes/No)");
            string dui = Console.ReadLine();

            // Ask the user how many speeding tickets they have
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Use the qualification rules to determine if the applicant qualifies for car insurance
            //with age greater than 15, tickets is 3 or less and if dui is no
            bool qualifies = (age > 15) && (dui != "yes") && (tickets <= 3);

            // Print the result of the boolean expression
            Console.WriteLine("Qualifies for car insurance: " + qualifies);
        }
    }
}
