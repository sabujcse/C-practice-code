using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14.Models
{
    class Account
    {
        private string number;
        private string openigdate;
        private double blance;

        public Account()
        {
            blance = 0.0;
        }
        public Account(string number, string openingdate)
        {
            this.number = number;
            this.openigdate = openingdate;
        }
        public double BLance
        {
            get { return blance; }
        }
        public bool Deposit(double amount)
        {
            blance = BLance + amount;
            return true;
        }
        public bool Withdraw(double amount)
        {
            if (amount <= BLance)
            {
                blance = BLance- amount;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
