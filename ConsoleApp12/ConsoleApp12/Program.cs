using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 12;
                int b = 0;
                int c = a / b;
            }
            catch (Exception e) { Console.WriteLine(e); }
            Console.ReadKey();
        }
    }
}
