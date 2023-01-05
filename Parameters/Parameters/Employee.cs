using System;
using System.Collections.Generic;
using System.Text;

namespace Parameters
{
    //Employee class with a generic type parameter
    public class Employee<T>
    {
        //added a property to employee class things with a 
        //data type generic list
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<T> Things { get; set; }
    
    }


}
