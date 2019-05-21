using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        
        int BlockPrice = 120;
        int ColdPrice = 100;
        int HotkPrice = 90;
        int RegularPrice = 80;
        string[] CustomerName = new string[3];
        string[] ContactNumber = new string[3];
        string[] Addresss = new string[3];
        string[] SelectOrder = new string[3];
        string[] Quantity = new string[3];
        string[] CustomerInformationSaver = new string[3];
        int query_time = 0;
        int l = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(OrderTextbox.SelectedText != " ")
            {
                int total_price = 0; 
                CustomerName[query_time]   = NameTextbox.Text;
                ContactNumber[query_time]  = ContactTextbox.Text;
                Addresss[query_time]       = AddressTextbox.Text;
                SelectOrder[query_time]    = OrderTextbox.Text;
                Quantity[query_time]       = QuantityTextbox.Text;
                //CustomerName[query_time] = NameTextbox.Text;
                if(SelectOrder[query_time] == "Black")
                {
                    total_price = Convert.ToInt32(Quantity[query_time]) * BlockPrice;
                }
                else if (SelectOrder[query_time] == "Cold")
                {
                    total_price = Convert.ToInt32(Quantity[query_time]) * ColdPrice;
                }
                else if (SelectOrder[query_time] == "Hot")
                {
                    total_price = Convert.ToInt32(Quantity[query_time]) * HotkPrice;
                }
                else //(SelectOrder[query_time] == "Black")
                {
                    total_price = Convert.ToInt32(Quantity[query_time]) * RegularPrice;
                }
                int l = query_time;
                l++;
                CustomerInformationSaver[query_time] ="Customer No -> "+l+"\n\n" +"Name: " + CustomerName[query_time] + "\n" + "Contact Number: " + ContactNumber[query_time] + "\n" + "Customer Address: " + Addresss[query_time] + "\n" + "Quantity: " + Convert.ToInt32(Quantity[query_time]) + "\n" + "Total Price: " + total_price + "\n\n";
                query_time++;

            }
            else
            {
                OrderOrning.Text = "Please Select A Item";
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
            for(int i =0; i<3; i++)
            {
                richTextBox.Text = richTextBox.Text + CustomerInformationSaver[i];
            }
        }
    }
}
