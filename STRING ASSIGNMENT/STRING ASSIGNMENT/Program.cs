using System;
using System.Text;

namespace STRING_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenates 4 strings
            string str1 = "I love";
            string str2 = "Booker and ";
            string str3 = "Benson";
            string str4 = "!";
            string combined = str1 + " " + str2 + str3 + str4;

            Console.WriteLine(combined); // Outputs "I love Booker and Benson!"

            //convert string to uppercase 
            string str = "I love cats!";
            string upper = str.ToUpper();

            Console.WriteLine(upper); // Outputs "I love cats!"

            //Creates a Stringbuilder and builds a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();

            sb.Append("I like pizza. ");
            sb.Append("I also like ice cream. ");
            sb.Append("But what I like the most is pasta. ");

            string paragraph = sb.ToString();

            Console.WriteLine(paragraph);
            // Outputs "I like Pizza. I also like ice cream. But what I like the most is pasta."

        }

        }
    }



    
        
        
         
        
    


