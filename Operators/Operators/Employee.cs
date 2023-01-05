using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{
    //Create an Employee class with Id, FirstName and LastName properties
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by
        //comparing their Id property
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
        public override bool Equals(object obj)
        {
            var employee = obj as Employee;
            return employee != null && Id == employee.Id;
        }

        //override the Equals method and the GetHashCode method if you want to use the Equals method to
        //compare two Employee objects
        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
