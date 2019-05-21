using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<Details> eds = new List<Details>();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            foreach(Details details in eds)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = details.getName();
                nameList.Items.Add(listViewItem);
                c_f();

            }
            
           // MessageBox.Show("Saved Succesfully....\n"+ds.getName());
        }
        public void c_f()
        {
            firstNametextbox.Clear();
            middleNametext.Clear();
            lastNametextbox.Clear();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Details ds = new Details();
            ds.FirstName = firstNametextbox.Text;
            ds.MiddleName = middleNametext.Text;
            ds.LastName = lastNametextbox.Text;
            eds.Add(ds);
            MessageBox.Show("Information Is Saved");

        }
    }
}
