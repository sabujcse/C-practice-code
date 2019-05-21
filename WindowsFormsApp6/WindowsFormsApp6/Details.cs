using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Details
    {
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string getName()
        {
            string s = FirstName + " " + MiddleName + " " + LastName;
            return s;
        }
    }
}
