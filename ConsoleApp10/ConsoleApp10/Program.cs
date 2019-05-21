using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Persondetails
    {
        private int Id;
        private string Name;
        private int Age;
        public int Ids
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
           
        }
        public String nm
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public int Ages
        {
            get
            {
                return Age;
            }
            set
            {
                Age = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /***string clone
            string s1 = Console.ReadLine();
            cloneFunction(s1);
            **/
            /*string compiar
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            compiar(s1, s2);
            */
            /** Copy to
            string s1 = "Hello c# Programmer?";
            char[] ch = new char[15];
            s1.CopyTo(5, ch, 0, 12);
            Console.WriteLine(ch);
             **/
            string s1 = string.Format("{0:D}", DateTime.Now);
            Console.WriteLine(s1);
            string s = "sabuj sarker is my name?";
            foreach(var x in s)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void compiar(string s1, string s2)
        {
            // s1==s2  = 0
            //s1>s2 = 1
            //s1<s2 = -1
            Console.WriteLine(string.Compare(s1, s2));
        }
        public static void cloneFunction( string s)
        {
            string s2 = (string)s.Clone();
            Console.WriteLine(s);
            Console.WriteLine(s2);
        }
    }
}
