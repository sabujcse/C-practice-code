using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string Name = NameBox.Text;
            string Address = AddressBox.Text;
            int CityId = Convert.ToInt32(CityTextBox.Text);
            try
            {
                string connectionstring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL;Database=Studentdb;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                string query = "INSERT INTO Students(Name,Address,CityId) VALUES('" + Name + "','" + Address + "'," + CityId + ")";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int q;
                if ((q = sqlCommand.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("Successfully Saved........");
                    NameBox.Clear();
                    AddressBox.Clear();
                    CityTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Not Saved");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
