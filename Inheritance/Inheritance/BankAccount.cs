using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BankAccount
    {
        public string AccountName { set; get; }
        public string CustomerName { set; get; }
        public string Blance { set; get; }

        public string withdrow(double amount)
        {
            Blance += amount;
            return "withdrow";
        }
        public string diposit(double amount)
        {
            Blance += amount;
            return "diposit";
        }

    }
}
