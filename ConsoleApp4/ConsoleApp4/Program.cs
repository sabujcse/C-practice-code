using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class GenericExample
    {
        public void show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    public class GenericEx
    {
        GenericExample dg = new GenericExample();
        public void aginshow<T, K, L>(T mg, K ms, L ns) 
        {
            Console.WriteLine(mg + " "+ ms + " "+ ns);
            dg.show(ms);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /**
            GenericExample ge = new GenericExample();
            ge.show("sabuj");
            ge.show(1);
            ge.show("sabuj sarker");
          **/
            GenericEx genericEx = new GenericEx();
            genericEx.aginshow("Id: 1", "Name: sabuj sarker", "Home: Jessor");
            genericEx.aginshow("Id: 2", "Name: sujoy sarker", "Home: 7khira");
            Console.ReadKey();
        }
    }
}
