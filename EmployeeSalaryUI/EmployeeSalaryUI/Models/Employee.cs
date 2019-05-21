using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryUI.Models
{
    class Employee
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Basic { get; set; }
        public double Medical { get; set; }
        public double Conveyance {get; set;}
        
        public void BasicSalaryincres(double Increments)
        {
            Basic += (Basic * Increments) / 100.0;   
        }
        public double  MedicalSalary()
        {
            return (Medical * Basic) / 100.0;    
        }
        public double CovaSalary()
        {
            return (Conveyance * Basic) / 100.0;
        }
        public double TotalSalary()
        {
            return Basic+((Medical * Basic) / 100.0+ (Conveyance * Basic) / 100.0);
        }
    }
}
