using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorConstVar
{
    public class Human
    {
        //create human class with name and age
        public string Name { get; set; }
        public int Age { get; set; }

        public Human(string name) : this(name, 0)
        {
        }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}