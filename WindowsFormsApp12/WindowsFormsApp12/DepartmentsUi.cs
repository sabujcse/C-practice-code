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
using WindowsFormsApp12.Models;

namespace WindowsFormsApp12
{
    public partial class DepartmentsUi : Form
    {
        string connectionstring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL;Database=Depcourse;Integrated Security=true";
        private SqlConnection sqlConnection;
        Departments departments = new Departments();
        public DepartmentsUi()
        {
            InitializeComponent();
            DataTable dataTable =  GetData();
            comboBox1.DataSource = dataTable;

        }
        private DataTable GetData()
        {
            DataTable dataTable = new DataTable();
            try
            {

                sqlConnection = new SqlConnection(connectionstring);
                string query = @"Select Id,Name from Coures";
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

           // return dataTable;
            
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            departments.Code = codetextBox.Text;
            departments.Name = nametextBox.Text;
            departments.Courseid = Convert.ToInt32(comboBox1.SelectedValue);
            if (Add(departments))
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("Alredy Exist");
            }
        }
        private bool existcheck(Departments departments)
        {
            bool isExist = false;
            try
            {
                
                sqlConnection = new SqlConnection(connectionstring);
                string query = @"SELECT * FROM Departments where Code ='" + departments.Code + "'";
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
        private bool Add(Departments departments)
        {
            bool checker = false;
            bool flag = true;
            if(existcheck(departments)){flag = false;}
            if (flag == false){return false;}
            else
            {
                try
                {

                    sqlConnection = new SqlConnection(connectionstring);
                    string query = @"insert into Departments(Code,Name,Courseid)values('" + departments.Code + "','" + departments.Name + "'," + departments.Courseid + ")";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    int exe = sqlCommand.ExecuteNonQuery();
                    if (exe > 0)
                    {
                      checker = true;
                    }
                    else
                    { 
                        checker = false;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                return checker;
            }
        }

        private void DepartmentsUi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'depcourseDataSet.Coures' table. You can move, or remove it, as needed.
            this.couresTableAdapter.Fill(this.depcourseDataSet.Coures);

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = GetAll();
            dataGridView.DataSource = dataTable;
        }
        private DataTable GetAll()
        {
            DataTable dataTable = new DataTable();
            try
            {

                sqlConnection = new SqlConnection(connectionstring);
                string query = @"Select * from DepCourseView";
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

        private void updatebutton_Click(object sender, EventArgs e)
        {
            departments.Code = codetextBox.Text;
            departments.Name = nametextBox.Text;
            departments.Courseid = Convert.ToInt32(comboBox1.SelectedValue);
            departments.Id = Convert.ToInt32(searchtextBox.Text);
            if (updateReturn(departments))
            {
                MessageBox.Show("Update");
            }
            else
            {
                MessageBox.Show("Not Update");
            }
        }
        private bool updateReturn(Departments departments)
        {
            bool cheker = false;
            try
            {
                
                 sqlConnection = new SqlConnection(connectionstring);

                string query = @"update Departments set Code = '" +departments.Code + "', Name='" +departments.Name + "', Courseid=" + departments.Courseid+ " where Id= " + departments.Id+"";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int exe = sqlCommand.ExecuteNonQuery();
                if (exe > 0)
                {

                    cheker = true;
                   // MessageBox.Show("Update");
                }
                else
                {
                    cheker = false;
                    //MessageBox.Show("Not Update");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return cheker;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            departments.Id = Convert.ToInt32(searchtextBox.Text);
            if (dlt(departments))
            {
                MessageBox.Show("Delete");
            }
            else
            {
                MessageBox.Show("Not Delete");
            }
        }
        private bool dlt(Departments departments)
        {
            bool chker = false;
            try
            {
               
                 sqlConnection = new SqlConnection(connectionstring);
                string query = @"delete from Departments where Id = " + departments.Id + "";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int exe = sqlCommand.ExecuteNonQuery();
                if (exe > 0)
                {

                    chker = true;
                    //MessageBox.Show("Delete");
                }
                else
                {
                    chker = false;
                    //MessageBox.Show("Not Delete");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return chker;
        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            departments.Id = Convert.ToInt32(searchtextBox.Text);
            DataTable dataTable = GetAll(departments);
            dataGridView.DataSource = dataTable;
        }
        private DataTable GetAll(Departments departments)
        {
            DataTable dataTable = new DataTable();
            try
            {

                sqlConnection = new SqlConnection(connectionstring);
                string query = @"Select * from DepCourseView where Id="+departments.Id+"";
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
        private DataTable GetCourseName(Departments departments)
        {
            DataTable dataTable = new DataTable();
            try
            {

                sqlConnection = new SqlConnection(connectionstring);
                string query = @"Select Id,Name from Departments where Courseid= " + departments.Courseid+"";
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            departments.Courseid = Convert.ToInt32(comboBox1.SelectedValue);
            comboBox2.DataSource = GetCourseName(departments);
        }
    }
}
