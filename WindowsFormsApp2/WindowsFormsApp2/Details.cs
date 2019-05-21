using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Details
    {
        public string firstName;
        public string lasttName;
        public string fathertName;
        public string motherName;
        public string AddressName;
        public string showDetails()
        {
            string details = "Name: "+ firstName +"\n"+"LastName: "+ lasttName + "\n"+"Father Name: " + fathertName + "\n"+"Mother Name: " + motherName + "\n"+"Address: " + AddressName;
            return details;
        }
        public string FullName()
        {
            string fulllName = firstName + " " + lasttName;
            return fulllName;
        }

    }
}
