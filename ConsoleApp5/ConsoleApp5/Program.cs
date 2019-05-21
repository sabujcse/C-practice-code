using System;
delegate int Calculator(int number);
//namespace ConsoleApp5
//{
    class Program
    {
        static int n  = 100;
    public static int add(int number)
    {
        n = n + number;
        return n;
    }
    public static int mul( int number)
    {
        n = n * number;
        return n;
    }
    public static int Getr()
    {
        //Console.WriteLine(n);
        return n;
    }
        static void Main(string[] args)
        {
        Calculator c1 = new Calculator(add);
        c1(50);
        Console.WriteLine(Getr());
        Calculator c2 = new Calculator(mul);
        c2(2);
        Console.WriteLine(Getr());
            Console.ReadKey();
        }
    }
//}
