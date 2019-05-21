using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp15.Models;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        Shop shop;
        Product product;
        public Form1()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            shop = new Shop(NametextBox.Text, AddresstextBox.Text);
            NametextBox.Clear();
            AddresstextBox.Clear();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            product = new Product(Convert.ToInt32(idtextBox.Text), Convert.ToDouble(quantitytextBox.Text));
            if (shop.addProduct(product)){
                MessageBox.Show("Alredy Exist");
            }
            else
            {
                MessageBox.Show("Item Saved");
            }
            idtextBox.Clear();
            quantitytextBox.Clear();
           
            
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
           MessageBox.Show(shop.getAll());
        }
    }
}
