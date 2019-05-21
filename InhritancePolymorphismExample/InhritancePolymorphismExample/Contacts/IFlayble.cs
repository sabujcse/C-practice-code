using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhritancePolymorphismExample.Contacts
{

    interface IFlayble
    {
         bool IsWing { get; set; }
         string FlayingSpeed { get; set; } 
         string Fly();

    }
}
