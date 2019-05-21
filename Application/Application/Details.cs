using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Details
    {
        public string Name { set; get; }
        public int Id { set; get; }
        public string Email { set; get; }
        public string Hometown { set; get; }
        public double physicsNumber { set; get; }
        public double MathNumber { set; get; }
        public string Getresult()
        {
            Calculator calculator = new Calculator();
            double fisrt =  calculator.Div(physicsNumber,2);
            double second = calculator.Div(MathNumber, 2);
            double final = fisrt + second;
            if( final>= 50)
            {
                return "Pass";
            }
            else
            {
                return "faild";
            }
        }
    }
}
