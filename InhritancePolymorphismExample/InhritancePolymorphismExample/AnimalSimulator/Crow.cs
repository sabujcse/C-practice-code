using InhritancePolymorphismExample.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhritancePolymorphismExample.AnimalSimulator
{
    public class Crow : Animal, IFlayble
    {
        public Crow()
        {
            IsWing = true;
            FlayingSpeed = "Normal";
        }
        public bool IsWing
        {
            get ;
            set;
        }
        public string FlayingSpeed
        {
            get;
            set;
        }

        public string Fly()
        {
            return "Crow Can Flay";
        }

        public override string Move()
        {
            return "Crow Can move";
        }
    }
}
