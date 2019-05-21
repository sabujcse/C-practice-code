using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstExamApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<DetailsInfo> detailsInfos = new List<DetailsInfo>();
        private void saveButton_Click(object sender, EventArgs e)
        {
            DetailsInfo detailsInfo = new DetailsInfo();
            detailsInfo.firstName = firstNametextbox.Text;
            detailsInfo.middleName = middleTextbox.Text;
            detailsInfo.Lastname = lastNamebox.Text;
            detailsInfos.Add(detailsInfo);
            MessageBox.Show("Information Is Saved Successfully..........");
            fuck_clear();
        }
        public void fuck_clear()
        {
            firstNametextbox.Clear();
            middleTextbox.Clear();
            lastNamebox.Clear();
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            nameList.Items.Clear();
            foreach(DetailsInfo info in detailsInfos)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = info.firstName;
                listViewItem.SubItems.Add(info.middleName);
                listViewItem.SubItems.Add(info.Lastname);
                listViewItem.SubItems.Add(info.GetName());
                //listViewItem.Text = info.GetName();
                nameList.Items.Add(listViewItem);
            }
        }
    }
}
