using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_DB_05122022_3
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

                string queryString = "select ProductID, ProductName, UnitPrice, UnitsInStock from Products";

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ProductID = reader.GetInt32(0);
                            string ProductName = reader.GetString(1);
                            SqlMoney UnitPrice = reader.GetSqlMoney(2);
                            int UnitInStock = reader.GetInt16(3);
                            Product NP = new Product(ProductID, ProductName, UnitPrice, UnitInStock);
                            tbl.Add(NP.ProductId, NP);
                        }
                    }
                }
            }
        }

        private void pullBtn_Click(object sender, EventArgs e)
        {
            Product pulledProduct = (Product)tbl[Convert.ToInt32(itemNumBox.Text)];
            priceLabel.Text = "Price : " + pulledProduct.UnitPrice.Value.ToString();
            InventoryLabel.Text = "Inventory : " + pulledProduct.UnitInStock.ToString();
        }

        private void OPBtn_Click(object sender, EventArgs e)
        {
            string price = PriceBox.Text;
            // Connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryString = "select count(UnitPrice) from Products where UnitPrice > " + price;

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show("number of products above " + price + "$ : " + reader.GetInt32(0).ToString());
                        }
                    }
                }
            }
        }
    }

    public class Product
    {
        public Product(int Id, string Name, SqlMoney Price, int Stock)
        {
            this.ProductId = Id;
            this.ProductName = Name;
            this.UnitPrice = Price;
            this.UnitInStock = Stock;
        }

        private int _productId;

        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        private string _productName;

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        private SqlMoney _unitPrice;

        public SqlMoney UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        private int _unitInStock;

        public int UnitInStock
        {
            get { return _unitInStock; }
            set { _unitInStock = value; }
        }
    }
}
