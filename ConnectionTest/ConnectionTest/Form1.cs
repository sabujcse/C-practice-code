﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnectionTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-9M0BR8U\\SABUJSSQL;Initial Catalog=connectionDB;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if(con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Test(id,name)values('"+ texId.Text.ToString()+"','"+textName.Text.ToString()+"')";
                SqlCommand sqlCommand = new SqlCommand(q,con);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Connection Made Successfully.......!");

            }

        }
    }
}
