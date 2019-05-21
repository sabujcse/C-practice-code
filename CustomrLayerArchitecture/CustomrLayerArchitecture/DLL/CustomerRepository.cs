using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using CustomrLayerArchitecture.Models;

namespace CustomrLayerArchitecture.DLL
{
    public class CustomerRepository
    {
        private static string connection = ConfigurationManager.ConnectionStrings["CustomertblEntities"].ToString();
        public static  SqlConnection sqlConnection = new SqlConnection(connection);
        public  SqlCommand sqlCommand = new SqlCommand("",sqlConnection);
        public bool Saved(Customer customer)
        {
            bool check = false;
            string Query = @"INSERT INTO Customers([Name],[Code],[Address],[Email ],[Age],[LoyalityPoint]) values('" + customer.Name + "','" + customer.Code + "','" + customer.Address + "','" + customer.Email + "'," + customer.Age + "," + customer.LoyalityPoint + ")";
            sqlConnection.Open();
            sqlCommand.CommandText = Query;
            int save = sqlCommand.ExecuteNonQuery();
            if (save>0)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
    }
}