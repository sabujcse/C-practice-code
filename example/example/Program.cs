using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Vote
    {
            
        public void Voter()
        {
            Console.WriteLine("Please Enter valid Number");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", number);

        }
    }
    class RepExa
    {
        public void swap( ref int aa, ref int bb)
        {
            int rs;
            rs = aa;
            aa = bb;
            bb = rs;
            
        }
    }
    class Fibonacci
    {
        public int fiborecurtion( int nn)
        {
            if( nn == 0)
            {
                return 0;
            }
            else if(nn == 1)
            {
                return 1;
            }
            else
            {
                return (fiborecurtion(nn - 1) + fiborecurtion(nn - 2));
            }
        }
    }
    class faccalculation
    {
        public int Fac( int n)
        {
            if ( n==0)
            {
                return 1;
            }
            else
            {
                return n * Fac(n - 1);
            }
        }

    }
    class MaxSum
    {
        public int MaxResult(int number1, int number2) 
            {
            int result;
            if (number1 > number2)
            {
                result = number1;
                return result;
            }

            else
            {
                result = number2;
                return number2;
            }
            }
        public int MinFunction( int x, int y)
        {
            if( x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
     }       

}
class Minimum
{
    static void Minp(int[] arry)
    {
        int min = arry[0];
        for( int i = 1; i<arry.Length; i++)
        {
            if( min > arry[i])
            {
                min = arry[i];
            }
        }
        Console.WriteLine("{0}", min);
    }

 
}

    class Program
    {
      
        static void Main(string[] args)
        {
        /*
        example.MaxSum ms = new example.MaxSum();
        example.faccalculation fc = new example.faccalculation();
        example.Fibonacci fn = new example.Fibonacci();
        int x, y;
        Console.WriteLine("Enter First Number:   ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number:   ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The max Result Is: {0}", ms.MaxResult(x, y));
        Console.WriteLine("The Minimum result Isw: {0}", ms.MinFunction(x, y));
        Console.WriteLine("Now Calculation Factorial And Fibonacci ");
        int r, s;
        Console.WriteLine("Enter The factorial calculation Number:");
            r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Inde of {0} factorial value Is: {1}", r, fc.Fac(r));
        Console.WriteLine("Enter The Fibonacci Calculation Number:");
        s = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Inde of {0} factorial value Is: {1}", s, fn.fiborecurtion(s));
        int na, nb;
        na = Convert.ToInt32(Console.ReadLine());
        nb = Convert.ToInt32(Console.ReadLine());
        example.RepExa td = new example.RepExa();
        td.swap(ref na, ref nb);
        Console.WriteLine("After Swap The Value of a = {0}, and value Of b = {1}", na, nb);
        int  a = Convert.ToInt32(Console.ReadLine());
            for( int i = 1; i<=a; i++)
            {
                if (i%2 ==0 )
                {
                    Console.WriteLine("The VCalu of {0} is even",i);
                }
                else{
                    Console.WriteLine("The Value of {0} is odd", i);
                }
            }
            */

        /*
        int[] arry = new int[10];
        for (int i = 0; i < 10; i++) {
            arry[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(arry);
        for(int j=0;  j < 10; j++ )
        {
            Console.WriteLine("{0}",arry[j]);
        }
        *
        */
        /*
        example.Vote vt = new example.Vote();
        examplee:
            vt.Voter();
        
        int n;
       
        n = Convert.ToInt32(Console.ReadLine());
        if (n > 0)
        {
            Console.WriteLine("Eligable");
        }
        else
        {
            goto examplee;
        }
        */
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        int[] ar = new int[n];
        for( int i = 0; i<n; i++)
        {
            ar[i] = Convert.ToInt32(Console.ReadLine());
        }
        Minimum.Minp(ar);
          Console.ReadKey();
        }
    }

