using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhritancePolymorphismExample.AnimalSimulator
{
    public class Cow:Animal
    {
        public override string Move()
        {
            return "Cow Can Move";
        }
        public override string Speek()
        {
            return "Hambba";
        }
    }
}
