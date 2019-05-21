using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeveralControlExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sunday");
            comboBox1.Items.Add("Runday");
            comboBox1.Items.Add("Munday");
            comboBox1.Items.Add("Nunday");
            comboBox1.Items.Add("Kunday");
            comboBox1.Items.Add("Lunday");
            comboBox1.Items.Add("Funday");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dayname = comboBox1.SelectedItem.ToString();
            MessageBox.Show(dayname);
        }
    }
}
