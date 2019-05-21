using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhritancePolymorphismExample.AnimalSimulator
{
    public abstract class Animal
    {
        public virtual string Speek()
        {
            return "Anmal Can Speek!";
        }
        public abstract string Move();
        public string Eat()
        {
            return "Animal Can Eat!";
        }
    }
}
