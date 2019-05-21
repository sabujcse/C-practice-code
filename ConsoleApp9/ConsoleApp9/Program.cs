using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9;
using ConsoleApp99;
using ConsoleApp999;

namespace ConsoleApp9
{
    public class First
    {
        public void Run()
        {
            Console.WriteLine("Running........");

        }
    }
}
namespace ConsoleApp99
{
    public class Second
    {
        public void Runn()
        {
            Console.WriteLine("Runnnning......");
        }
    }
}
namespace ConsoleApp999
{
    public class Third
    {
        public void Runner()
        {
            Console.WriteLine("Runns..........");
        }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
        First first = new First();
        Second second = new Second();
        Third third = new Third();
        first.Run();
        second.Runn();
        third.Runner();
         
             Console.ReadKey();
        }
    }
//}
