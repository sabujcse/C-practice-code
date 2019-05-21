using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Details details = new Details();
        public bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Details dg = new Details();
            
            MessageBox.Show("Information Saved Succesfully......");
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            Details details = new Details();
            details.firstName = firstNameTextbox.Text;
            details.lasttName = lastNameTextbox.Text;
            details.fathertName = fatherNameTextbox.Text;
            details.motherName = motherNameTextbox.Text;
            details.AddressName = addressTextbox.Text;
            
            MessageBox.Show("  Personal Details\n\n-------------\n"+details.showDetails());
           
        }
        private void Clear()
        {
            firstNameTextbox.Clear();
            lastNameTextbox.Clear();
            fatherNameTextbox.Clear();
            motherNameTextbox.Clear();
            addressTextbox.Clear();
        }

        private void bullNameshow_Click(object sender, EventArgs e)
        {
            Clear();
            //Details gf = new Details();
            details.firstName = firstNameTextbox.Text;
            details.lasttName = lastNameTextbox.Text;
            MessageBox.Show("Full Name Is: "+details.FullName());
        }
    }
}
