using InhritancePolymorphismExample.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhritancePolymorphismExample.AnimalSimulator
{
    public class Egale:Animal,IFlayble
    {
        public bool IsWing
        {
            get;
            set;
        }
        public string FlayingSpeed
        {
            get;
            set;
        }

        public string Fly()
        {
            return "Egalle Can Fly";
        }
        public override string Move()
        {
            return "Egale Can Move";
        }
        public override string Speek()
        {
            return "Egale Can sound";
        }
    }
}
