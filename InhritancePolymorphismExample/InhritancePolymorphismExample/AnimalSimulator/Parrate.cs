using InhritancePolymorphismExample.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhritancePolymorphismExample.AnimalSimulator
{
    public class Parrate:Animal,IFlayble
    {
        public bool IsWing { get; set; }
        public string FlayingSpeed { get; set; }

        public string Fly()
        {
            return "Pratte Can Flay";
        }

        public override string Move()
        {
            return "Parrate Can Movie";
        }
        public override string Speek()
        {
            return "Perrete can Sound";
        }
    }
}
