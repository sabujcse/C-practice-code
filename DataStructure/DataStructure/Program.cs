using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<long, string> dc = new Dictionary<long, string>();
            dc.Add(12345678916777, "sabuj");
            dc.Add(1234567891234567, "sujoy");
            foreach(KeyValuePair<long, string> keyValuePair in dc)
            {
                Console.WriteLine(keyValuePair.Key + " " + keyValuePair.Value);
            }


            SortedSet<int> st = new SortedSet<int>();
            st.Add(1);
            st.Add(19);
            st.Add(4);
            st.Add(12);
            st.Add(10);
            st.Add(7);
            foreach(var xx in st)
            {
                Console.WriteLine(xx);
            }
            //hasset have not no dublicate value
            HashSet<string> hs = new HashSet<string>();
            hs.Add("sabuj");
            hs.Add("sujoy");
            hs.Add("dipok");
            hs.Add("dipto");
            hs.Add("sabuj");
            Console.WriteLine(hs.Count);
            foreach(var i  in hs)
            {
                Console.WriteLine(i);
            }
            //List Example
            int x;
            List<int> ls = new List<int>(5);
            for( int i = 0; i<ls.Count; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                ls.Add(x);
            }
            foreach( int i in ls)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            
            var names = new List<string>();
            names.Add("sabuj");
            names.Add("sujoy");
            names.Add("dipok");
            names.Add("dipto");
            names.Add("sabuj");
            var name2 = new List<string> { "aaa", "bbb", "ccc" };
            foreach(var nn in name2)
            {
                Console.WriteLine(nn);
            }
            Console.WriteLine("Print From the Function");
            prn1(name2);
            foreach( var i in names)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Print From Anbother Function");
            prn(names);
           

        }
        
        public static void prn1(List<string> st1)
        {
            foreach(var nam in st1)
            {
                if (nam == "aaa")
                {
                    Console.WriteLine("Dipok Please Stop The Song");
                }
                else
                {
                    Console.WriteLine(nam);
                }
            }
        }
       
        public static void prn(List<string> st)
        {
            foreach(var name in st)
            {
                if (name == "dipok")
                {
                    Console.WriteLine("Dipok Is A Facker");
                }
                else
                {
                    Console.WriteLine(name);
                }
            }
        } 
        
    }
}

