using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class BankAccount
    {
        public string Accounno { set; get; }
        public string CustomerName { set; get; }
        public string Balance { set; get; }

        public string deposit(double amount)
        {
            Balance += amount;
            return "Deposit";
        }
        public string withdrow(double amount)
        {
            Balance += amount;
            return "withdrow";
        }
    }
}
