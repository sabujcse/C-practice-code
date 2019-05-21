using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformationUI
{
    class Employee
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string GetNameFullname()
        {
            string fullname = firstName + " " + middleName + " " + lastName;
            return fullname;
        }
    }
}
