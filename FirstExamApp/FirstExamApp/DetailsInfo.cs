using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExamApp
{
    class DetailsInfo
    {
        public string firstName;
        public string middleName;
        public string Lastname;
        public string GetName()
        {
            string fullName = firstName + " " + middleName + " " + Lastname;
            return fullName;
        }
    }
}
