using System;

namespace daily_report__DR__for_students
{
    class Program
    {
        static void Main(string[] args)

        {   //This is a simple program for active students
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            //This is input for a string variable of the users name
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);


            // Type your course and press enter
            Console.WriteLine("What course are you on?");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string course = Console.ReadLine();
            // Print the value of the variable (course), which will display the input value
            Console.WriteLine("Course is: " + course);

            // Type your page number and press enter
            Console.WriteLine("What page number?");
            // Create a string variable and get user input from the keyboard and store it in the variable
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            // Print the value of the variable (page), which will display the input value
            Console.WriteLine("page is: " + pageNumber);

            // Type your answer to question
            Console.WriteLine("Do you need help with anything?");
            Console.WriteLine("Please answer \"true\" or \"false\"?");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

                    //more questions asked
                    Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics");
                    string positiveExperiences = Console.ReadLine();

                    Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific");
                    string feedback = Console.ReadLine(); 

                    Console.WriteLine("How many hours did you study today?");
                    int studyHours = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            

        }
            }

        }
    
    

