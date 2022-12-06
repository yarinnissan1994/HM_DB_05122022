using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_DB_05122022
{
    public partial class Form1 : Form
    {
        const string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=localhost\\sqlexpress";

        public Form1()
        {
            InitializeComponent();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            // Connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryString = "select count(orderID) from orders";

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orderBox.Text = reader.GetInt32(0).ToString();
                        }
                    }
                }

            }
        }

        private void custBtn_Click(object sender, EventArgs e)
        {
            // Connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryString = "select count(CustomerID) from Customers";

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show(reader.GetInt32(0).ToString());
                        }
                    }
                }
            }

        }
    }
}

