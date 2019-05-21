using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    class Vickle
    {
        public string Name { get; set; }
        public string RegNo { get; set; }
        private List<double> speeds = new List<double>();

        public void AddSpeed(double speed)
        {
            speeds.Add(speed);
        }
        public double GetMax()
        {
            double sp = 0;
            for( int i = 0; i<speeds.Count; i++)
            {
                if (speeds[i] > sp)
                {
                    sp = speeds[i];
                }
            }
            return sp;
        }
        public double Minspeed()
        {
            double sp = speeds[0];
            for (int i = 1; i < speeds.Count; i++)
            {
                if (speeds[i] < sp)
                {
                    sp = speeds[i];
                }
            }
            return sp;
        }
        public double GetAbarage()
        {
            double sp = 0.0;
            for (int i = 0; i < speeds.Count; i++)
            {
                sp += speeds[i];
            }
            return (sp/speeds.Count);
        }
    }
}
