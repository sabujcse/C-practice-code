using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using CustomerMVc.Models;
using System.Data;

namespace CustomerMVc.DAL
{
    public class CustomerRep
    {
       private static string Conectinostring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL; Database = SHopdb;Integrated Security=true";
        static SqlConnection connection = new SqlConnection(Conectinostring);
        SqlCommand command = new SqlCommand("", connection);

        public bool IsSaved(CustomerClass customer)
        {
            bool check = false;
            string query = @"insert into Customer(Id,Name,Address,Code,Email)values("+customer.Id+",'" + customer.Name + "','" + customer.Address + "'," + customer.Code + ",'" + customer.Email + "')";
            command.CommandText = query;
            connection.Open();
            int v = command.ExecuteNonQuery();
            if (v > 0)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            connection.Close();
            return check;
        }
        public DataTable Show()
        {
            string query = "select * from Customer";
            SqlDataAdapter sqlData = new SqlDataAdapter(query,connection);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            return table;

        }


        
    }
}