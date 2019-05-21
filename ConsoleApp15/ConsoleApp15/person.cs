using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class person
    {
        private string FirstName;
        private string middleName;
        private string lastName;

        public string FirstName1 {
            get {
              return FirstName;
            } set {
                if (value.Length == 3)
                {
                    FirstName = value;
                }
                else
                {
                    Console.WriteLine("Not Insert");
                }
            }
        }
    }
}
