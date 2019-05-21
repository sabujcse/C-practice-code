using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeSalaryUI.Models;
namespace EmployeeSalaryUI
{
    public partial class Form1 : Form
    {
        Employee employee;
        int incrementTime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            employee    = new Employee();
            employee.id  =  idtextBox.Text;
            employee.Name =  nametextBox.Text;
            employee.Email =  emailtextBox.Text;
            employee.Basic =  Convert.ToDouble(basictextBox.Text);
            employee.Medical =  Convert.ToDouble(medicaltextBox.Text);
            employee.Conveyance =  Convert.ToDouble(convyancetextBox.Text);
            clearTextBox();
        }
        private void clearTextBox()
        {
            idtextBox.Clear();
            nametextBox.Clear();
            emailtextBox.Clear();
            basictextBox.Clear();
            medicaltextBox.Clear();
            convyancetextBox.Clear();
        }
        private void Incrementbutton_Click(object sender, EventArgs e)
        {    
           employee.BasicSalaryincres(Convert.ToDouble(increasetextBox.Text));
           incrementTime++;
            increasetextBox.Clear();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            noofincreasetextBox.Text = incrementTime.ToString();
            basicsalrytextBox.Text = employee.Basic.ToString();
            medialsalarytextBox.Text = employee.MedicalSalary().ToString();
            convyacesalartextBox.Text = employee.CovaSalary().ToString();
            totallsalarytextBox.Text = employee.TotalSalary().ToString();
        }
    }
}
