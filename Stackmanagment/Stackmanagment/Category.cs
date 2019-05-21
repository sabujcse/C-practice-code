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
    public partial class Category : Form
    {
        private string Conectinostring = @"Server=DESKTOP-9M0BR8U\SABUJSSQL;Database = StackManagment;Integrated Security=true";
        private SqlConnection sqlConnection;
        private Category category = new Category();
       
        public Category()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
