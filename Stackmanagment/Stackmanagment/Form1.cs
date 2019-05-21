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
using Stackmanagment.Models;

namespace Stackmanagment
{
    public partial class Form1 : Form
    {
        private string Conectinostring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL; Database =SMSDB;Integrated Security=true";
        private SqlConnection sqlConnection;
       private Category Category = new Category();
        public Form1()
        {
            InitializeComponent();
            DataTable dataTable = GetAll();
            CategorycomboBox.DataSource = dataTable;
        }
        private DataTable GetAll()
        {
            DataTable dataTable = new DataTable();
            try
            {

                sqlConnection = new SqlConnection(Conectinostring);
                string query = @"Select ID, Name from Category";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }


            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            return dataTable;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
