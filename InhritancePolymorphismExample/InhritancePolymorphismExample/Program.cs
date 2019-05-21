 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InhritancePolymorphismExample.AnimalSimulator;
using InhritancePolymorphismExample.Contacts;
using InhritancePolymorphismExample.SuperMan;
using InhritancePolymorphismExample.Transport;

namespace InhritancePolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<IFlayble> flaybles = new List<IFlayble>();
            //flaybles.Add(new Crow());
            //flaybles.Add(new Panda());
            //flaybles.Add(new Parrate());
            //flaybles.Add(new Egale()); 
            //flaybles.Add(new Rocket());
            //flaybles.Add(new SuperHero());
            //foreach(IFlayble flayble in flaybles)
            //{
            //    Console.WriteLine(flayble.Fly() + " " + flayble.IsWing + " " + flayble.FlayingSpeed);
            //}
            //ANONYMOUS TYPE
            //var products = new[]
            //{
            //     new{name = "sss", type="qqq", price=1000},
            //     new{name = "www", type="aaa",price=2000},

            //};
            //foreach(var p in products)
            //{
            //    Console.WriteLine(p.name + " " + p.type + " " + p.price);
            //}
            //Func<int, int, int> result = Mul;
            //Console.WriteLine(result(5, 6));
            //Func<int, int, int> sumResul = Sum;
            //Console.WriteLine(sumResul(4, 5));

            Func<int, int, int> addResult = (x, y) => x + y;
            Func<int, int, int> mulResult = (x, y) => (x * y);
            Func<int, int,int,int,int>result = (x, y, z,l) => (((x * y)+ z)/l);
            Console.WriteLine(result(2,2,2,2));

            Console.ReadKey();
        }
        //public static int Mul( int n1, int n2)
        //{
        //    return (n1*n2);
        //}
        //public static int Sum( int n, int m)
        //{

        //    return (n + m);
        //}
    }
}
