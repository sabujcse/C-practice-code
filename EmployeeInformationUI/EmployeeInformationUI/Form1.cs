using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Employee> employees = new List<Employee>();
        private void showButton_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.firstName = firstNameTextbox.Text;
            em.middleName = middleNameTextbox.Text;
            em.lastName = lastNameTextbox.Text;
            //ListView listView = new ListView();
            /**
            ListViewItem item = new ListViewItem();
            item.Text = em.GetNameFullname();
            employeList.Items.Add(item);
              **/
            employees.Add(em);

            MessageBox.Show("Info Saved.......");
            //MessageBox.Show("Save The Information\nFull Name: " + em.GetNameFullname());

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeList.Items.Clear();
            foreach(Employee employee in employees)
            {
                ListViewItem item = new ListViewItem();
                item.Text = employee.firstName;
                item.SubItems.Add(employee.middleName);
                item.SubItems.Add(employee.lastName);
                item.SubItems.Add(employee.GetNameFullname());
                employeList.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
