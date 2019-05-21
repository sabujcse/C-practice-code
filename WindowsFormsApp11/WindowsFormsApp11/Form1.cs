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

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text;
            string address = addresstextBox.Text;
            string contact = contacttextBox.Text;
            string RegNo = reghNotextBox.Text;
            int depid = Convert.ToInt32(depidtextBox.Text);

            if (Exist(RegNo))
            {
                MessageBox.Show("Alredy Exist");
                return;
            }
            try
            {
                string connectionstring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL;Database=Studentsdb;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                string query = @"insert into Students(Name,Address,Contact,RegNo,DepartmentId)values('" + name + "','" + address + "','" + contact + "','" + RegNo + "'," + depid + ")";
                SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
                sqlConnection.Open();
                int exe = sqlCommand.ExecuteNonQuery();
                if (exe>0)
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

        private void showbutton_Click(object sender, EventArgs e)
        {
            Showr();   
        }
        public void Showr()
        {
            try
            {
                string connectionstring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL;Database=Studentsdb;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                string query = @"Select * from studentview";
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
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text;
            string address = addresstextBox.Text;
            string contact = contacttextBox.Text;
            string RegNo = reghNotextBox.Text;
            int depid = Convert.ToInt32(depidtextBox.Text);
            int qid = Convert.ToInt32(serchText.Text);
            try
            {
                string connectionstring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL;Database=Studentsdb;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                string query = @"update Students set Name = '"+name+"',Address='"+address+ "',Contact='" + contact+"',RegNo='"+RegNo+ "' where DepartmentId="+depid+"";
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
            int qid = Convert.ToInt32(serchText.Text);
            try
            {
                string connectionstring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL;Database=Studentsdb;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                string query = @"delete from Students where ID = " +qid+"";
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
            int qid = Convert.ToInt32(serchText.Text);
            try
            {
                string connectionstring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL;Database=Studentsdb;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                string query = @"SELECT * FROM studentview where ID =" + qid+"";
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
        private bool Exist(string regNo)
        {
            bool isExist = false;
            try
            {
                string connectionstring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL;Database=Studentsdb;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                string query = @"SELECT * FROM studentview where RegNo ='" + regNo+ "'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                string data = "";
                if (sqlDataReader.Read())
                {
                    data = sqlDataReader["ID"].ToString();
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
    }
}
