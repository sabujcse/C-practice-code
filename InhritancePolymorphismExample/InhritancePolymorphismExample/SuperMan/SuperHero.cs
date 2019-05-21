using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InhritancePolymorphismExample.AnimalSimulator;
using InhritancePolymorphismExample.Contacts;

namespace InhritancePolymorphismExample.SuperMan
{
    class SuperHero : Animal, IFlayble
    {
        public SuperHero()
        {
            IsWing = true;
            FlayingSpeed = "SuperFirst";
        }
        public bool IsWing
        {
            get;
            set;
        }
        public string FlayingSpeed
        {
            get ;
            set;
        }

        public string Fly()
        {
            return "Super Hero Can Flay";
        }

        public override string Move()
        {
            return "SuperMan Can Movie";
        }
    }
}
