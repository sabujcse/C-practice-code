using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Models
{
    class Product
    {
       public int id { get; set; }
       public double quantity { get; set; }
        public Product(int id, double quantity)
        {
            this.id = id;
            this.quantity = quantity;
        }
        public void Addquantity(double qn)
        {
            quantity = quantity+ qn;
        }
        public string All()
        {
            return id + "\t" + " " + quantity + "\n";
        }
    }
}
