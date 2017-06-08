using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using System.Data.SqlClient;
using NorthwindClasses;

namespace ADOnet
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            GetProductsForDropDown();
        }

        public void GetProductsForDropDown()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-698P2MHO\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName FROM Products", con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Load(reader);
            try
            {
                cbDelProduct.ValueMember = "ProductID";
                cbDelProduct.DisplayMember = "ProductName";
                cbDelProduct.DataSource = dt;
                cbDelProduct.Items.Add(dt);
                reader.Close();
            }
            catch (Exception)
            {

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            Products product = new Products();


            product.productID = (int)cbDelProduct.SelectedValue;
            DeleteProduct(product);
            

        }

        public static int DeleteProduct(Products product)
        {            
            int rowsRemoved = 0;
            if (product != null)
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-698P2MHO\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
                SqlCommand checkcmd = new SqlCommand("SELECT COUNT ProductID FROM Order Details WHERE ProductID = @productID", con);
                SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID = @productID", con);
                cmd.Parameters.AddWithValue("@productID", product.productID);
                checkcmd.Parameters.AddWithValue("@productID", product.productID);

                try
                {
                    con.Open();
                    int orderId = (int)checkcmd.ExecuteScalar();
                    if (orderId == 0)
                    {
                        rowsRemoved = (int)cmd.ExecuteNonQuery();
                        return rowsRemoved;
                    }
                    else
                    {
                        string message = "Kan niet verwijderd worden, er staan nog orders voor dit product.";
                        MessageBox.Show(message);
                        return rowsRemoved;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }

                return rowsRemoved;
            }
            return rowsRemoved;
        }
    }
}
