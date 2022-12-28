using System;

namespace income_comparison_program
{
    class Program
    {
        static void Main(string[] args)
        {
            //simple math program
                Console.WriteLine("Anonymous Income Comparison Program");
            
            //displays input from user hourly rate and hours worked
                Console.WriteLine("Person 1");
                Console.Write("Hourly rate: ");
                decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Hours worked per week: ");
                decimal hoursWorkedPerWeek1 = Convert.ToDecimal(Console.ReadLine());
            
            //displays input from user hourly rate and hours worked
                Console.WriteLine("Person 2");
                Console.Write("Hourly rate: ");
                decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Hours worked per week: ");
                decimal hoursWorkedPerWeek2 = Convert.ToDecimal(Console.ReadLine());

            //in decimal we multiple hours and rate by 52 to get yearly salary
                decimal annualSalary1 = hourlyRate1 * hoursWorkedPerWeek1 * 52;
                decimal annualSalary2 = hourlyRate2 * hoursWorkedPerWeek2 * 52;

            //compare Person 1 and 2 to see see who has a greater salary each year
                Console.WriteLine("Annual salary of Person 1: " + annualSalary1);
                Console.WriteLine("Annual salary of Person 2: " + annualSalary2);
                Console.WriteLine("Does Person 1 make more money than Person 2? " + (annualSalary1 > annualSalary2));
            }
        }
    }


    

