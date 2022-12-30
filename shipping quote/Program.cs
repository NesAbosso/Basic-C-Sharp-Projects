using System;

namespace shipping_quote
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt for package weight
            Console.WriteLine("Enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if package is too heavy greater than 50 and will end program if it is
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }
            //input for size of package
            Console.WriteLine("Enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            //if greater than 50 program will end
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            //If size is right will calculate quote by multiplying and will display quote to user
            int quote = (width * height * length * weight) / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + " Thank you!");
        }
    }
}
