using System;

namespace Struct
{
    class Program
    {

        //Create a struct called Number and give it the property
        //“Amount” and have it be of data type decimal.
        struct Number
        {
            public decimal Amount { get; set; }
        }
        //In the Main() method, create an object of
        //data type Number and assign an amount to it.
        static void Main(string[] args)
        {
            Number n = new Number { Amount = 400.55m };
            Console.WriteLine(n.Amount);
        }

    }
}

