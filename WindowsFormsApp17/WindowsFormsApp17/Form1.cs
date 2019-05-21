using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp17.Models;
namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        Department department;
        Student student;
        public Form1()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            department = new Department(CodetextBox.Text, NametextBox.Text);
           
            CodetextBox.Clear();
            NametextBox.Clear();
        }

        private void defnamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
    }
}
