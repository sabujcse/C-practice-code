using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class RecordSave
    {
        public List<Details> details { set; get; }

        public RecordSave()
        {
            details = new List<Details>();
        }
    }
}
