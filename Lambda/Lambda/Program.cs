using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of at least 10 employees
            List<Employee> employees = new List<Employee>
    {
        new Employee { Id = 1, FirstName = "Joe", LastName = "Katz" },
        new Employee { Id = 2, FirstName = "Jenny", LastName = "Garcia" },
        new Employee { Id = 3, FirstName = "Jarel", LastName = "Stephens" },
        new Employee { Id = 4, FirstName = "Jolie", LastName = "Forsyth" },
        new Employee { Id = 5, FirstName = "Joe", LastName = "Raven" },
        new Employee { Id = 6, FirstName = "Cindy", LastName = "Monroe" },
        new Employee { Id = 7, FirstName = "Jared", LastName = "Elrod" },
        new Employee { Id = 8, FirstName = "Benson", LastName = "Barlowe" },
        new Employee { Id = 9, FirstName = "Booker", LastName = "Abosso" },
        new Employee { Id = 10, FirstName = "Jason", LastName = "Caddel" },
        new Employee { Id = 11, FirstName = "Bob", LastName = "Baker"}
    };

            // Create a new list of employees with the first name "Joe" using a foreach loop
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            // Create a new list of employees with the first name "Joe" using a lambda expression
            List<Employee> joes2 = employees.Where(e => e.FirstName == "Joe").ToList();

            // Create a new list of employees with an Id number greater than 5 using a lambda expression
            List<Employee> employeesWithIdGreaterThanFive = employees.Where(e => e.Id > 5).ToList();
        }
    }
    }



