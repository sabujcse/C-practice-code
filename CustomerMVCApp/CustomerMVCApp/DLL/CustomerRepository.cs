using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerMVCApp.Models;
using System.Data.SqlClient;
using System.Data;

namespace CustomerMVCApp.DLL
{
    public class CustomerRepository
    {
        private static string Conectinostring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL; Database = SHOPDBS;Integrated Security=true";
        static SqlConnection connection = new SqlConnection(Conectinostring);
        SqlCommand command = new SqlCommand("", connection);
        public bool checkSave = false;
        public bool SaveData(Customer customer)
        {
            string query = @"insert into Customersdb(Name,Code,Address,Email,Contact,Age,LoyalityPoint)values('" + customer.Name + "','" + customer.Code + "','" + customer.Address + "','" + customer.Email + "','"+customer.Contact+"',"+customer.Age+","+customer.LoyalityPoin+")";
            command.CommandText = query;
            connection.Open();
            int queryTrack = command.ExecuteNonQuery();
            if (queryTrack > 0){checkSave = true;}
            connection.Close();
            return checkSave;
        } 
        public DataTable CustomerData(string name)
        {
            string query; 
            if (name != null ) { query = @"select * from Customersdb where Name= '" + name + "'";}
            else { query = @"select *from Customersdb"; };
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            return data;
        } 
        public bool DeleteDataByCode(string code)
        {
            string findIdQuery = @"select * from Customersdb where Code = '" + code + "'";
            connection.Open();
            command.CommandText = findIdQuery;
            SqlDataReader sqlDataReader = command.ExecuteReader();
            string id = "";
            if (sqlDataReader.Read()) { id = sqlDataReader["Id"].ToString(); }
            int Id = Convert.ToInt32(id);
            connection.Close();
            connection.Open();
            string deleteQuery = @"Delete from Customersdb where Id = "+Id;
            command.CommandText = deleteQuery;
            int isDeleted = command.ExecuteNonQuery();
            if (isDeleted>0){checkSave = true;}
            return checkSave;
        }
        public bool UpdateCustomerDataByCode(Customer customer)
        {
            string findIdQuery = @"select *from Customersdb where Code = '" + customer.Code + "';";
            connection.Open();
            command.CommandText = findIdQuery;
            SqlDataReader sqlDataReader = command.ExecuteReader();
            string id = "";
            if (sqlDataReader.Read()){ id = sqlDataReader["Id"].ToString(); }
            customer.Id = Convert.ToInt32(id);
            connection.Close();
            connection.Open();
            string updateQuery = @"UPDATE Customersdb SET Name = '" + customer.Name + "',Code = '" + customer.Code + "',Address = '" + customer.Address + "',Email = '" +
            customer.Email + "',Contact= '" + customer.Contact + "',Age = " + customer.Age + ",LoyalityPoint = " + customer.LoyalityPoin + " WHERE Id = " + customer.Id;
            command.CommandText = updateQuery;
            int QueryTrack = command.ExecuteNonQuery();
            if (QueryTrack > 0)
            {
                checkSave = true;
            }
            connection.Close();
            return checkSave;
        }
    }
}