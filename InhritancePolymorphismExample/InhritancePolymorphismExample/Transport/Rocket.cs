using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InhritancePolymorphismExample.AnimalSimulator;
using InhritancePolymorphismExample.Contacts;

namespace InhritancePolymorphismExample.Transport
{
    class Rocket : Animal, IFlayble
    {
        public Rocket()
        {
            IsWing = false;
            FlayingSpeed = "First";
        }
        public bool IsWing
        {
            get ;
            set ;
        }
        public string FlayingSpeed
        {
            get;
            set ;
        }

        public string Fly()
        {
            return "Rocket Can Flay";
        }

        public override string Move()
        {
            return "Rocket Can Move";
        }
    }
}
