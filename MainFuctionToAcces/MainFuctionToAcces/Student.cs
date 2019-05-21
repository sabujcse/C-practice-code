using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainFuctionToAcces
{
    class Student
    {
        public int Id { set; get; }
        public string Name { set; get;  }
        public string Enail { set; get; }
        public string Dep { set; get; }

        public PresentAddress presentAddress { set; get; }
    }
}
