using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14.Models
{
    class Customer
    {
        private string name;
        private string email;
        private Account accountNo = null;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Account AccountNo
        {
            get { return accountNo; }
            set { accountNo = value; }
        }
    }
}
