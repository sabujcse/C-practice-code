using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Salary
    {
        public double salaryMain;
        public double rentMain;
        public double medicaleMain;
        public double totalSalarycalculation()
        {
            double houserent = salaryMain * rentMain / 100;
            double medical = salaryMain * medicaleMain / 100;
            double totalsalary = salaryMain + houserent + medical;
            return totalsalary;
        }
    }
}
