using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("sabuj","sujoy","sarker");
            Person person2 = new Person("value", "Khan");
            person2.disply2();
            person.disply();
            Console.ReadKey();
        }
    }
}
