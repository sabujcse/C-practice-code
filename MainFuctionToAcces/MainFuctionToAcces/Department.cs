using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainFuctionToAcces
{
    class Department
    {
        public string ShortName { set; get; }
        public string FullName { set; get; }
        public List<Student> students { set; get; }

        public Department()
        {
            students = new List<Student>();
        }
    }
}
