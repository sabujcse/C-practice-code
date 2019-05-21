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

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string Code = codetextBox.Text;
            string Name = nametextBox.Text;
            int Cid = Convert.ToInt32(coureidtextBox.Text);
            string Coder = codetextBox.Text;
            if (Exist(Coder))
            {
                MessageBox.Show("This Subject Code Alredy Axist");
                return;
            }
            try
            {
                string connectionstring = DbWork("cannection");
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                string query = @"insert into Departments(Code,Name,Courseid)values('" + Code + "','" + Name + "'," + Cid + ")";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int exe = sqlCommand.ExecuteNonQuery();
                if (exe > 0)
                {
                    Showr();
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Not Saved");
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Showr();
        }
        public void Showr()
        {
            try
            {
                string connectionstring = DbWork("cannection");
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                string query = @"Select * from DepCourseView";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable != null)
                {
                    dataGridView.DataSource = dataTable;   
                }
                else
                {
                    dataGridView.DataSource = null;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(searchtextBox.Text);
            string Code = codetextBox.Text;
            string Name = nametextBox.Text;
            int Cid = Convert.ToInt32(coureidtextBox.Text);
            
            try
            {
                string connectionstring = DbWork("cannection");
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
             
                string query = @"update Departments set Code = '" +Code+ "', Name='"+Name+"', Courseid=" + Cid +" where Id= "+id+"";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int exe = sqlCommand.ExecuteNonQuery();
                if (exe > 0)
                {
                    Showr();
                    MessageBox.Show("Update");
                }
                else
                {
                    MessageBox.Show("Not Update");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int qid = Convert.ToInt32(searchtextBox.Text);
            try
            {
                string connectionstring = DbWork("cannection");
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                string query = @"delete from Departments where Id = " + qid+"";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int exe = sqlCommand.ExecuteNonQuery();
                if (exe > 0)
                {
                    Showr();
                    MessageBox.Show("Delete");
                }
                else
                {
                    MessageBox.Show("Not Delete");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            int qid = Convert.ToInt32(searchtextBox.Text);
            try
            {
                string connectionstring = DbWork("cannection");
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                string query = @"SELECT * FROM DepCourseView where Id =" + qid + "";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private bool Exist(string depCode)
        {
            bool isExist = false;
            try
            {
                string connectionstring = DbWork("cannection");
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                string query = @"SELECT * FROM Departments where Code ='" + depCode + "'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                string data = "";
                if (sqlDataReader.Read())
                {
                    data = sqlDataReader["Id"].ToString();
                }
                if (!String.IsNullOrEmpty(data))
                {
                    isExist = true;
                }
                else
                {
                    isExist = false;
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return isExist;
        }
        public string DbWork(string con)
        {
          
            if (con == "cannection") { 
                string connectionstring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL;Database=Depcourse;Integrated Security=true";
                return connectionstring;
            }
            return "Faild To Connect";
        }
    }
}
