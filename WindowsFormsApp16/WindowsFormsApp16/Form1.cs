using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp16.Models;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        Department department;
        Student student;
        public Form1()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            department = new Department(codetextBox.Text, nametextBox.Text);
            codetextBox.Clear();
            nametextBox.Clear();
        }
        private void savestudentbutton_Click(object sender, EventArgs e)
        {
            student = new Student(regNotextBox.Text, studentnametextBox.Text, emailtextBox.Text);
            department.AddStudent(student);
            regNotextBox.Clear();
            studentnametextBox.Clear();
            emailtextBox.Clear();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(department.getInfo());
        }
    }
}
