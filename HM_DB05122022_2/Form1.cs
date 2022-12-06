using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_DB05122022_2
{

    public partial class Form1 : Form
    {
        const string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=localhost\\sqlexpress";

        Hashtable tbl = new Hashtable();

        public Form1()
        {
            InitializeComponent();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            // Connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryString = "select EmployeeID, LastName, FirstName from Employees";

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int employeeID = reader.GetInt32(0);
                            string lastName = reader.GetString(1);
                            string firstName = reader.GetString(2);
                            tbl.Add(employeeID, (lastName + " " + firstName));
                        }
                    }
                }
            }
        }

        private void empBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show((string)tbl[Convert.ToInt32(empNumBox.Text)]);
        }
    }
}
