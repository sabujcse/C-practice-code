using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhritancePolymorphismExample.AnimalSimulator
{
    public class Tiger:Animal
    {
        public override string Move()
        {
            return "Tiger Can Move";
        }

        public override string Speek()
        {
            return "Halum";
        }
    }
}
