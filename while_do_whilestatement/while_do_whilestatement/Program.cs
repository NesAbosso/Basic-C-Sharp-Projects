using System;

namespace while_do_whilestatement
{
    class Program
    {
        static void Main(string[] args)
        {

            //int x = 0 adds until it is less than 5 then the while loop stops
            int x = 0;
            while (x < 5)
            {
                Console.WriteLine(x);
                x++;
               
            }

            {
                //// The do while loop stops execution exits when a boolean condition evaluates to false
                {
                    int y = 0;
                    do
                    {
                        Console.WriteLine(y);
                        y++;
                    } while (y < 10);

                }
            }
        }
    }
}
