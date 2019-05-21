using InhritancePolymorphismExample.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhritancePolymorphismExample.AnimalSimulator
{
    class HammingBird : Animal, IFlayble
    {
        public bool IsWing
        {
            get;
            set;
        }
        public string FlayingSpeed
        {
            get ;
            set ;
        }

        public string Fly()
        {
            return "Hamming Bird Can Flay";
        }

        public override string Move()
        {
            return "Hamming Bird Can Move";
        }
    }
}
