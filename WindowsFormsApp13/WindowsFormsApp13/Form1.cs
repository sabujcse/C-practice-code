using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        Vickle vickle = new Vickle();
        public Form1()
        {
            InitializeComponent();
        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            vickle.Name = NametextBox.Text;
            vickle.RegNo = RegtextBox.Text;

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
             double speedf = Convert.ToDouble(SpeedtextBox.Text);
            vickle.AddSpeed(speedf);
            SpeedtextBox.Clear();
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            double maxresult = vickle.GetMax();
            MaxtextBox.Text = Convert.ToString(maxresult);
            double minresult = vickle.Minspeed();
            MintextBox.Text = Convert.ToString(minresult);
            double averageResult = vickle.GetAbarage();
            averagetextBox.Text = Convert.ToString(averageResult);
        }
    }
}
