using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string GetFullname()
        {
            string fullname = firstName + " " + middleName + " " + lastName;
            return fullname;
        }
        public string GetreversName()
        {
            string g = "";
            string s = GetFullname();
            for (int i = s.Length - 1; i>= 0; i--)
            {
                g += s[i];
            }
            return g;
        }
    }
}
