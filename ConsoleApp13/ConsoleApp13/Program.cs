using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            Person ps = new Person();
            ps.firstName = "sabuj";
            ps.middleName = "sujoy";
            ps.lastName = "sarker";
            string ss = ps.GetFullname();
            string sp = ps.GetreversName();
            Console.WriteLine(ss);
            Console.WriteLine(sp);
            Person ps2 = new Person();
            ps2.firstName = "puja";
            ps2.middleName = "shuvo";
            ps2.lastName = "saha";
            string sss = ps2.GetFullname();
            string spp = ps2.GetreversName();
            Console.WriteLine(sss);
            Console.WriteLine(spp);
            //Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
