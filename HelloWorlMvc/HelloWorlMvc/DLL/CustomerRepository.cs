using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using HelloWorlMvc.BLL;
using HelloWorlMvc.Models;
using System.Data.SqlClient;
using System.Data;

namespace HelloWorlMvc.DLL
{
    public class CustomerRepository
    {
        private static string Conectinostring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL; Database = Studentdb;Integrated Security=true";
        static SqlConnection connection = new SqlConnection(Conectinostring);
        SqlCommand command = new SqlCommand("", connection);
        public bool checkSave = false;
        public bool SaveData(Student student)
        {
            string query = @"insert into Student(Name,SubDistrictId)values('" + student.Name + "',"+student.SubDistrictId+")";
            command.CommandText = query;
            connection.Open();
            int queryTrack = command.ExecuteNonQuery();
            if (queryTrack > 0) { checkSave = true; }
            connection.Close();
            return checkSave;
        }

        public bool Udatedata(Student student)
        {
            string query = @"Update Student Set Name='"+student.Name+ "',SubDistrictId="+student.SubDistrictId+",Address='"+student.Address+"' where Id="+student.Id+"";
            command.CommandText = query;
            connection.Open();
            int queryTrack = command.ExecuteNonQuery();
            if (queryTrack > 0) { checkSave = true; }
            connection.Close();
            
            return checkSave;
        }

        public List<Student> Search(Student student)
        {
            var dataList = new List<Student>();
            string Query = "";
            if (!string.IsNullOrEmpty(student.RegNo))
            {
                Query = @"Select * from Student Where RegNo='" + student.RegNo + "'";
            }
            else
            {
                Query = @"Select * from Student";
            }

            command.CommandText = Query;
            connection.Open();
            var dt = new DataTable();
            var da = new SqlDataAdapter(command);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    var studentobject = new Student();
                    studentobject.Id = Convert.ToInt32(row["Id"]);
                    studentobject.Name = row["Name"].ToString();
                    studentobject.RegNo = row["RegNo"].ToString();
                    studentobject.SubDistrictId = Convert.ToInt32(row["SubDistrictId"]);
                    studentobject.Address = row["Address"].ToString();
                    dataList.Add(studentobject);
                }
            }
            connection.Close();
            return dataList;
        }
        public Student GetById(int id)
        {
            string query = @"Select * from Student Where Id=" + id + "";
            command.CommandText = query;
            connection.Open();
            SqlDataReader sqlData = command.ExecuteReader();
            var studentobject=new Student(); ;
            if (sqlData.Read() && sqlData.HasRows)
            {
                 
                studentobject.Id = Convert.ToInt32(sqlData["Id"]);
                studentobject.Name = sqlData["Name"].ToString();
                studentobject.RegNo = sqlData["RegNo"].ToString();
                studentobject.SubDistrictId = Convert.ToInt32(sqlData["SubDistrictId"]);
                studentobject.Address = sqlData["Address"].ToString();
                connection.Close();
           

            }
            connection.Close();
            return studentobject;

        }
    }
}