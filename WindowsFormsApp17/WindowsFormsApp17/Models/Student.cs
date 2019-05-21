using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp17.Models
{
    class Student
    {
        public string RegNo {get; set;}
        public string Name  { get; set; }
        public string Email { get; set; }

        public Student(string RegNo, string Name, string Email)
        {
            this.RegNo = RegNo;
            this.Name = Name;
            this.Email = Email;
        }

    }
}
