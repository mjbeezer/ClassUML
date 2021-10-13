using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Person
    {
        //properties
        public string Name { get; set; }
        public string Address { get; set; }

        //constructor - blank
        public Person()
        {

        }

        //constructor
        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public override string ToString()
        {
            return $"Person {Name}, {Address}";
        }
    }
}
