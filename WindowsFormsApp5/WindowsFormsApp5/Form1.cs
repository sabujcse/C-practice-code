using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tatalsalaryTextbox_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void calculatetotalsalarybutton_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.salaryMain = Convert.ToDouble(salaryTextbox.Text);
            salary.rentMain = Convert.ToDouble(rentTextbox.Text);
            salary.medicaleMain = Convert.ToDouble(medicalTextbox.Text);
            double maintotalsalary = salary.totalSalarycalculation();
            tatalsalaryTextbox.Text = maintotalsalary.ToString();
           
        }
        public void ClearFunc()
        {
            salaryTextbox.Clear();
            rentTextbox.Clear();
            medicalTextbox.Clear();
        }
    }
}
