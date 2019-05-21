using InhritancePolymorphismExample.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhritancePolymorphismExample.AnimalSimulator
{
    public class Panda : Animal,IFlayble
    {
        public bool IsWing { get; set; }
        public string FlayingSpeed { get; set; }

        public string Fly()
        {
            return "Panda Can Flay";
        }

        public override string Move()
        {
           return "Panda Can Move";
        }
    }
}
