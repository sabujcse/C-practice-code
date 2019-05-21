using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helloworld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string firstname = FirstnameTextBox.Text;
            string secondname = SecondNameTextbox.Text;
            string fullname = firstname +" "+secondname;
            FullNameTextbox.Text = fullname;
            MessageBox.Show("Hi "+ firstname + secondname+"Hellow In c# World");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
