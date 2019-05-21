using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainFuctionToAcces
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Id = 1;
            student1.Name = "sabuj";
            student1.Enail = "sabuj3cse@gmail.com";
            student1.Dep = "CSE";

            Student student2 = new Student();
            student2.Id = 2;
            student2.Name = "puja";
            student2.Enail = "puja@gmail.com";
            student2.Dep = "CSE";

            Student student3 = new Student();
            student3.Id = 3;
            student3.Name = "Dipto";
            student3.Enail = "dipto@gmail.com";
            student3.Dep = "EEE";

            Department ds = new Department();
            ds.ShortName = "EEE";
            ds.FullName = "Electrical Engineering";
            ds.students.Add(student1);
            ds.students.Add(student2);
            ds.students.Add(student3);
            PresentAddress st = student1.presentAddress;
            foreach (Student student in ds.students)
            {
                string info = student.Id + " " + student.Name + " " + student.Enail + " " + student.Dep;
                Console.WriteLine(info);
            }


            PresentAddress present = new PresentAddress();
            present.FlatNo = "81/1 Indira Road";
            present.Block = "D Block";
            present.HouseNo = "81/1";
            present.District = "Dhaka";




            /**
            student1.presentAddress = present;

            string name = student1.Name;
            string Districtn = present.District;
            PresentAddress st = student1.presentAddress;
            string ggg = student1.presentAddress.HouseNo;
            string Housenn = st.HouseNo;
            Console.WriteLine(ggg+" "+Housenn);
            Console.WriteLine(name + " " + Districtn+""+st.FlatNo+" "+st.Block+""+st.HouseNo+""+st.District);
            
             **/
            Console.ReadKey();

        }
    }
}
