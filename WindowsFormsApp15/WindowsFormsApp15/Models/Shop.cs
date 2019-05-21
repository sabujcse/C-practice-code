using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Models
{
    class Shop
    {
        private string name { get; set; }
        private string adress { get; set; }
        private List<Product>products;
        public Shop(string name, string adress)
        {
            this.name = name;
            this.adress = adress;
            products = new List<Product>();
        }
        public List<Product> Products
        {
            get { return products; }
        }
        public bool addProduct(Product product)
        {
            bool chk = false;
            if (Exit(product.id))
            {chk = true;}
            else
            { products.Add(product); }
            return chk;
        }
        public bool Exit( int id)
        {
            bool chker = false;
            foreach(Product p in products)
            {
                if (p.id == id)
                { p.Addquantity(p.quantity);
                    chker = true; }
            }
            return chker;
        }
        public string getAll()
        {
            string all = "Name: " + name + " " + "Address: " + adress + "\n\n"+"Id:"+"\t"+"Quantity"+"\n\n";
            foreach(Product product in products)
            {   all += product.All();
            }
            return all;
        }
       
    }
}
