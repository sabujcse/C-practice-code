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
using StactManagment.Models;

namespace StactManagment
{
    public partial class Form1 : Form
    {
        string CompanyName, CategoryName;
        int i = 0;
        private string Conectinostring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL; Database = SMSDB;Integrated Security=true";
        private SqlConnection sqlConnection;
        private Category category = new Category();
        private Company company = new Company();
        private CategoryCompany categorycompany = new CategoryCompany();
        private Item item = new Item();
        public Form1()
        {
            InitializeComponent();
            DataTable data = GetAlls();
            CompanycomboBox.DataSource = data;
            DataTable dataTable = GetAll();
            CategorycomboBox.DataSource = dataTable;
        }
        private DataTable GetAlls()
        {
            DataTable dataTable = new DataTable();

            try
            {

                sqlConnection = new SqlConnection(Conectinostring);
                string query = @"Select ID, Name from Company";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);

                //if(String.IsNullOrEmpty(dataTable))

                sqlConnection.Close();
            }


            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

            return dataTable;
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
        private DataTable GetINfo(string Company, string Category)
        {
            DataTable dataTable = new DataTable();

            try
            {

                sqlConnection = new SqlConnection(Conectinostring);
                string query = @"SELECT 
                i.ItemName as[Item],
                c.Name as[Company],
                ca.Name as[Category],
                i.AvailableQuantity,
                i.ReorderLevel
                FROM 
                StockIN st
                INNER JOIN Company c ON c.ID = st.CompanyID
                INNER JOIN Item i ON i.ID = st.ItemID
                INNER JOIN Category ca ON ca.ID = i.CategoryID 
                where c.Name = '" + Company + "' and ca.Name = '"+Category+"'";
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

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           
        }

        private void CompanycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            CompanyName = CompanycomboBox.Text;
            CategoryName = CategorycomboBox.Text;
            DataTable dataTable = GetINfo(CompanyName, CategoryName);
            dataGridView.DataSource = dataTable;
           
            
        }
    }
}
