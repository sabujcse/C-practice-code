using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public Person(string firstName, string middleName, string lastName) : this( firstName, lastName)
        {
            this.middleName = middleName;
        }
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public void disply()
        {
            Console.WriteLine(firstName + " " + middleName + " " + lastName);
        }
        public void disply2()
        {
            Console.WriteLine(firstName+" "+lastName);
        }
    }
}
