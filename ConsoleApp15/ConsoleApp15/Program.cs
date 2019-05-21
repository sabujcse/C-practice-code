using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            person personS = new person();
            personS.FirstName1 = "SABUJ";
            Console.WriteLine(personS.FirstName1);
           
            Console.ReadKey();
        }
    }
}
