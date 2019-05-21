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
    public partial class CategoryUi : Form
    {
        private string Conectinostring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL;Database = StackManagment;Integrated Security=true";
        private SqlConnection sqlConnection;
        private Categorys categorys = new Categorys();
        public CategoryUi()
        {
            InitializeComponent();
        }

        private void CategorytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            categorys.Ctegoryname = CategorytextBox.Text;
            if (Add(categorys))
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
        }
        private bool Add(Categorys categorys)
        {
            bool checker = false;
            try
            {

                sqlConnection = new SqlConnection(Conectinostring);
                string query = @"insert into CategoryTableDB(Name)values('" + categorys.Ctegoryname+"')";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int ext = sqlCommand.ExecuteNonQuery();
                if (ext > 0)
                {

                    checker = true;
                }
                else
                {
                    checker = false;
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            return checker;
        }
    }
}
