using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Details ds1 = new Details();
            ds1.Id = 1;
            ds1.Name = "sabuj sarker";
            ds1.Email = "sabuj3cse@gmail.com";
            ds1.Hometown = "Jessor";
            Details ds2 = new Details();
            ds2.Id = 2;
            ds2.Name = "sujoy sarker";
            ds2.Email = "sujoye@gmail.com";
            ds2.Hometown = "Jessor";
            Details ds3 = new Details();
            ds3.Id = 3;
            ds3.Name = "Shuvo Bosu";
            ds3.Email = "bosu@gmail.com";
            ds3.Hometown = "Shatkhira";
            Details ds4 = new Details();
            ds4.Id = 4;
            ds4.Name = "Dipto Saha";
            ds4.Email = "saha@gmail.com";
            ds4.Hometown = "Gopalgonj";

            RecordSave recordSave = new RecordSave();
            recordSave.details.Add(ds1);
            recordSave.details.Add(ds2);
            recordSave.details.Add(ds3); 
            recordSave.details.Add(ds4);
            foreach(Details details in recordSave.details)
            {
                string info = "Id: "+details.Id + "Name: " + details.Name + "Email: " + details.Email + "HomeTown: " + details.Hometown;
                Console.WriteLine(info);
            }
            ds1.physicsNumber = 30;
            ds1.MathNumber = 40;
            Console.WriteLine(ds1.Getresult());
            Console.ReadKey();
        }
    }
}
