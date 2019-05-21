using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp8;
using secondh;


namespace ConsoleApp8
{
    public class FirstHello
    {
        public void sayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
namespace secondh {
    public class SecondHello
    {
        public void sayHello()
        {
            Console.WriteLine("2nd Hello");
        }
    }
}
    class Program
    {
        public interface Animal
        {
            void drow();
        }
        public class Dog:Animal{
        public void drow()
        {
                Console.WriteLine("Dog");
        }
        }
        public class Chat : Animal
        {
            public void drow()
            {
                Console.WriteLine("Chat");
            }
        }
        static void Main(string[] args)
        {
        FirstHello fh = new FirstHello();
        SecondHello sh = new SecondHello();
        fh.sayHello();
        sh.sayHello();
            Animal ct = new Chat();
            ct.drow();
            ct = new Dog();
            
            ct.drow();
            Console.ReadKey();

        }
    }
//}
