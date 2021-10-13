using System;
using System.Collections.Generic;

namespace ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class UML");

            //list of Persons
            List<Person> Peoples = new List<Person>();

            //create persons to go into list
            Student One = new Student("Bart Simpson", "742 Evergreen Terrace", "C#", 2, 300);
            Peoples.Add(One);

            Student Two = new Student("Lisa Simpson", "742 Evergreen Terrace", "C#", 1, 300);
            Peoples.Add(Two);

            Student Three = new Student("Milhouse Van Houten", "316 Pikeland Ave", "C#", 2, 300);
            Peoples.Add(Three);

            Staff Teacher = new Staff("Springfield Elementary", 35000, "Edna Krabappel", "82 Evergreen Terrace" );
            Peoples.Add(Teacher);

            Staff GroundsKeeper = new Staff("Springfield Elementary", 35000, "Willie MacDougal", "19 Plympton Street");
            Peoples.Add(GroundsKeeper);

            foreach(Person i in Peoples)
            {
                Console.WriteLine(i);
            }
        }
    }
}
