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

namespace StactManagment
{
    public partial class VSBTD : Form
    {
       DateTime FromdateTime, ToDate;
        private string Conectinostring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL; Database = SMSDB;Integrated Security=true";
        private SqlConnection sqlConnection;
        public VSBTD()
        {
            InitializeComponent();
        }
        
        private DataTable GetInfo(DateTime date1,  DateTime date2)
        {
            DataTable dataTable = new DataTable();

            try
            {

                sqlConnection = new SqlConnection(Conectinostring);

                string query = @"Select  i.ItemName as Item,
                                 StockOutQuantity as Quantity 
                                 FROM 
                                 StockOut st
                                 INNER JOIN Item i ON i.ID = st.ID where StockOutDate>='" +date1+ "' AND StockOutDate<='" + date2+"'";
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
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            FromdateTime = Convert.ToDateTime(FromdateTimePicker.Text);
            ToDate = Convert.ToDateTime(TodateTimePicker.Text);
            DataTable dataTable = GetInfo(FromdateTime,ToDate);
            dataGridView.DataSource = dataTable;
            
            
        }
    }
}
