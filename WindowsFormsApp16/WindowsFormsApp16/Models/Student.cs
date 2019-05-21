using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16.Models
{
    class Student
    {
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Student(string RegNo, string Name, string Email)
        {
            this.RegNo = RegNo;
            this.Name = Name;
            this.Email = Email;
        }
        public string getAll()
        {
            return RegNo + "\t\t" + Name + "\t" + Email+"\n";
        }
    }
}
